namespace Exam
{
    partial class Form1
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            выбратьФайлToolStripMenuItem = new ToolStripMenuItem();
            btnAdd = new Button();
            btnDell = new Button();
            btnDellAll = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(31, 77);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(142, 349);
            listBox1.TabIndex = 0;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(370, 77);
            listBox2.Name = "listBox2";
            listBox2.SelectionMode = SelectionMode.MultiSimple;
            listBox2.Size = new Size(137, 349);
            listBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 59);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 2;
            label1.Text = "Список блюд";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(370, 59);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 3;
            label2.Text = "Состав заказа";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выбратьФайлToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // выбратьФайлToolStripMenuItem
            // 
            выбратьФайлToolStripMenuItem.Name = "выбратьФайлToolStripMenuItem";
            выбратьФайлToolStripMenuItem.Size = new Size(153, 22);
            выбратьФайлToolStripMenuItem.Text = "Выбрать файл";
            выбратьФайлToolStripMenuItem.Click += выбратьФайлToolStripMenuItem_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(230, 77);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDell
            // 
            btnDell.Location = new Point(230, 167);
            btnDell.Name = "btnDell";
            btnDell.Size = new Size(92, 49);
            btnDell.TabIndex = 6;
            btnDell.Text = "Удалить выбранное";
            btnDell.UseVisualStyleBackColor = true;
            btnDell.Click += btnDell_Click;
            // 
            // btnDellAll
            // 
            btnDellAll.Location = new Point(230, 388);
            btnDellAll.Name = "btnDellAll";
            btnDellAll.Size = new Size(92, 38);
            btnDellAll.TabIndex = 7;
            btnDellAll.Text = "Очистить список";
            btnDellAll.UseVisualStyleBackColor = true;
            btnDellAll.Click += btnDellAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDellAll);
            Controls.Add(btnDell);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem выбратьФайлToolStripMenuItem;
        private Button btnAdd;
        private Button btnDell;
        private Button btnDellAll;
    }
}
