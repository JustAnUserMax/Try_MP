namespace Try_MP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюИгрушкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отАДоЯToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отЯДоАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЦенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКоличествуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.файлToolStripMenuItem, this.редактированиеToolStripMenuItem, this.сортировкаToolStripMenuItem, this.cохранитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 11;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.открытьToolStripMenuItem, this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.добавитьЗаписьToolStripMenuItem, this.редактироватьЗаписьToolStripMenuItem, this.удалитьЗаписьToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            this.добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            this.добавитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.добавитьЗаписьToolStripMenuItem.Text = "Добавить запись";
            this.добавитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаписьToolStripMenuItem_Click);
            // 
            // редактироватьЗаписьToolStripMenuItem
            // 
            this.редактироватьЗаписьToolStripMenuItem.Name = "редактироватьЗаписьToolStripMenuItem";
            this.редактироватьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.редактироватьЗаписьToolStripMenuItem.Text = "Редактировать запись";
            this.редактироватьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьЗаписьToolStripMenuItem_Click);
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            this.удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            this.удалитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.удалитьЗаписьToolStripMenuItem.Text = "Удалить запись";
            this.удалитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗаписьToolStripMenuItem_Click_1);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.поНазваниюИгрушкиToolStripMenuItem, this.поЦенеToolStripMenuItem, this.поКоличествуToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поНазваниюИгрушкиToolStripMenuItem
            // 
            this.поНазваниюИгрушкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.отАДоЯToolStripMenuItem, this.отЯДоАToolStripMenuItem});
            this.поНазваниюИгрушкиToolStripMenuItem.Name = "поНазваниюИгрушкиToolStripMenuItem";
            this.поНазваниюИгрушкиToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.поНазваниюИгрушкиToolStripMenuItem.Text = "По названию игрушки";
            // 
            // отАДоЯToolStripMenuItem
            // 
            this.отАДоЯToolStripMenuItem.Name = "отАДоЯToolStripMenuItem";
            this.отАДоЯToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.отАДоЯToolStripMenuItem.Text = "От А до Я";
            this.отАДоЯToolStripMenuItem.Click += new System.EventHandler(this.отАДоЯToolStripMenuItem_Click);
            // 
            // отЯДоАToolStripMenuItem
            // 
            this.отЯДоАToolStripMenuItem.Name = "отЯДоАToolStripMenuItem";
            this.отЯДоАToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.отЯДоАToolStripMenuItem.Text = "От Я до А";
            this.отЯДоАToolStripMenuItem.Click += new System.EventHandler(this.отЯДоАToolStripMenuItem_Click);
            // 
            // поЦенеToolStripMenuItem
            // 
            this.поЦенеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.поВозрастаниюToolStripMenuItem, this.поУбываниюToolStripMenuItem});
            this.поЦенеToolStripMenuItem.Name = "поЦенеToolStripMenuItem";
            this.поЦенеToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.поЦенеToolStripMenuItem.Text = "По цене";
            // 
            // поВозрастаниюToolStripMenuItem
            // 
            this.поВозрастаниюToolStripMenuItem.Name = "поВозрастаниюToolStripMenuItem";
            this.поВозрастаниюToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.поВозрастаниюToolStripMenuItem.Text = "По возрастанию";
            this.поВозрастаниюToolStripMenuItem.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem_Click);
            // 
            // поУбываниюToolStripMenuItem
            // 
            this.поУбываниюToolStripMenuItem.Name = "поУбываниюToolStripMenuItem";
            this.поУбываниюToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.поУбываниюToolStripMenuItem.Text = "По убыванию";
            this.поУбываниюToolStripMenuItem.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem_Click);
            // 
            // поКоличествуToolStripMenuItem
            // 
            this.поКоличествуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.поВозрастаниюToolStripMenuItem1, this.поУбываниюToolStripMenuItem1});
            this.поКоличествуToolStripMenuItem.Name = "поКоличествуToolStripMenuItem";
            this.поКоличествуToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.поКоличествуToolStripMenuItem.Text = "По количеству";
            // 
            // поВозрастаниюToolStripMenuItem1
            // 
            this.поВозрастаниюToolStripMenuItem1.Name = "поВозрастаниюToolStripMenuItem1";
            this.поВозрастаниюToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.поВозрастаниюToolStripMenuItem1.Text = "По возрастанию";
            this.поВозрастаниюToolStripMenuItem1.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem1_Click);
            // 
            // поУбываниюToolStripMenuItem1
            // 
            this.поУбываниюToolStripMenuItem1.Name = "поУбываниюToolStripMenuItem1";
            this.поУбываниюToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.поУбываниюToolStripMenuItem1.Text = "По убыванию";
            this.поУбываниюToolStripMenuItem1.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem1_Click);
            // 
            // cохранитьToolStripMenuItem
            // 
            this.cохранитьToolStripMenuItem.Name = "cохранитьToolStripMenuItem";
            this.cохранитьToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.cохранитьToolStripMenuItem.Text = "Cохранить";
            this.cохранитьToolStripMenuItem.Click += new System.EventHandler(this.cохранитьToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Стоимость";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 387);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(137, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "От";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 387);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(262, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "До";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(262, 387);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 61);
            this.button1.TabIndex = 18;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripLabel1, this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(547, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(33, 22);
            this.toolStripLabel1.Text = "Лист";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel|*xlsx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 445);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SourHeel";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem cохранитьToolStripMenuItem;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;

        private System.Windows.Forms.ToolStripLabel toolStripLabel1;

        private System.Windows.Forms.ToolStrip toolStrip1;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ToolStripMenuItem отАДоЯToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отЯДоАToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ToolStripMenuItem поЦенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКоличествуToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНазваниюИгрушкиToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьЗаписьToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.DataGridView dataGridView1;


        #endregion
    }
}