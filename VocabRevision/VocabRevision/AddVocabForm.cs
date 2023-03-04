using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VocabRevision
{
    public partial class AddVocabForm : Form
    {
        public AddVocabForm()
        {
            InitializeComponent();
        }

        private void buttonDefCollins_Click(object sender, EventArgs e)
        {
            if (!SanitizeEntryBox())
                return;

            Process.Start(new ProcessStartInfo
            {
                FileName = $"https://www.collinsdictionary.com/dictionary/english/{textBoxEntry.Text}",
                UseShellExecute = true
            });
        }

        private void buttonDefGoogle_Click(object sender, EventArgs e)
        {
            Google();
        }
        void Google()
        {
            if (!SanitizeEntryBox())
                return;

            Process.Start(new ProcessStartInfo
            {
                FileName = $"https://www.google.com/search?q=define:{textBoxEntry.Text}",
                UseShellExecute = true
            });
        }

        bool SanitizeEntryBox()
        {
            string forbiddenCharacters = ",.?/\\*";

            foreach (char c in forbiddenCharacters)
            {
                if (textBoxEntry.Text.Contains(c))
                {
                    MessageBox.Show($"Entry cannot contain {forbiddenCharacters}", "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Confirm();
        }

        private void textBoxEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '?' || e.KeyChar == '/')
            {
                e.Handled = true;

                Google();
                return;
            }

            if (e.KeyChar != Convert.ToChar(Keys.Return))
                return;

            Confirm();
        }

        void Confirm()
        {
            string entry = textBoxEntry.Text.ToUpper();
            if (entry == "")
            {
                MessageBox.Show("Entry cannot be empty", "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string file = Main.GetDbFile();
            if (!File.Exists(file))
            {
                MessageBox.Show("There is no file with the words. Have you done the setup?", "Huh?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            List<string> lines = File.ReadAllLines(file).ToList();
            foreach (string line in lines)
            {
                if (line.ToUpper() == entry)
                {
                    MessageBox.Show($"Entry \"{entry}\" already exists!", "Duplicate prevention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            lines.Insert(0, entry);
            File.WriteAllLines(file, lines);

            MessageBox.Show($"Entry \"{entry}\" added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxEntry.Text = "";
        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to shuffle the wordlist?", "Shuffle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
                return;

            string file = Main.GetDbFile();
            if (!File.Exists(file))
            {
                MessageBox.Show("There is no file with the words. Have you done the setup?", "Huh?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            List<string> lines = File.ReadAllLines(file).ToList();

            if (lines.Count < 1)
            {
                MessageBox.Show("It appears you haven't added anything you want to revise. Add some vocab :)", "No vocab", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            lines.Shuffle();
            File.WriteAllLines(file, lines);

            MessageBox.Show("Shuffled!", "Shuffle", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


    // https://stackoverflow.com/questions/273313/randomize-a-listt
    public static class Extensions
    {
        private static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
