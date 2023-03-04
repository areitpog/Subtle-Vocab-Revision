using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Diagnostics;
using Microsoft.Win32;

namespace VocabRevision
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon.BalloonTipTitle = "Revise!";
            notifyIcon.BalloonTipText = "Do you remember what <> means?";
            notifyIcon.Visible = true;

            notifyIcon.ShowBalloonTip(10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Process.Start(new ProcessStartInfo
            //{
            //    FileName = "https://www.google.com/search?q=define:test",
            //    UseShellExecute = true
            //});
        }


        #region Handle Notifications
        private void notifyIcon_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            ShowRevForm();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                ShowAddForm();
            else if (e.Button == MouseButtons.Middle)
                ShowRevForm();
        }

        private void toolStripMenuItemRevise_Click(object sender, EventArgs e)
        {
            ShowRevForm();
        }

        private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            ShowAddForm();
        }


        void ShowRevForm()
        {
            RevisionForm revForm = new RevisionForm();

            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == revForm.Name)
                {
                    // Form is open; bring to front

                    frm.WindowState = FormWindowState.Normal;
                    frm.Activate();
                    return;
                }
            }

            revForm.Show();
            revForm.Activate();
        }
        void ShowAddForm()
        {
            AddVocabForm addForm = new AddVocabForm();

            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == addForm.Name)
                {
                    // Form is open; bring to front

                    frm.WindowState = FormWindowState.Normal;
                    frm.Activate();
                    return;
                }
            }

            addForm.Show();
            addForm.Activate();
        }
        #endregion

        void HideMain(bool showAnimation = false)
        {
            if (!showAnimation)
                Opacity = 0;

            ShowInTaskbar = false;
            Hide();

            Opacity = 1;
        }
        void ShowMain()
        {
            ShowInTaskbar = true;
            Show();

            WindowState = FormWindowState.Normal;
            Activate();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // if the file exists, then everything is probably set up; hide form
            if (File.Exists(GetDbFile()))
            {
                HideMain();
            }
        }

        const string APP_NAME = "AreitVocabRevision";
        private void buttonSetup_Click(object sender, EventArgs e)
        {
            string file = GetDbFile();

            if (!File.Exists(file))
                File.Create(file).Close();

            // Add to startup
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)!;

            rk.SetValue(APP_NAME, Application.ExecutablePath);

            MessageBox.Show("Setup complete :)", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Environment.SpecialFolder.Startup;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Remove from startup
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true)!;

            rk.DeleteValue(APP_NAME, false);

            MessageBox.Show("Removed from startup :)", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMain();
        }

        public static string GetDbFile()
        {
            string folder = Path.GetDirectoryName(Application.ExecutablePath)! + "/";
            string file = folder + "data.txt";

            return file;
        }

        private void confirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App has been closed. You will not receive reminders and will not have the small icon until you run it again.", "Closed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            HideMain(true);
            e.Cancel = true;
        }


        private void timerNotification_Tick(object sender, EventArgs e)
        {
            string file = Main.GetDbFile();
            if (!File.Exists(file))
            {
                return;
            }

            string[] lines = File.ReadAllLines(file);

            if (lines.Length < 1)
            {
                return;
            }

            notifyIcon.BalloonTipTitle = "Revise!";
            notifyIcon.BalloonTipText = $"Do you remember what \"{lines[0]}\" is?";

            notifyIcon.ShowBalloonTip(10);
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Path.GetDirectoryName(Main.GetDbFile()));
        }
    }
}





//WindowState = FormWindowState.Normal;
//this.Focus();
//this.BringToFront();
// The part above is basically useless but I want to keep it lol.
