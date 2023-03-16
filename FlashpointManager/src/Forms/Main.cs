﻿using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

using FlashpointInstaller.Common;

namespace FlashpointInstaller
{
    public partial class Main : Form
    {
        public Main() => InitializeComponent();

        private void Main_Load(object sender, EventArgs e)
        {
            Text += $" v{Application.ProductVersion}";

            using (XmlNodeList rootElements = FPM.XmlTree.GetElementsByTagName("list"))
            {
                if (rootElements.Count > 0)
                {
                    FPM.RecursiveAddToList(rootElements[0], ComponentList.Nodes);
                }
                else
                {
                    MessageBox.Show(
                        "An error occurred while parsing the component list XML. Please alert Flashpoint staff ASAP!\n\n" +
                        "Description: Root element was not found",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                    );

                    Environment.Exit(1);
                }
            }

            FPM.SyncManager(true);

            if (FPM.AutoDownload.Count > 0)
            {
                foreach (string id in FPM.AutoDownload)
                {
                    var query = ComponentList.Nodes.Find(id, true);
                    if (query.Length > 0) query[0].Checked = true;
                }

                FPM.CheckDependencies(false);

                new Operate() { TopMost = true }.ShowDialog();

                Close();
            }

            if (FPM.OpenUpdateTab) TabControl.SelectTab(1);
        }

        public void ComponentList_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            bool required = e.Node.Tag.GetType().ToString().EndsWith("Component")
                ? (e.Node.Tag as Component).Required
                : (e.Node.Tag as Category).Required;

            if (required && e.Node.Checked) e.Cancel = true;
        }

        public void ComponentList_AfterCheck(object sender, TreeViewEventArgs e)
        {
            long size = 0;

            FPM.IterateList(ComponentList.Nodes, node =>
            {
                if (!node.Checked || !node.Tag.GetType().ToString().EndsWith("Component")) return;

                var component = node.Tag as Component;

                size += FPM.ComponentTracker.Downloaded.Exists(c => c.ID == component.ID)
                    ? long.Parse(File.ReadLines(component.InfoFile).First().Split(' ')[1])
                    : component.Size;
            });

            ChangeButton.Text = $"Apply changes ({FPM.GetFormattedBytes(size - FPM.DownloadedSize)})";
            ChangeButton.Enabled = true;
        }

        private void ComponentList_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Tag.GetType().ToString().EndsWith("Component"))
            {
                var component = e.Node.Tag as Component;

                DescriptionBox.Text = "Component Description";
                Description.Text = component.Description + $" ({FPM.GetFormattedBytes(component.Size)})";
            }
            else
            {
                long categorySize = 0;
                FPM.IterateList(e.Node.Nodes, node =>
                {
                    if (node.Tag.GetType().ToString().EndsWith("Component"))
                    {
                        categorySize += (node.Tag as Component).Size;
                    }
                });

                DescriptionBox.Text = "Category Description";
                Description.Text = (e.Node.Tag as Category).Description + $" ({FPM.GetFormattedBytes(categorySize)})";
            }

            if (!DescriptionBox.Visible) DescriptionBox.Visible = true;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (!FPM.CheckDependencies()) return;

            FPM.UpdateMode = false;

            new Operate().ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            FPM.UpdateMode = true;

            new Operate().ShowDialog();
        }

        private async void RemoveButton_Click(object sender, EventArgs e)
        {
            TabControl.Enabled = false;

            await Task.Run(() => {
                foreach (string file in Directory.EnumerateFileSystemEntries(FPM.SourcePath, "*", SearchOption.AllDirectories))
                {
                    try { FPM.DeleteFileAndDirectories(file); } catch { }
                }

                var shortcutPaths = new string[]
                {
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), "Flashpoint.lnk"),
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),   "Flashpoint.lnk")
                };

                foreach (string path in shortcutPaths)
                {
                    try { File.Delete(path); } catch { }
                }
            });

            MessageBox.Show(
                "Flashpoint has been uninstalled from your system.",
                "Uninstallation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information
            );

            Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FPM.OpenLauncherOnClose)
            {
                new Process() { StartInfo = {
                    UseShellExecute = true,
                    FileName = "Flashpoint.exe",
                    WorkingDirectory = Path.Combine(FPM.SourcePath, "Launcher")
                }}.Start();
            }
        }
    }
}
