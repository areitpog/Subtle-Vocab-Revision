namespace VocabRevision
{
    partial class AddVocabForm
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
            this.textBoxEntry = new System.Windows.Forms.TextBox();
            this.buttonDefGoogle = new System.Windows.Forms.Button();
            this.buttonDefCollins = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonShuffle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEntry
            // 
            this.textBoxEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxEntry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEntry.Location = new System.Drawing.Point(0, 0);
            this.textBoxEntry.Name = "textBoxEntry";
            this.textBoxEntry.PlaceholderText = "Entry...";
            this.textBoxEntry.Size = new System.Drawing.Size(268, 35);
            this.textBoxEntry.TabIndex = 0;
            this.textBoxEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEntry_KeyPress);
            // 
            // buttonDefGoogle
            // 
            this.buttonDefGoogle.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonDefGoogle.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDefGoogle.FlatAppearance.BorderSize = 0;
            this.buttonDefGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefGoogle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDefGoogle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDefGoogle.Location = new System.Drawing.Point(0, 92);
            this.buttonDefGoogle.Name = "buttonDefGoogle";
            this.buttonDefGoogle.Size = new System.Drawing.Size(268, 57);
            this.buttonDefGoogle.TabIndex = 2;
            this.buttonDefGoogle.Text = "Define via Google";
            this.buttonDefGoogle.UseVisualStyleBackColor = false;
            this.buttonDefGoogle.Click += new System.EventHandler(this.buttonDefGoogle_Click);
            // 
            // buttonDefCollins
            // 
            this.buttonDefCollins.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDefCollins.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDefCollins.FlatAppearance.BorderSize = 0;
            this.buttonDefCollins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefCollins.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDefCollins.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDefCollins.Location = new System.Drawing.Point(0, 35);
            this.buttonDefCollins.Name = "buttonDefCollins";
            this.buttonDefCollins.Size = new System.Drawing.Size(268, 57);
            this.buttonDefCollins.TabIndex = 1;
            this.buttonDefCollins.Text = "Define via Collins";
            this.buttonDefCollins.UseVisualStyleBackColor = false;
            this.buttonDefCollins.Click += new System.EventHandler(this.buttonDefCollins_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.LightGray;
            this.buttonConfirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonConfirm.FlatAppearance.BorderSize = 0;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonConfirm.Location = new System.Drawing.Point(0, 263);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(268, 126);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.BackColor = System.Drawing.Color.Silver;
            this.buttonShuffle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonShuffle.FlatAppearance.BorderSize = 0;
            this.buttonShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShuffle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonShuffle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonShuffle.Location = new System.Drawing.Point(0, 222);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.Size = new System.Drawing.Size(268, 41);
            this.buttonShuffle.TabIndex = 4;
            this.buttonShuffle.Text = "Shuffle";
            this.buttonShuffle.UseVisualStyleBackColor = false;
            this.buttonShuffle.Click += new System.EventHandler(this.buttonShuffle_Click);
            // 
            // AddVocabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 389);
            this.Controls.Add(this.buttonShuffle);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonDefGoogle);
            this.Controls.Add(this.buttonDefCollins);
            this.Controls.Add(this.textBoxEntry);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(284, 428);
            this.Name = "AddVocabForm";
            this.Text = "Add Vocabulary...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxEntry;
        private Button buttonDefGoogle;
        private Button buttonDefCollins;
        private Button buttonConfirm;
        private Button buttonShuffle;
    }
}