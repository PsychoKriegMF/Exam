using System.ComponentModel;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выбрать‘айлToolStripMenuItem_Click(object sender, EventArgs e)
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
                        MessageBox.Show($"ќшибка загрузки файла: {ex.Message}");
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

        }
    }
}
