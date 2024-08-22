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

            foreach (var item in listBox2.Items)
            {
                if (item is ListItem listItem)
                {
                    itemDict[listItem.Name] = listItem;
                }
            }

            foreach (var selectedItem in listBox1.SelectedItems)
            {
                string itemName = selectedItem.ToString();

                string[] parts = itemName.Split(' ');
                if (parts.Length >= 2 && int.TryParse(parts.Last(), out int cost))
                {
                    string name = string.Join(" ", parts.Take(parts.Length - 1)); // Имя без стоимости

                    if (itemDict.ContainsKey(name))
                    {
                        // Увеличиваем количество, если элемент уже есть в словаре
                        itemDict[name].Count++;
                        itemDict[name].Cost += cost; // Увеличиваем общую стоимость
                    }
                    else
                    {
                        // Добавляем новый элемент в словарь
                        itemDict[name] = new ListItem { Name = name, Count = 1, Cost = cost };
                    }
                }
            }
            //Очищаем список и заполняем заново
            listBox2.Items.Clear();
            foreach (var listItem in itemDict.Values)
            {
                listBox2.Items.Add(listItem);
            }

            if (listBox2 == null)
                throw new ArgumentNullException(nameof(listBox2));

            int sum = 0;
            //Считаем общую сумму
            foreach (var item in listBox2.Items)
            {
                if (item is ListItem listItem)
                {
                    sum += listItem.Cost;
                }
            }
            // Обновить текстовое поле суммой
            textBox1.Text = sum.ToString();            
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null && listBox2.SelectedItem is ListItem selectedItem)
            {
                string itemName = selectedItem.Name;

                Dictionary<string, ListItem> itemDict = new Dictionary<string, ListItem>();

                foreach (var item in listBox2.Items)
                {
                    if (item is ListItem listItem)
                    {
                        itemDict[listItem.Name] = listItem;
                    }
                }

                if (itemDict.ContainsKey(itemName))
                {
                    int costPerItem = selectedItem.Cost / selectedItem.Count; 

                    if (itemDict[itemName].Count > 1)
                    {                        
                        itemDict[itemName].Count--;
                        itemDict[itemName].Cost -= costPerItem; 
                    }
                    else
                    {                        
                        itemDict.Remove(itemName);
                    }

                    listBox2.Items.Clear();
                    foreach (var listItem in itemDict.Values)
                    {
                        listBox2.Items.Add(listItem);
                    }

                    int sum = 0;
                    foreach (var item in listBox2.Items)
                    {
                        if (item is ListItem listItem)
                        {
                            sum += listItem.Cost;
                        }
                    }

                    textBox1.Text = sum.ToString();
                }
            }
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
            Dictionary<string, ListItem> itemDict = new Dictionary<string, ListItem>();

            foreach (var item in listBox2.Items)
            {
                if (item is ListItem listItem)
                {
                    itemDict[listItem.Name] = listItem;
                }
            }

            foreach (var selectedItem in listBox1.SelectedItems)
            {
                string itemName = selectedItem.ToString();

                string[] parts = itemName.Split(' ');
                if (parts.Length >= 2 && int.TryParse(parts.Last(), out int cost))
                {
                    string name = string.Join(" ", parts.Take(parts.Length - 1)); 

                    if (itemDict.ContainsKey(name))
                    {                        
                        itemDict[name].Count++;
                        itemDict[name].Cost += cost; 
                    }
                    else
                    {
                        itemDict[name] = new ListItem { Name = name, Count = 1, Cost = cost };
                    }
                }
            }

            listBox2.Items.Clear();
            foreach (var listItem in itemDict.Values)
            {
                listBox2.Items.Add(listItem);
            }

            if (listBox2 == null)
                throw new ArgumentNullException(nameof(listBox2));

            int sum = 0;
                        
            foreach (var item in listBox2.Items)
            {
                if (item is ListItem listItem)
                {
                    sum += listItem.Cost;
                }
            }           
            textBox1.Text = sum.ToString();
        }       
    }
}
