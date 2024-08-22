using System.ComponentModel;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ‚˚·‡Ú¸‘‡ÈÎToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] dishes = File.ReadAllLines(openFileDialog.FileName);
                        listBox1.Items.Clear();
                        listBox1.Items.AddRange(dishes);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Œ¯Ë·Í‡ Á‡„ÛÁÍË Ù‡ÈÎ‡: {ex.Message}");
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
            }
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Remove(listBox2.SelectedItems[i]);
            }
        }

        private void btnDellAll_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
            }
        }

        private void btnSumm_Click(object sender, EventArgs e)
        {
            if (listBox2 == null)
                throw new ArgumentNullException(nameof(listBox2));
            int sum = 0;

            foreach (var item in listBox2.Items)
            {               
                string[] parts = item.ToString().Split(' ');
                
                if (parts.Length >= 2 && int.TryParse(parts.Last(), out int number))
                {
                    sum += number;
                }
            }

            textBox1.Text = sum.ToString();
        }
    }
}
