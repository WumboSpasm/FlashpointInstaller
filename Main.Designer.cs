﻿namespace FlashpointInstaller
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.About = new System.Windows.Forms.Label();
            this.DownloadPathBox = new System.Windows.Forms.GroupBox();
            this.DownloadPath = new System.Windows.Forms.TextBox();
            this.DownloadPathBrowse = new System.Windows.Forms.Button();
            this.Install = new System.Windows.Forms.Button();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.DownloadTab = new System.Windows.Forms.TabPage();
            this.DownloadMessage2 = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.GroupBox();
            this.Description = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ShortcutStartMenu = new System.Windows.Forms.CheckBox();
            this.ShortcutLabel = new System.Windows.Forms.Label();
            this.ShortcutDesktop = new System.Windows.Forms.CheckBox();
            this.DownloadSizeDisplay = new System.Windows.Forms.Label();
            this.DownloadSizeLabel = new System.Windows.Forms.Label();
            this.DownloadMessage = new System.Windows.Forms.Label();
            this.ComponentList = new RikTheVeggie.TriStateTreeView();
            this.UpdateTab = new System.Windows.Forms.TabPage();
            this.ManagerMessage2 = new System.Windows.Forms.Label();
            this.ManagerMessage = new System.Windows.Forms.Label();
            this.ManagerSizeDisplay = new System.Windows.Forms.Label();
            this.ManagerSizeLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.FlashpointPathBox = new System.Windows.Forms.GroupBox();
            this.FlashpointPath = new System.Windows.Forms.TextBox();
            this.FlashpointPathBrowse = new System.Windows.Forms.Button();
            this.DescriptionBox2 = new System.Windows.Forms.GroupBox();
            this.Description2 = new System.Windows.Forms.Label();
            this.ComponentList2 = new RikTheVeggie.TriStateTreeView();
            this.RemoveTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.DownloadPathBox.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.DownloadTab.SuspendLayout();
            this.DescriptionBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.UpdateTab.SuspendLayout();
            this.FlashpointPathBox.SuspendLayout();
            this.DescriptionBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(600, 177);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // About
            // 
            this.About.AutoSize = true;
            this.About.Location = new System.Drawing.Point(12, 192);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(124, 13);
            this.About.TabIndex = 1;
            this.About.Text = "Flashpoint Manager v1.0";
            // 
            // DownloadPathBox
            // 
            this.DownloadPathBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DownloadPathBox.Controls.Add(this.DownloadPath);
            this.DownloadPathBox.Controls.Add(this.DownloadPathBrowse);
            this.DownloadPathBox.Location = new System.Drawing.Point(7, 199);
            this.DownloadPathBox.Name = "DownloadPathBox";
            this.DownloadPathBox.Size = new System.Drawing.Size(576, 49);
            this.DownloadPathBox.TabIndex = 2;
            this.DownloadPathBox.TabStop = false;
            this.DownloadPathBox.Text = "Destination folder:";
            // 
            // DownloadPath
            // 
            this.DownloadPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadPath.Location = new System.Drawing.Point(9, 18);
            this.DownloadPath.Name = "DownloadPath";
            this.DownloadPath.Size = new System.Drawing.Size(477, 20);
            this.DownloadPath.TabIndex = 1;
            this.DownloadPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DownloadPath_KeyPress);
            // 
            // DownloadPathBrowse
            // 
            this.DownloadPathBrowse.Location = new System.Drawing.Point(495, 17);
            this.DownloadPathBrowse.Name = "DownloadPathBrowse";
            this.DownloadPathBrowse.Size = new System.Drawing.Size(73, 22);
            this.DownloadPathBrowse.TabIndex = 0;
            this.DownloadPathBrowse.Text = "Browse";
            this.DownloadPathBrowse.UseVisualStyleBackColor = true;
            this.DownloadPathBrowse.Click += new System.EventHandler(this.DownloadPathBrowse_Click);
            // 
            // Install
            // 
            this.Install.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Install.Location = new System.Drawing.Point(300, 256);
            this.Install.Name = "Install";
            this.Install.Size = new System.Drawing.Size(284, 26);
            this.Install.TabIndex = 2;
            this.Install.Text = "Download Flashpoint";
            this.Install.UseVisualStyleBackColor = true;
            this.Install.Click += new System.EventHandler(this.Download_Start);
            // 
            // Link
            // 
            this.Link.AutoSize = true;
            this.Link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(94)))), ((int)(((byte)(221)))));
            this.Link.Location = new System.Drawing.Point(441, 192);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(171, 13);
            this.Link.TabIndex = 4;
            this.Link.TabStop = true;
            this.Link.Text = "https://bluemaxima.org/flashpoint/";
            this.Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_LinkClicked);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.DownloadTab);
            this.TabControl.Controls.Add(this.UpdateTab);
            this.TabControl.Controls.Add(this.RemoveTab);
            this.TabControl.ItemSize = new System.Drawing.Size(150, 20);
            this.TabControl.Location = new System.Drawing.Point(12, 229);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(600, 320);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 5;
            // 
            // DownloadTab
            // 
            this.DownloadTab.Controls.Add(this.DownloadMessage2);
            this.DownloadTab.Controls.Add(this.DescriptionBox);
            this.DownloadTab.Controls.Add(this.tableLayoutPanel1);
            this.DownloadTab.Controls.Add(this.DownloadSizeDisplay);
            this.DownloadTab.Controls.Add(this.DownloadSizeLabel);
            this.DownloadTab.Controls.Add(this.DownloadMessage);
            this.DownloadTab.Controls.Add(this.ComponentList);
            this.DownloadTab.Controls.Add(this.DownloadPathBox);
            this.DownloadTab.Controls.Add(this.Install);
            this.DownloadTab.Location = new System.Drawing.Point(4, 24);
            this.DownloadTab.Name = "DownloadTab";
            this.DownloadTab.Padding = new System.Windows.Forms.Padding(3);
            this.DownloadTab.Size = new System.Drawing.Size(592, 292);
            this.DownloadTab.TabIndex = 0;
            this.DownloadTab.Text = "Download Flashpoint";
            this.DownloadTab.UseVisualStyleBackColor = true;
            // 
            // DownloadMessage2
            // 
            this.DownloadMessage2.Location = new System.Drawing.Point(410, 44);
            this.DownloadMessage2.Name = "DownloadMessage2";
            this.DownloadMessage2.Size = new System.Drawing.Size(172, 30);
            this.DownloadMessage2.TabIndex = 13;
            this.DownloadMessage2.Text = "Click on a component to learn more about it.";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Controls.Add(this.Description);
            this.DescriptionBox.Location = new System.Drawing.Point(411, 116);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.DescriptionBox.Size = new System.Drawing.Size(163, 75);
            this.DescriptionBox.TabIndex = 12;
            this.DescriptionBox.TabStop = false;
            this.DescriptionBox.Text = "Component Description";
            // 
            // Description
            // 
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Location = new System.Drawing.Point(10, 21);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(143, 44);
            this.Description.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.ShortcutStartMenu, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ShortcutLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ShortcutDesktop, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 255);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 26);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // ShortcutStartMenu
            // 
            this.ShortcutStartMenu.AutoSize = true;
            this.ShortcutStartMenu.Checked = true;
            this.ShortcutStartMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShortcutStartMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShortcutStartMenu.Location = new System.Drawing.Point(193, 3);
            this.ShortcutStartMenu.Name = "ShortcutStartMenu";
            this.ShortcutStartMenu.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ShortcutStartMenu.Size = new System.Drawing.Size(78, 20);
            this.ShortcutStartMenu.TabIndex = 2;
            this.ShortcutStartMenu.Text = "Start Menu";
            this.ShortcutStartMenu.UseVisualStyleBackColor = true;
            // 
            // ShortcutLabel
            // 
            this.ShortcutLabel.AutoSize = true;
            this.ShortcutLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShortcutLabel.Location = new System.Drawing.Point(3, 3);
            this.ShortcutLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ShortcutLabel.Name = "ShortcutLabel";
            this.ShortcutLabel.Size = new System.Drawing.Size(112, 20);
            this.ShortcutLabel.TabIndex = 0;
            this.ShortcutLabel.Text = "Create shortcuts in:";
            this.ShortcutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShortcutDesktop
            // 
            this.ShortcutDesktop.AutoSize = true;
            this.ShortcutDesktop.Checked = true;
            this.ShortcutDesktop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShortcutDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShortcutDesktop.Location = new System.Drawing.Point(121, 3);
            this.ShortcutDesktop.Name = "ShortcutDesktop";
            this.ShortcutDesktop.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ShortcutDesktop.Size = new System.Drawing.Size(66, 20);
            this.ShortcutDesktop.TabIndex = 1;
            this.ShortcutDesktop.Text = "Desktop";
            this.ShortcutDesktop.UseVisualStyleBackColor = true;
            // 
            // DownloadSizeDisplay
            // 
            this.DownloadSizeDisplay.Location = new System.Drawing.Point(477, 85);
            this.DownloadSizeDisplay.Name = "DownloadSizeDisplay";
            this.DownloadSizeDisplay.Size = new System.Drawing.Size(105, 15);
            this.DownloadSizeDisplay.TabIndex = 8;
            this.DownloadSizeDisplay.Text = "0.0MB";
            // 
            // DownloadSizeLabel
            // 
            this.DownloadSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadSizeLabel.Location = new System.Drawing.Point(410, 85);
            this.DownloadSizeLabel.Name = "DownloadSizeLabel";
            this.DownloadSizeLabel.Size = new System.Drawing.Size(70, 15);
            this.DownloadSizeLabel.TabIndex = 7;
            this.DownloadSizeLabel.Text = "Total Size:";
            // 
            // DownloadMessage
            // 
            this.DownloadMessage.Location = new System.Drawing.Point(410, 14);
            this.DownloadMessage.Name = "DownloadMessage";
            this.DownloadMessage.Size = new System.Drawing.Size(172, 30);
            this.DownloadMessage.TabIndex = 6;
            this.DownloadMessage.Text = "Choose components to include in your Flashpoint download.";
            // 
            // ComponentList
            // 
            this.ComponentList.Indent = 20;
            this.ComponentList.Location = new System.Drawing.Point(16, 14);
            this.ComponentList.Name = "ComponentList";
            this.ComponentList.Size = new System.Drawing.Size(384, 176);
            this.ComponentList.TabIndex = 5;
            this.ComponentList.TriStateStyleProperty = RikTheVeggie.TriStateTreeView.TriStateStyles.Installer;
            this.ComponentList.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.ComponentList_BeforeCheck);
            this.ComponentList.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.ComponentList_AfterCheck);
            this.ComponentList.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.ComponentList_BeforeSelect);
            // 
            // UpdateTab
            // 
            this.UpdateTab.Controls.Add(this.ManagerMessage2);
            this.UpdateTab.Controls.Add(this.ManagerMessage);
            this.UpdateTab.Controls.Add(this.ManagerSizeDisplay);
            this.UpdateTab.Controls.Add(this.ManagerSizeLabel);
            this.UpdateTab.Controls.Add(this.UpdateButton);
            this.UpdateTab.Controls.Add(this.ChangeButton);
            this.UpdateTab.Controls.Add(this.FlashpointPathBox);
            this.UpdateTab.Controls.Add(this.DescriptionBox2);
            this.UpdateTab.Controls.Add(this.ComponentList2);
            this.UpdateTab.Location = new System.Drawing.Point(4, 24);
            this.UpdateTab.Name = "UpdateTab";
            this.UpdateTab.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateTab.Size = new System.Drawing.Size(592, 292);
            this.UpdateTab.TabIndex = 1;
            this.UpdateTab.Text = "Manage Components";
            this.UpdateTab.UseVisualStyleBackColor = true;
            // 
            // ManagerMessage2
            // 
            this.ManagerMessage2.Location = new System.Drawing.Point(410, 44);
            this.ManagerMessage2.Name = "ManagerMessage2";
            this.ManagerMessage2.Size = new System.Drawing.Size(172, 30);
            this.ManagerMessage2.TabIndex = 21;
            this.ManagerMessage2.Text = "Select your Flashpoint folder to manage components.";
            // 
            // ManagerMessage
            // 
            this.ManagerMessage.Location = new System.Drawing.Point(410, 14);
            this.ManagerMessage.Name = "ManagerMessage";
            this.ManagerMessage.Size = new System.Drawing.Size(172, 30);
            this.ManagerMessage.TabIndex = 20;
            this.ManagerMessage.Text = "Choose components to add or remove from your Flashpoint copy.";
            // 
            // ManagerSizeDisplay
            // 
            this.ManagerSizeDisplay.Location = new System.Drawing.Point(492, 85);
            this.ManagerSizeDisplay.Name = "ManagerSizeDisplay";
            this.ManagerSizeDisplay.Size = new System.Drawing.Size(90, 15);
            this.ManagerSizeDisplay.TabIndex = 19;
            this.ManagerSizeDisplay.Text = "0.0MB";
            this.ManagerSizeDisplay.Visible = false;
            // 
            // ManagerSizeLabel
            // 
            this.ManagerSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerSizeLabel.Location = new System.Drawing.Point(410, 85);
            this.ManagerSizeLabel.Name = "ManagerSizeLabel";
            this.ManagerSizeLabel.Size = new System.Drawing.Size(85, 15);
            this.ManagerSizeLabel.TabIndex = 18;
            this.ManagerSizeLabel.Text = "Size Change:";
            this.ManagerSizeLabel.Visible = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpdateButton.Location = new System.Drawing.Point(6, 256);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(284, 26);
            this.UpdateButton.TabIndex = 17;
            this.UpdateButton.Text = "Check for updates";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ChangeButton.Location = new System.Drawing.Point(300, 256);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(284, 26);
            this.ChangeButton.TabIndex = 16;
            this.ChangeButton.Text = "Apply changes";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ApplyChanges_Start);
            // 
            // FlashpointPathBox
            // 
            this.FlashpointPathBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FlashpointPathBox.Controls.Add(this.FlashpointPath);
            this.FlashpointPathBox.Controls.Add(this.FlashpointPathBrowse);
            this.FlashpointPathBox.Location = new System.Drawing.Point(7, 199);
            this.FlashpointPathBox.Name = "FlashpointPathBox";
            this.FlashpointPathBox.Size = new System.Drawing.Size(576, 49);
            this.FlashpointPathBox.TabIndex = 15;
            this.FlashpointPathBox.TabStop = false;
            this.FlashpointPathBox.Text = "Containing folder:";
            // 
            // FlashpointPath
            // 
            this.FlashpointPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlashpointPath.Location = new System.Drawing.Point(9, 18);
            this.FlashpointPath.Name = "FlashpointPath";
            this.FlashpointPath.Size = new System.Drawing.Size(477, 20);
            this.FlashpointPath.TabIndex = 1;
            // 
            // FlashpointPathBrowse
            // 
            this.FlashpointPathBrowse.Location = new System.Drawing.Point(495, 17);
            this.FlashpointPathBrowse.Name = "FlashpointPathBrowse";
            this.FlashpointPathBrowse.Size = new System.Drawing.Size(73, 22);
            this.FlashpointPathBrowse.TabIndex = 0;
            this.FlashpointPathBrowse.Text = "Browse";
            this.FlashpointPathBrowse.UseVisualStyleBackColor = true;
            this.FlashpointPathBrowse.Click += new System.EventHandler(this.FlashpointPathBrowse_Click);
            // 
            // DescriptionBox2
            // 
            this.DescriptionBox2.Controls.Add(this.Description2);
            this.DescriptionBox2.Location = new System.Drawing.Point(411, 116);
            this.DescriptionBox2.Name = "DescriptionBox2";
            this.DescriptionBox2.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.DescriptionBox2.Size = new System.Drawing.Size(163, 75);
            this.DescriptionBox2.TabIndex = 14;
            this.DescriptionBox2.TabStop = false;
            this.DescriptionBox2.Text = "Component Description";
            // 
            // Description2
            // 
            this.Description2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description2.Location = new System.Drawing.Point(10, 21);
            this.Description2.Name = "Description2";
            this.Description2.Size = new System.Drawing.Size(143, 44);
            this.Description2.TabIndex = 0;
            // 
            // ComponentList2
            // 
            this.ComponentList2.Enabled = false;
            this.ComponentList2.Indent = 20;
            this.ComponentList2.Location = new System.Drawing.Point(16, 14);
            this.ComponentList2.Name = "ComponentList2";
            this.ComponentList2.Size = new System.Drawing.Size(384, 176);
            this.ComponentList2.TabIndex = 13;
            this.ComponentList2.TriStateStyleProperty = RikTheVeggie.TriStateTreeView.TriStateStyles.Installer;
            // 
            // RemoveTab
            // 
            this.RemoveTab.Location = new System.Drawing.Point(4, 24);
            this.RemoveTab.Name = "RemoveTab";
            this.RemoveTab.Padding = new System.Windows.Forms.Padding(3);
            this.RemoveTab.Size = new System.Drawing.Size(592, 292);
            this.RemoveTab.TabIndex = 2;
            this.RemoveTab.Text = "Remove Flashpoint";
            this.RemoveTab.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 561);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flashpoint Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.DownloadPathBox.ResumeLayout(false);
            this.DownloadPathBox.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.DownloadTab.ResumeLayout(false);
            this.DescriptionBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.UpdateTab.ResumeLayout(false);
            this.FlashpointPathBox.ResumeLayout(false);
            this.FlashpointPathBox.PerformLayout();
            this.DescriptionBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label About;
        private System.Windows.Forms.GroupBox DownloadPathBox;
        public System.Windows.Forms.TextBox DownloadPath;
        private System.Windows.Forms.Button DownloadPathBrowse;
        private System.Windows.Forms.Button Install;
        private System.Windows.Forms.LinkLabel Link;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage DownloadTab;
        private System.Windows.Forms.TabPage UpdateTab;
        private System.Windows.Forms.Label DownloadSizeLabel;
        private System.Windows.Forms.Label DownloadMessage;
        public RikTheVeggie.TriStateTreeView ComponentList;
        private System.Windows.Forms.TabPage RemoveTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ShortcutLabel;
        public System.Windows.Forms.CheckBox ShortcutStartMenu;
        public System.Windows.Forms.CheckBox ShortcutDesktop;
        public RikTheVeggie.TriStateTreeView ComponentList2;
        private System.Windows.Forms.GroupBox DescriptionBox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label DownloadMessage2;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.GroupBox FlashpointPathBox;
        public System.Windows.Forms.TextBox FlashpointPath;
        private System.Windows.Forms.Button FlashpointPathBrowse;
        private System.Windows.Forms.GroupBox DescriptionBox2;
        private System.Windows.Forms.Label Description2;
        private System.Windows.Forms.Label ManagerSizeLabel;
        private System.Windows.Forms.Label ManagerMessage;
        private System.Windows.Forms.Label ManagerMessage2;
        public System.Windows.Forms.Label DownloadSizeDisplay;
        public System.Windows.Forms.Label ManagerSizeDisplay;
    }
}

