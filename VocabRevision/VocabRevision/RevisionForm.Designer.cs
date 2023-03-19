namespace VocabRevision
{
    partial class RevisionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevisionForm));
            this.labelWord = new System.Windows.Forms.Label();
            this.buttonChoiceForgot = new System.Windows.Forms.Button();
            this.buttonChoiceRemember = new System.Windows.Forms.Button();
            this.buttonNever = new System.Windows.Forms.Button();
            this.timerConfirm = new System.Windows.Forms.Timer(this.components);
            this.buttonSkip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWord
            // 
            this.labelWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWord.Location = new System.Drawing.Point(-8, 53);
            this.labelWord.Margin = new System.Windows.Forms.Padding(0);
            this.labelWord.MinimumSize = new System.Drawing.Size(350, 200);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(350, 200);
            this.labelWord.TabIndex = 1;
            this.labelWord.Text = "Word";
            this.labelWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonChoiceForgot
            // 
            this.buttonChoiceForgot.BackColor = System.Drawing.Color.IndianRed;
            this.buttonChoiceForgot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonChoiceForgot.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonChoiceForgot.FlatAppearance.BorderSize = 0;
            this.buttonChoiceForgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoiceForgot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonChoiceForgot.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonChoiceForgot.Location = new System.Drawing.Point(0, 389);
            this.buttonChoiceForgot.Name = "buttonChoiceForgot";
            this.buttonChoiceForgot.Size = new System.Drawing.Size(334, 106);
            this.buttonChoiceForgot.TabIndex = 2;
            this.buttonChoiceForgot.Text = "I\'d rather revise this";
            this.buttonChoiceForgot.UseVisualStyleBackColor = false;
            this.buttonChoiceForgot.Click += new System.EventHandler(this.buttonChoiceForgot_Click);
            // 
            // buttonChoiceRemember
            // 
            this.buttonChoiceRemember.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonChoiceRemember.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonChoiceRemember.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonChoiceRemember.FlatAppearance.BorderSize = 0;
            this.buttonChoiceRemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoiceRemember.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonChoiceRemember.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonChoiceRemember.Location = new System.Drawing.Point(0, 256);
            this.buttonChoiceRemember.Name = "buttonChoiceRemember";
            this.buttonChoiceRemember.Size = new System.Drawing.Size(334, 66);
            this.buttonChoiceRemember.TabIndex = 4;
            this.buttonChoiceRemember.Text = "I remember this well";
            this.buttonChoiceRemember.UseVisualStyleBackColor = false;
            this.buttonChoiceRemember.Click += new System.EventHandler(this.buttonChoiceRemember_Click);
            // 
            // buttonNever
            // 
            this.buttonNever.BackColor = System.Drawing.Color.Maroon;
            this.buttonNever.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNever.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonNever.FlatAppearance.BorderSize = 0;
            this.buttonNever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNever.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNever.ForeColor = System.Drawing.Color.Red;
            this.buttonNever.Location = new System.Drawing.Point(0, 0);
            this.buttonNever.Name = "buttonNever";
            this.buttonNever.Size = new System.Drawing.Size(334, 31);
            this.buttonNever.TabIndex = 5;
            this.buttonNever.Text = "Never show again";
            this.buttonNever.UseVisualStyleBackColor = false;
            this.buttonNever.Click += new System.EventHandler(this.buttonNever_Click);
            // 
            // timerConfirm
            // 
            this.timerConfirm.Interval = 3000;
            this.timerConfirm.Tick += new System.EventHandler(this.timerConfirm_Tick);
            // 
            // buttonSkip
            // 
            this.buttonSkip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSkip.FlatAppearance.BorderSize = 0;
            this.buttonSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSkip.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSkip.Location = new System.Drawing.Point(0, 322);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(334, 67);
            this.buttonSkip.TabIndex = 6;
            this.buttonSkip.Text = "Remind me later";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // RevisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 495);
            this.Controls.Add(this.buttonChoiceRemember);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.buttonChoiceForgot);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.buttonNever);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(313, 534);
            this.Name = "RevisionForm";
            this.Text = "Revise Vocabulary";
            this.Load += new System.EventHandler(this.RevisionForm_Load);
            this.Resize += new System.EventHandler(this.RevisionForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelWord;
        private Button buttonChoiceForgot;
        private Button buttonChoiceRemember;
        private Button buttonNever;
        private System.Windows.Forms.Timer timerConfirm;
        private Button buttonSkip;
    }
}