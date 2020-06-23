using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace word_sh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Microsoft.Office.Interop.Word.Application wordApp;
        Microsoft.Office.Interop.Word.Document wordDoc;
        private void Open(string Fname)
        {
            wordApp = new Microsoft.Office.Interop.Word.Application();
            Object template = Fname;
            Object newTemplate = false;
            Object documentType = Microsoft.Office.Interop.Word.WdNewDocumentType.wdNewBlankDocument;
            Object visible = true;
            wordDoc = wordApp.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);
        }
        public void ReplaceText(string word, string repl)
        {
            Object unit = Microsoft.Office.Interop.Word.WdUnits.
            wdStory;
            Object extend = Microsoft.Office.Interop.Word.
            WdMovementType.wdMove;
            wordApp.Selection.HomeKey(ref unit, ref extend);
            Microsoft.Office.Interop.Word.Find fnd = wordApp.Selection.
            Find;
            fnd.ClearFormatting();
            fnd.Text = word;
            fnd.Replacement.ClearFormatting();
            fnd.Replacement.Text = repl;
            ExecuteReplace(fnd);
        }
        private Boolean ExecuteReplace(Microsoft.Office.Interop.Word.
Find find)
        {
            return ExecuteReplace(find, Microsoft.Office.Interop.Word.
            WdReplace.wdReplaceAll);

        }
        private Boolean ExecuteReplace(Microsoft.Office.Interop.Word.
Find find, Object replaceOption)
        {
            Object findText = Type.Missing;
            Object matchCase = Type.Missing;
            Object matchWholeWord = Type.Missing;
            Object matchWildcards = Type.Missing;
            Object matchSoundsLike = Type.Missing;
            Object matchAllWordForms = Type.Missing;
            Object forward = Type.Missing;
            Object wrap = Type.Missing;
            Object format = Type.Missing;
            Object replaceWith = Type.Missing;
            Object replace = replaceOption;
            Object matchKashida = Type.Missing;
            Object matchDiacritics = Type.Missing;
            Object matchAlefHamza = Type.Missing;
            Object matchControl = Type.Missing;
            return find.Execute(ref findText, ref matchCase,
            ref matchWholeWord, ref matchWildcards, ref matchSoundsLike,
            ref matchAllWordForms, ref forward, ref wrap, ref format,
            ref replaceWith, ref replace, ref matchKashida,
            ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }
        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
        Microsoft.Office.Interop.Excel.Workbook wb;
        public void Openex(string fileName)
        {
            wb = app.Workbooks.Open(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }
        public string[] get()
        {
            string[] result;
            result = new string[wb.Sheets.Count];
            for(int i = 0;i<wb.Sheets.Count;i++)
            {
                result[i] = ((Microsoft.Office.Interop.Excel.Worksheet)wb.Sheets[i + 1]).Name;
            }
            return result;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        string fname;
        private void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fname =openFileDialog1.FileName;
                MessageBox.Show("Файл выбран!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите файл!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime datevalue;
            if (dataGridView1.SelectedRows.Count != 0)
            {
                Open(fname);
                int n = dataGridView1.ColumnCount;
                for (int i = 0; i < n; i++)
                {
                    if (DateTime.TryParse(dataGridView1.Rows[row_check].Cells[i].Value.ToString(),out datevalue) == false)
                    {
                        ReplaceText(dataSet11.Table.Columns[i].ColumnName, dataGridView1.Rows[row_check].Cells[i].Value.ToString());
                    }
                    else
                    {
                        
                        ReplaceText(dataSet11.Table.Columns[i].ColumnName, Convert.ToDateTime(dataGridView1.Rows[row_check].Cells[i].Value).ToLongDateString());
                    }
                }
                wordApp.Visible = true;
            }
            else
            {
                MessageBox.Show("Select Row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        string FexName;
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            dataSet11.Table.Columns.Clear();
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FexName = openFileDialog1.FileName;
                MessageBox.Show("Файл выбран!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Выберите файл!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Openex(FexName);
            string[] sheets = get();
            for (int i = 0; i < sheets.Length; i++)
            {
                comboBox1.Items.Add(sheets[i]);
            }
            comboBox1.Text = comboBox1.Items[0].ToString();
            wb.Close();
            app.Quit();
        }
        int row_check;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row_check = e.RowIndex;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dataSet11.Table.Rows.Clear();
                dataSet11.Table.Columns.Clear();
                odbcConnection1.ConnectionString = "Dsn=Excel Files;dbq=" + FexName + ";defaultdir=D:;driverid=1046;maxbuffersize=2048;pagetimeout=5";
                odbcConnection1.Open();
                odbcDataAdapter1 = new System.Data.Odbc.OdbcDataAdapter("SELECT* FROM" + " " + "[" + comboBox1.Text.ToString() + "$]", odbcConnection1.ConnectionString);
                odbcDataAdapter1.Update(dataSet11.Table);
                odbcDataAdapter1.Fill(dataSet11.Table);
                dataGridView1.DataSource = dataSet11.Table;
                odbcConnection1.Close();
            }
            catch (System.Data.Odbc.OdbcException)
            {
                MessageBox.Show("Выберите файл!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Выберите файл!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
