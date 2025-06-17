namespace Pract_Shop
{
    partial class Form2
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NameTovar = new System.Windows.Forms.TextBox();
            this.Tovars = new System.Windows.Forms.ListBox();
            this.AddTovar = new System.Windows.Forms.Button();
            this.Rez = new System.Windows.Forms.Label();
            this.TovarPrice = new System.Windows.Forms.NumericUpDown();
            this.TovarCount = new System.Windows.Forms.NumericUpDown();
            this.NameForSell = new System.Windows.Forms.TextBox();
            this.CountForSell = new System.Windows.Forms.NumericUpDown();
            this.SellTovar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Zad2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Zad3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TovarPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TovarCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountForSell)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTovar
            // 
            this.NameTovar.Location = new System.Drawing.Point(9, 46);
            this.NameTovar.Name = "NameTovar";
            this.NameTovar.Size = new System.Drawing.Size(108, 20);
            this.NameTovar.TabIndex = 0;
            // 
            // Tovars
            // 
            this.Tovars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tovars.FormattingEnabled = true;
            this.Tovars.Location = new System.Drawing.Point(3, 3);
            this.Tovars.Name = "Tovars";
            this.Tovars.Size = new System.Drawing.Size(582, 322);
            this.Tovars.TabIndex = 1;
            // 
            // AddTovar
            // 
            this.AddTovar.Location = new System.Drawing.Point(133, 93);
            this.AddTovar.Name = "AddTovar";
            this.AddTovar.Size = new System.Drawing.Size(108, 23);
            this.AddTovar.TabIndex = 2;
            this.AddTovar.Text = "добавить товар";
            this.AddTovar.UseVisualStyleBackColor = true;
            this.AddTovar.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Rez
            // 
            this.Rez.AutoSize = true;
            this.Rez.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Rez.Location = new System.Drawing.Point(339, 199);
            this.Rez.Name = "Rez";
            this.Rez.Size = new System.Drawing.Size(147, 22);
            this.Rez.TabIndex = 3;
            this.Rez.Text = "Прибыль: 0 руб.";
            // 
            // TovarPrice
            // 
            this.TovarPrice.Location = new System.Drawing.Point(133, 46);
            this.TovarPrice.Name = "TovarPrice";
            this.TovarPrice.Size = new System.Drawing.Size(108, 20);
            this.TovarPrice.TabIndex = 4;
            // 
            // TovarCount
            // 
            this.TovarCount.Location = new System.Drawing.Point(265, 47);
            this.TovarCount.Name = "TovarCount";
            this.TovarCount.Size = new System.Drawing.Size(107, 20);
            this.TovarCount.TabIndex = 5;
            // 
            // NameForSell
            // 
            this.NameForSell.Location = new System.Drawing.Point(3, 43);
            this.NameForSell.Name = "NameForSell";
            this.NameForSell.Size = new System.Drawing.Size(100, 20);
            this.NameForSell.TabIndex = 6;
            // 
            // CountForSell
            // 
            this.CountForSell.Location = new System.Drawing.Point(125, 43);
            this.CountForSell.Name = "CountForSell";
            this.CountForSell.Size = new System.Drawing.Size(99, 20);
            this.CountForSell.TabIndex = 7;
            // 
            // SellTovar
            // 
            this.SellTovar.Location = new System.Drawing.Point(55, 80);
            this.SellTovar.Name = "SellTovar";
            this.SellTovar.Size = new System.Drawing.Size(99, 23);
            this.SellTovar.TabIndex = 8;
            this.SellTovar.Text = "продать";
            this.SellTovar.UseVisualStyleBackColor = true;
            this.SellTovar.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NameTovar);
            this.groupBox1.Controls.Add(this.AddTovar);
            this.groupBox1.Controls.Add(this.TovarPrice);
            this.groupBox1.Controls.Add(this.TovarCount);
            this.groupBox1.Location = new System.Drawing.Point(36, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 129);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить товар";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "количество";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NameForSell);
            this.groupBox2.Controls.Add(this.CountForSell);
            this.groupBox2.Controls.Add(this.SellTovar);
            this.groupBox2.Location = new System.Drawing.Point(45, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 146);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Продажа товара";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Название";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 354);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.Rez);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(588, 328);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Менеджмент";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label6.Location = new System.Drawing.Point(307, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Tovars);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(588, 328);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "список товаров";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Zad2,
            this.Zad3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(81, 48);
            // 
            // Zad2
            // 
            this.Zad2.Name = "Zad2";
            this.Zad2.Size = new System.Drawing.Size(80, 22);
            this.Zad2.Text = "2";
            // 
            // Zad3
            // 
            this.Zad3.Name = "Zad3";
            this.Zad3.Size = new System.Drawing.Size(80, 22);
            this.Zad3.Text = "3";
            this.Zad3.Click += new System.EventHandler(this.Zad3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 354);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Магазинчик\\";
            ((System.ComponentModel.ISupportInitialize)(this.TovarPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TovarCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountForSell)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameTovar;
        private System.Windows.Forms.ListBox Tovars;
        private System.Windows.Forms.Button AddTovar;
        private System.Windows.Forms.Label Rez;
        private System.Windows.Forms.NumericUpDown TovarPrice;
        private System.Windows.Forms.NumericUpDown TovarCount;
        private System.Windows.Forms.TextBox NameForSell;
        private System.Windows.Forms.NumericUpDown CountForSell;
        private System.Windows.Forms.Button SellTovar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Zad2;
        private System.Windows.Forms.ToolStripMenuItem Zad3;
    }
}

