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

        private void выбратьФайлToolStripMenuItem_Click(object sender, EventArgs e)
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
                        MessageBox.Show($"Ошибка загрузки файла: {ex.Message}");
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dictionary<string, ListItem> itemDict = new Dictionary<string, ListItem>();            

            // Пройтись по элементам целевого ListBox и заполнить словарь
            foreach (var item in listBox2.Items)
            {
                if (item is ListItem listItem)
                {
                    itemDict[listItem.Name] = listItem;
                }
            }

            // Пройтись по исходному ListBox и добавлять элементы в словарь
            foreach (var selectedItem in listBox1.SelectedItems)
            {
                string itemName = selectedItem.ToString();

                if (itemDict.ContainsKey(itemName))
                {
                    // Увеличиваем количество, если элемент уже есть в словаре
                    itemDict[itemName].Count++;
                }
                else
                {
                    // Добавляем новый элемент в словарь
                    itemDict[itemName] = new ListItem { Name = itemName, Count = 1 };
                }
            }


            // Очистить целевой ListBox и заполнить его обновлёнными элементами из словаря
            listBox2.Items.Clear();
            foreach (var listItem in itemDict.Values)
            {
                listBox2.Items.Add(listItem);
            }
            //for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            //{
            //    listBox2.Items.Add(listBox1.SelectedItems[i]);
            //}
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

        private void btnDell_Click(object sender, EventArgs e)
        {
            Dictionary<string, ListItem> itemDict = new Dictionary<string, ListItem>();
            foreach (var item in listBox2.Items)
            {
                if (item is ListItem listItem)
                {
                    itemDict[listItem.Name] = listItem;
                }
            }

            // Пройтись по выделенным элементам целевого ListBox и уменьшить количество или удалить элемент
            foreach (var selectedItem in listBox2.SelectedItems.Cast<ListItem>().ToList())
            {
                string itemName = selectedItem.Name;

                if (itemDict.ContainsKey(itemName))
                {
                    if (itemDict[itemName].Count > 1)
                    {
                        // Уменьшаем количество
                        itemDict[itemName].Count--;
                    }
                    else
                    {
                        // Удаляем элемент из словаря
                        itemDict.Remove(itemName);
                    }
                }
            }

            // Очистить целевой ListBox и заполнить его обновлёнными элементами из словаря
            listBox2.Items.Clear();
            foreach (var listItem in itemDict.Values)
            {
                listBox2.Items.Add(listItem);
            }
            //for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--)
            //{
            //    listBox2.Items.Remove(listBox2.SelectedItems[i]);
            //}
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

        private void btnDellAll_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
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

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
            }
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

        //private void btnSumm_Click(object sender, EventArgs e)
        //{
        //    if (listBox2 == null)
        //        throw new ArgumentNullException(nameof(listBox2));
        //    int sum = 0;

        //    foreach (var item in listBox2.Items)
        //    {               
        //        string[] parts = item.ToString().Split(' ');
                
        //        if (parts.Length >= 2 && int.TryParse(parts.Last(), out int number))
        //        {
        //            sum += number;
        //        }
        //    }

        //    textBox1.Text = sum.ToString();
        //}
    }
}
