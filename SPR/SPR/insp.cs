using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPR
{
    public partial class insp : Form
    {
        public insp(string connect)
        {
            InitializeComponent();
            conn = connect;
        }
        int data_head1, data_head2, data_head3;
        string conn;
        private void insp_Load(object sender, EventArgs e)
        {
            oleDbConnection1.ConnectionString = conn;
            oleDbConnection1.Open();
            oleDbDataAdapter1.SelectCommand.Connection.ConnectionString = conn;
            oleDbDataAdapter2.SelectCommand.Connection.ConnectionString = conn;
            oleDbDataAdapter3.SelectCommand.Connection.ConnectionString = conn;
            oleDbDataAdapter1.Update(dataSet21.Сотрудники);
            oleDbDataAdapter2.Update(dataSet21.Руководители);
            oleDbDataAdapter3.Update(dataSet21.Инспекция);
            oleDbDataAdapter1.Fill(dataSet21.Сотрудники);
            oleDbDataAdapter2.Fill(dataSet21.Руководители);
            oleDbDataAdapter3.Fill(dataSet21.Инспекция);
            dataGridView4.DataSource = dataSet21.Сотрудники;
            dataGridView2.DataSource = dataSet21.Руководители;
            dataGridView3.DataSource = dataSet21.Инспекция;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!= "" && textBox2.Text != "" && textBox3.Text != "")
            {
                DataRow row = dataSet21.Сотрудники.NewRow();
                row["ФИО инспектора"] = textBox1.Text;
                row["Должность инспектора"] = textBox2.Text;
                row["Телефон инспектора"] = textBox3.Text;
                dataSet21.Сотрудники.Rows.Add(row);
                oleDbDataAdapter1.Update(dataSet21.Сотрудники);
            }
            else
            {
                MessageBox.Show("Введите все данные!", "Error", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                DataRow row = dataSet21.Руководители.NewRow();
                row["ФИО начальника или заместителя"] = textBox4.Text;
                row["Должность"] = textBox5.Text;
                row["Телефон"] = textBox6.Text;
                dataSet21.Руководители.Rows.Add(row);
                oleDbDataAdapter2.Update(dataSet21.Руководители);
            }
            else
            {
                MessageBox.Show("Введите все данные!", "Error", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                dataSet21.Руководители.Rows[data_head2].Delete();
                oleDbDataAdapter2.Update(dataSet21.Руководители);
            }
            else
            {
                MessageBox.Show("Выберите строку!", "Error", MessageBoxButtons.OK);
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            data_head2 = e.RowIndex;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "")
            {
                DataRow row = dataSet21.Инспекция.NewRow();
                row["Наименование инспекции"] = textBox7.Text;
                row["Пароль ИФНС"] = textBox8.Text;
                row["Пароль УФНС"] = textBox9.Text;
                row["Пароль Администратора"] = textBox10.Text;
                row["Наименование сервера с БД"] = textBox11.Text;
                dataSet21.Инспекция.Rows.Add(row);
                oleDbDataAdapter3.Update(dataSet21.Инспекция);
            }
            else
            {
                MessageBox.Show("Введите все данные!", "Error", MessageBoxButtons.OK);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 0)
            {
                dataSet21.Инспекция.Rows[data_head3].Delete();
                oleDbDataAdapter3.Update(dataSet21.Инспекция);
            }
            else
            {
                MessageBox.Show("Выберите строку!", "Error", MessageBoxButtons.OK);
            }
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            data_head3 = e.RowIndex;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView4.SelectedRows.Count != 0)
            {
                dataSet21.Сотрудники.Rows[data_head1].Delete();
                oleDbDataAdapter1.Update(dataSet21.Сотрудники);
            }
            else
            {
                MessageBox.Show("Выберите строку!", "Error", MessageBoxButtons.OK);
            }
        }

        private void dataGridView4_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            data_head1 = e.RowIndex;
        }
    }
}
