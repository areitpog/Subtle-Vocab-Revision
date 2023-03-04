using System.Diagnostics;

namespace VocabRevision
{
    // <a href="https://www.flaticon.com/free-icons/book" title="book icons">Book icons created by Good Ware - Flaticon</a>
    public partial class RevisionForm : Form
    {
        List<string> lines = new List<string>();
        public RevisionForm()
        {
            InitializeComponent();
        }

        private void RevisionForm_Load(object sender, EventArgs e)
        {
            string file = Main.GetDbFile();
            if (!File.Exists(file))
            {
                MessageBox.Show("There is no file with the words. Have you done the setup?", "Huh?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            lines = File.ReadAllLines(file).ToList();

            if (lines.Count < 1)
            {
                MessageBox.Show("It appears you haven't added anything you want to revise. Select \"Add Vocabulary\" and add something :)", "No vocab", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            SelectNewVocabItem();
            UpdateLabelSize();
        }

        void SelectNewVocabItem()
        {
            if (lines.Count < 1)
            {
                MessageBox.Show("It appears you have run out of things to revise. Select \"Add Vocabulary\" and add something :)", "No vocab", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            labelWord.Text = lines[0];
        }


        private void buttonChoiceRemember_Click(object sender, EventArgs e)
        {
            int amount = new Random().Next(16, lines.Count);
            ShiftWord(amount);

            SelectNewVocabItem();
        }

        private void buttonChoiceForgot_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = $"https://www.google.com/search?q=define:{lines[0]}",
                UseShellExecute = true
            });

            int amount = new Random().Next(4, 16);
            ShiftWord(amount);

            SelectNewVocabItem();
        }

        void ShiftWord(int amount)
        {
            string currentWord = lines[0];

            if (amount >= lines.Count - 2)
                lines.Add(currentWord);
            else
                lines.Insert(amount + 1, currentWord);
            lines.RemoveAt(0);


            File.WriteAllLines(Main.GetDbFile(), lines);
        }


        const string NEVER_DEFAULT_TXT = "Never show again";
        const string NEVER_CONFIRM_TXT = "Click again to confirm";
        private void timerConfirm_Tick(object sender, EventArgs e)
        {
            buttonNever.Text = NEVER_DEFAULT_TXT;
            timerConfirm.Stop();
        }

        private void buttonNever_Click(object sender, EventArgs e)
        {
            if (timerConfirm.Enabled)
            {
                buttonNever.Text = NEVER_DEFAULT_TXT;
                timerConfirm.Stop();

                lines.RemoveAt(0);
                File.WriteAllLines(Main.GetDbFile(), lines);

                SelectNewVocabItem();

                return;
            }

            buttonNever.Text = NEVER_CONFIRM_TXT;
            timerConfirm.Start();
        }

        private void RevisionForm_Resize(object sender, EventArgs e)
        {
            UpdateLabelSize();
        }

        void UpdateLabelSize()
        {
            Size newSize = this.Size;
            newSize.Height = 200;

            labelWord.MinimumSize = newSize;
            labelWord.MaximumSize = newSize;
            labelWord.Size = newSize;

            labelWord.Location = new Point(-6, 53);
        }
    }
}