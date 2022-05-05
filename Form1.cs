using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using Excel = Microsoft.Office.Interop.Excel;

namespace Try_MP
{
    public partial class Form1 : Form
    {
        private string fileName = string.Empty;
        private DataTableCollection _tableCollection = null;
        
        private void Form1_Load()
        {
            /*var column1 = new DataGridViewColumn();
            column1.HeaderText = "Название"; //текст в шапке
            column1.Width = 100; //ширина колонки
            column1.ReadOnly = true; //значение в этой колонке нельзя править
            column1.Name = "name"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Цена"; 
            column2.Name = "price";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Остаток";
            column3.Name = "count";
            column3.CellTemplate = new DataGridViewTextBoxCell();
            
            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Категория";
            column4.Name = "category";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);*/

            dataGridView1.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки
            //dataGridView1.Rows.Add( " Товар ", 1000, 1, "От 5 до 7");
            //dataGridView1.Rows.Add( " Hовар ", 10, 1, "От 5 до 7");
            //dataGridView1.Rows.Add( " Aовар ", 100, 5, "От 4 до 6");
        }
        
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }
        void MyDelegateAdd(object o1, object o2, object o3, object o4, object o5)
        {
            ((DataTable)dataGridView1.DataSource).Rows.Add(o1, o2, o3, "От "+o4+" до "+o5);
        }
        void MyDelegateDelete(string s)
        {
            int index = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(s))
                    {
                        index = i;
                        break;
                    }
            }
            ((DataTable)dataGridView1.DataSource).Rows.RemoveAt(index);
        }
        void MyDelegateEdit(object o1, object o2)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                //for (int j = 0; j < dataGridView1.ColumnCount; j++)
                if (dataGridView1.Rows[i].Cells[3].Value.ToString().Contains(o1.ToString()))
                {
                    object[] data = new object[4];
                    data[0] = dataGridView1.Rows[i].Cells[0].Value;
                    data[1] = double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) *
                              (1 + double.Parse(o2.ToString()) / 100);
                    data[2] = dataGridView1.Rows[i].Cells[2].Value;
                    data[3] = dataGridView1.Rows[i].Cells[3].Value;
                    ((DataTable) dataGridView1.DataSource).Rows[i].ItemArray = data;
                }
            }
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                    Text = fileName;
                    OpenExcelFile(fileName);
                }
                else
                {
                    throw new System.Exception("Файл не выбран!");
                }
            }
            catch (System.Exception exception)
            {
                Exception _exception = new Exception();
                _exception.Show();
            }
        }

        private void OpenExcelFile(string path)
        {
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);
            DataSet dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (x)=> new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });

            _tableCollection = dataSet.Tables;
            toolStripComboBox1.Items.Clear();
            foreach (DataTable table in _tableCollection)
            {
                toolStripComboBox1.Items.Add(table.TableName);
            }

            toolStripComboBox1.SelectedIndex = 0;
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
            addForm.MyDelegateEventAdd += MyDelegateAdd;
        }

        private void удалитьЗаписьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
            deleteForm.MyDelegateEventDelete += MyDelegateDelete;
        }

        private void редактироватьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.Show();
            editForm.MyDelegateEventEdit += MyDelegateEdit;
        }

        private void отАДоЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0],0);
        }

        private void отЯДоАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0],(ListSortDirection) 1);
        }

        private void поВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1],0);
        }

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1],(ListSortDirection) 1);
        }

        private void поВозрастаниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2],0);
        }

        private void поУбываниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[2],(ListSortDirection) 1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (!dataGridView1.Rows[i].Cells[3].Value.ToString()
                        .Contains("От " + textBox2.Text + " до " + textBox3.Text) &&
                    double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) >
                    double.Parse(textBox1.Text))
                    {
                        dataGridView1.Rows[i].Visible = false;
                    }
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = _tableCollection[Convert.ToString(toolStripComboBox1.SelectedItem)];
            dataGridView1.DataSource = table;
        }

        private void cохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Excel.Application exApp = new Excel.Application();
            
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i=0;i<dataGridView1.RowCount;i++)
            {
                for (j=0;j<dataGridView1.ColumnCount;j++)
                {
                    wsh.Cells[i+1, j+1] = dataGridView1[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;*/
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelApp.Cells[1, 1] = "Название";
            ExcelApp.Cells[1, 2] = "Цена";
            ExcelApp.Cells[1, 3] = "Остаток";
            ExcelApp.Cells[1, 4] = "Категория";
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            /*//Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;*/
            ExcelApp.AlertBeforeOverwriting = false;
            ExcelWorkBook.SaveAs(@"E:\Моя папка\Creative\RiderProject\Try MP\Таблица.xlsx");
            ExcelApp.Quit();
        }
    }
}