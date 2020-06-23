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
    public partial class search_spr : Form
    {
        public search_spr(string conn)
        {
            InitializeComponent();
            connect = conn;
        }
        string connect;
        private void search_spr_Load(object sender, EventArgs e)
        {
            oleDbConnection1.ConnectionString = connect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.OleDb.OleDbDataAdapter adapt = new System.Data.OleDb.OleDbDataAdapter("SELECT* FROM Справки WHERE Справки.[Номер справки]=" + "" + Convert.ToInt32(textBox1.Text) + "" + " AND Справки.[Уникальный номер выходной формы]=" + "" + Convert.ToInt32(textBox2.Text) + ";", connect);
                DataSet ds = new DataSet();
                adapt.Fill(dataSet11.Справки);
                this.dataGridView1.AutoGenerateColumns = true;
                this.dataGridView1.DataSource = dataSet11.Справки;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка запроса! Попробуйте ввести другие данные...", "Error!", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
