using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.Office.Interop.Excel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPR
{
    public partial class Database : Form
    {
        public Database(string path_name,string password)
        {
            InitializeComponent();
            Data_base_name = path_name;
            pass = password;
        }
        public void UpdateData()
        {
            dataSet11.Справки.Clear();
            oleDbDataAdapter1.Fill(dataSet11.Справки);
        }
        string Data_base_name;
        string pass;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Database_Load(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            bool abc = fr.ret();
                oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Data_base_name + ";Jet OLEDB:Database Password =" + pass;
                oleDbConnection1.Open();
                oleDbDataAdapter1.SelectCommand.Connection.ConnectionString = oleDbConnection1.ConnectionString;
                oleDbDataAdapter1.Update(dataSet11.Справки);
                oleDbDataAdapter1.Fill(dataSet11.Справки);
                dataGridView1.DataSource = dataSet11.Справки;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int data_head;
        private void button1_Click(object sender, EventArgs e)
        {
            insp fr = new insp(oleDbConnection1.ConnectionString);
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            spadd fr = new spadd(oleDbConnection1.ConnectionString);
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                oleDbDataAdapter1.Update(dataSet11.Справки);
                dataSet11.Справки.Clear();
                oleDbDataAdapter1.Fill(dataSet11.Справки);
            }
            catch
            {
                MessageBox.Show("Ошибка с обновлением базы данных!", "Ошибка!", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            data_head = e.RowIndex;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                dataSet11.Справки.Rows[data_head].Delete();
                oleDbDataAdapter1.Update(dataSet11.Справки);
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления!", "Ошибка!", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search_spr sp = new search_spr(oleDbConnection1.ConnectionString);
            sp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = "";
            Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
            exApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet workSheet = (Microsoft.Office.Interop.Excel.Worksheet)exApp.ActiveSheet;
            for(int i = 0;i<dataGridView1.ColumnCount;i++)
            {
                workSheet.Cells[1, i+1] = dataGridView1.Columns[i].HeaderText;
            }
            DateTime datevalue;
            for (int i = 0;i<dataGridView1.RowCount-1;i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (DateTime.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out datevalue) == false)
                    {
                        workSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                    }
                    else
                    {
                        workSheet.Cells[i + 2, j + 1] = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value).ToLongDateString();
                    }
                }
            }
            workSheet.Cells.ColumnWidth = 30;
            path = Environment.CurrentDirectory + "\\Excel.xlsx";
            workSheet.SaveAs(path);
            exApp.Quit();
            MessageBox.Show("Файл был сохранен в текущей рабочей папке!", "Успех!", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path = "";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("Выберите подходящий файл для импорта!", "Ошибка!", MessageBoxButtons.OK);
            }
            DataSet st = new DataSet();
            try
            {
                st.ReadXml(path);
            }
            catch
            {
                MessageBox.Show("Ошибка в чтении файла импорта!", "Ошибка!", MessageBoxButtons.OK);
            }
            try
            {
                dataSet11.Справки.Merge(st.Tables[1], true, MissingSchemaAction.Ignore);
            }
            catch
            {
                MessageBox.Show("Ошибка в переносе данных!", "Ошибка!", MessageBoxButtons.OK);
            }
            dataGridView1.DataSource = dataSet11.Справки;
        }
    }
}
