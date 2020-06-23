namespace word_sh
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.odbcConnection1 = new System.Data.Odbc.OdbcConnection();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odbcSelectCommand1 = new System.Data.Odbc.OdbcCommand();
            this.odbcDataAdapter1 = new System.Data.Odbc.OdbcDataAdapter();
            this.dataSet11 = new word_sh.DataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выбрать файл Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(248, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 159);
            this.button2.TabIndex = 1;
            this.button2.Text = "Выбрать шаблон Word";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(989, 363);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(508, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(494, 159);
            this.button3.TabIndex = 3;
            this.button3.Text = "Перенос данных";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // odbcConnection1
            // 
            this.odbcConnection1.ConnectionString = "Dsn=Excel Files;dbq=D:\\Лист Microsoft Excel.xlsx;defaultdir=D:;driverid=1046;maxb" +
    "uffersize=2048;pagetimeout=5";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            // 
            // odbcSelectCommand1
            // 
            this.odbcSelectCommand1.CommandText = "SELECT        `\'1$\'`.*\r\nFROM            `\'1$\'`";
            this.odbcSelectCommand1.Connection = this.odbcConnection1;
            // 
            // odbcDataAdapter1
            // 
            this.odbcDataAdapter1.SelectCommand = this.odbcSelectCommand1;
            this.odbcDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Table", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("(Имя)", "(Имя)"),
                        new System.Data.Common.DataColumnMapping("(Фамилия)", "(Фамилия)"),
                        new System.Data.Common.DataColumnMapping("(Отчество)", "(Отчество)"),
                        new System.Data.Common.DataColumnMapping("(Год)", "(Год)")})});
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(228, 72);
            this.button5.TabIndex = 6;
            this.button5.Text = "Вывести таблицу ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 554);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Data.Odbc.OdbcConnection odbcConnection1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private System.Data.Odbc.OdbcCommand odbcSelectCommand1;
        private System.Data.Odbc.OdbcDataAdapter odbcDataAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
    }
}

