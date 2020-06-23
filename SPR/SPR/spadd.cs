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
    public partial class spadd : Form
    {
        public spadd(string conn)
        {
            InitializeComponent();
            connection = conn;
        }
        string connection;
        private void spadd_Load(object sender, EventArgs e)
        {
            oleDbConnection1.ConnectionString = connection;
            oleDbDataAdapter1.SelectCommand.Connection.ConnectionString = connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text != "" && textBox4.Text !="" && textBox5.Text != "" && textBox6.Text != "" && dateTimePicker1.Value != null && textBox9.Text != "" && textBox10.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && textBox2.Text != "" && textBox1.Text != "" && textBox7.Text != "" && dateTimePicker2.Value != null && dateTimePicker3.Value != null)
            {
                DataRow row = dataSet11.Справки.NewRow();
                try
                {
                    row["Уникальный номер выходной формы"] = textBox3.Text;
                    row["Наименование плательщика"] = textBox4.Text;
                    row["ИНН"] = textBox5.Text;
                    row["КПП"] = textBox6.Text;
                    row["Дата выдачи справки"] = dateTimePicker1.Value;
                    row["Выдал инспектор"] = textBox9.Text;
                    row["Подписал"] = textBox10.Text;
                    row["Согласование с отделом недоимки"] = comboBox1.SelectedItem;
                    row["Задолженность"] = comboBox2.SelectedItem;
                    row["Код инспекции по СОНО"] = textBox1.Text;
                    row["Название инспекции"] = textBox2.Text;
                    row["Кто внес справку"] = textBox7.Text;
                    row["Дата состояния КРСБ"] = dateTimePicker2.Value;
                    row["Справка внесена в базу"] = dateTimePicker3.Value;
                    dataSet11.Справки.Rows.Add(row);
                    oleDbDataAdapter1.Update(dataSet11.Справки);
                    MessageBox.Show("Данные успешно добавлены!Обновите главную форму для отображения!", "Успех!", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Введенные данные ошибочны!", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Введите все данные!", "Error", MessageBoxButtons.OK);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
