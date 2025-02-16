﻿using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

using FlashpointInstaller.Common;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace FlashpointInstaller
{
    public partial class Main : Form
    {
        public Main() => InitializeComponent();

        private void Main_Load(object sender, EventArgs e)
        {
            About.Text += $" v{Application.ProductVersion}";

            XmlNodeList rootElements = FPM.XmlTree.GetElementsByTagName("list");

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

            DestinationPath.Text = Path.Combine(Path.GetPathRoot(AppDomain.CurrentDomain.BaseDirectory), "Flashpoint");
        }

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://flashpointarchive.org/") { UseShellExecute = true });
        }

        public void ComponentList_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            bool required = e.Node.Tag.GetType().ToString().EndsWith("Component")
                ? (e.Node.Tag as Component).Required
                : (e.Node.Tag as Category).Required;

            if (required && e.Node.Checked) e.Cancel = true;
        }

        private void ComponentList_AfterCheck(object sender, TreeViewEventArgs e)
        {
            long size = 0;

            FPM.IterateList(ComponentList.Nodes, node =>
            {
                if (!node.Checked || !node.Tag.GetType().ToString().EndsWith("Component")) return;

                size += (node.Tag as Component).Size;
            });

            InstallButton.Text = $"Install Flashpoint ({FPM.GetFormattedBytes(size)})";
        }

        private void ComponentList_BeforeSelect(object _, TreeViewCancelEventArgs e)
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

        private void DestinationPathBrowse_Click(object _, EventArgs e)
        {
            var pathDialog = new CommonOpenFileDialog() { IsFolderPicker = true };
            
            if (pathDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string path = Path.Combine(pathDialog.FileName, "Flashpoint");

                if (FPM.VerifyDestinationPath(path)) DestinationPath.Text = path;
            }
        }

        private void DestinationPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                InstallButton_Click(this, e);
                e.Handled = true;
            }
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            if (!FPM.VerifyDestinationPath(DestinationPath.Text) || !FPM.CheckDependencies()) return;

            if (Directory.Exists(DestinationPath.Text) && Directory.EnumerateFileSystemEntries(DestinationPath.Text).Any())
            {
                var pathDialog = MessageBox.Show(
                    "There are already files in the specified path.\n\n" +
                    "If you uninstall Flashpoint, these files will be deleted as well.\n\n" +
                    "Are you sure you want to continue?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                );

                if (pathDialog == DialogResult.No) return;
            }

            if (DestinationPath.Text.Length >= 192)
            {
                var pathDialog = MessageBox.Show(
                    "The specified path is extremely long. This may cause certain functionality to break.\n\n" +
                    "Are you sure you want to continue?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                );

                if (pathDialog == DialogResult.No) return;
            }

            if (!FPM.RedistInstalled)
            {
                var redistDialog = MessageBox.Show(
                    "The Flashpoint launcher requires the Visual C++ 2015 x86 redistributable, which you do not appear to have installed.\n\n" +
                    "It will be installed automatically if you choose to continue.",
                    "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information
                );

                if (redistDialog == DialogResult.Cancel) return;
            }

            new Operate().ShowDialog();
        }
    }
}
