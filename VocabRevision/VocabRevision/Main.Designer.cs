namespace VocabRevision
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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotification = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemRevise = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.openSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSetup = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timerNotification = new System.Windows.Forms.Timer(this.components);
            this.buttonFolder = new System.Windows.Forms.Button();
            this.contextMenuStripNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Do you still remember?";
            this.notifyIcon.BalloonTipTitle = "Revise!";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripNotification;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Revise Vocabulary";
            this.notifyIcon.Visible = true;
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStripNotification
            // 
            this.contextMenuStripNotification.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRevise,
            this.toolStripMenuItemAdd,
            this.openSetupToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStripNotification.Name = "contextMenuStripNotification";
            this.contextMenuStripNotification.Size = new System.Drawing.Size(169, 92);
            // 
            // toolStripMenuItemRevise
            // 
            this.toolStripMenuItemRevise.Image = global::VocabRevision.Properties.Resources.rew;
            this.toolStripMenuItemRevise.Name = "toolStripMenuItemRevise";
            this.toolStripMenuItemRevise.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItemRevise.Text = "Revise Vocabulary";
            this.toolStripMenuItemRevise.Click += new System.EventHandler(this.toolStripMenuItemRevise_Click);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Image = global::VocabRevision.Properties.Resources.plus;
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItemAdd.Text = "Add Vocabulary";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.toolStripMenuItemAdd_Click);
            // 
            // openSetupToolStripMenuItem
            // 
            this.openSetupToolStripMenuItem.Name = "openSetupToolStripMenuItem";
            this.openSetupToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openSetupToolStripMenuItem.Text = "Open setup...";
            this.openSetupToolStripMenuItem.Click += new System.EventHandler(this.openSetupToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confirmToolStripMenuItem});
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // confirmToolStripMenuItem
            // 
            this.confirmToolStripMenuItem.Name = "confirmToolStripMenuItem";
            this.confirmToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.confirmToolStripMenuItem.Text = "Confirm";
            this.confirmToolStripMenuItem.Click += new System.EventHandler(this.confirmToolStripMenuItem_Click);
            // 
            // buttonSetup
            // 
            this.buttonSetup.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonSetup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSetup.FlatAppearance.BorderSize = 0;
            this.buttonSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetup.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSetup.Location = new System.Drawing.Point(0, 217);
            this.buttonSetup.Name = "buttonSetup";
            this.buttonSetup.Size = new System.Drawing.Size(558, 129);
            this.buttonSetup.TabIndex = 3;
            this.buttonSetup.Text = "Setup";
            this.buttonSetup.UseVisualStyleBackColor = false;
            this.buttonSetup.Click += new System.EventHandler(this.buttonSetup_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonRemove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonRemove.Location = new System.Drawing.Point(0, 171);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(558, 46);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(205, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 65);
            this.label1.TabIndex = 5;
            this.label1.Text = "Setup";
            // 
            // timerNotification
            // 
            this.timerNotification.Enabled = true;
            this.timerNotification.Interval = 1800000;
            this.timerNotification.Tick += new System.EventHandler(this.timerNotification_Tick);
            // 
            // buttonFolder
            // 
            this.buttonFolder.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonFolder.FlatAppearance.BorderSize = 0;
            this.buttonFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFolder.ForeColor = System.Drawing.Color.SaddleBrown;
            this.buttonFolder.Location = new System.Drawing.Point(12, 12);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(154, 38);
            this.buttonFolder.TabIndex = 6;
            this.buttonFolder.Text = "Open folder...";
            this.buttonFolder.UseVisualStyleBackColor = false;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 346);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonSetup);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Memorize Vocabulary -- Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.contextMenuStripNotification.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStripNotification;
        private ToolStripMenuItem toolStripMenuItemRevise;
        private ToolStripMenuItem toolStripMenuItemAdd;
        private Button buttonSetup;
        private Button buttonRemove;
        private ToolStripMenuItem openSetupToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem confirmToolStripMenuItem;
        private Label label1;
        private System.Windows.Forms.Timer timerNotification;
        private Button buttonFolder;
    }
}