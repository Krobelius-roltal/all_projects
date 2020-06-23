namespace SPR
{
    partial class Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.dataSet11 = new SPR.DataSet1();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1444, 523);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "База данных";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1431, 488);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 541);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1444, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(931, 32);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 95);
            this.button8.TabIndex = 7;
            this.button8.Text = "Удалить выбранную запись";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(745, 32);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(180, 95);
            this.button7.TabIndex = 6;
            this.button7.Text = "Обновить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(155, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 95);
            this.button6.TabIndex = 5;
            this.button6.Text = "Добавить справку";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1087, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 95);
            this.button5.TabIndex = 4;
            this.button5.Text = "Выход на стартовое окно";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(598, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 95);
            this.button4.TabIndex = 3;
            this.button4.Text = "Импорт данных";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(455, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 95);
            this.button3.TabIndex = 2;
            this.button3.Text = "Экспорт данных";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 95);
            this.button2.TabIndex = 1;
            this.button2.Text = "Поиск по справкам";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "Просмотр данных о инспекциях и сотрудниках";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        Справки.*\r\nFROM            Справки";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection2;
            // 
            // oleDbConnection2
            // 
            this.oleDbConnection2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\спр.mdb;Jet OLEDB:Database Passwo" +
    "rd=123";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText");
            this.oleDbInsertCommand1.Connection = this.oleDbConnection2;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Код_инспекции_по_СОНО", System.Data.OleDb.OleDbType.Integer, 0, "Код инспекции по СОНО"),
            new System.Data.OleDb.OleDbParameter("Название_инспекции", System.Data.OleDb.OleDbType.Integer, 0, "Название инспекции"),
            new System.Data.OleDb.OleDbParameter("Уникальный_номер_выходной_формы", System.Data.OleDb.OleDbType.Integer, 0, "Уникальный номер выходной формы"),
            new System.Data.OleDb.OleDbParameter("Наименование_плательщика", System.Data.OleDb.OleDbType.VarWChar, 0, "Наименование плательщика"),
            new System.Data.OleDb.OleDbParameter("ИНН", System.Data.OleDb.OleDbType.Integer, 0, "ИНН"),
            new System.Data.OleDb.OleDbParameter("КПП", System.Data.OleDb.OleDbType.Integer, 0, "КПП"),
            new System.Data.OleDb.OleDbParameter("Дата_состояния_КРСБ", System.Data.OleDb.OleDbType.Date, 0, "Дата состояния КРСБ"),
            new System.Data.OleDb.OleDbParameter("Дата_выдачи_справки", System.Data.OleDb.OleDbType.Date, 0, "Дата выдачи справки"),
            new System.Data.OleDb.OleDbParameter("Выдал_инспектор", System.Data.OleDb.OleDbType.VarWChar, 0, "Выдал инспектор"),
            new System.Data.OleDb.OleDbParameter("Подписал", System.Data.OleDb.OleDbType.VarWChar, 0, "Подписал"),
            new System.Data.OleDb.OleDbParameter("Согласование_с_отделом_недоимки", System.Data.OleDb.OleDbType.VarWChar, 0, "Согласование с отделом недоимки"),
            new System.Data.OleDb.OleDbParameter("Задолженность", System.Data.OleDb.OleDbType.VarWChar, 0, "Задолженность"),
            new System.Data.OleDb.OleDbParameter("Справка_внесена_в_базу", System.Data.OleDb.OleDbType.Date, 0, "Справка внесена в базу"),
            new System.Data.OleDb.OleDbParameter("Кто_внес_справку", System.Data.OleDb.OleDbType.Integer, 0, "Кто внес справку"),
            new System.Data.OleDb.OleDbParameter("Комментарий_отдела_работы_с_налогоплательщиками_и_СМИ", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Комментарий отдела работы с налогоплательщиками и СМИ"),
            new System.Data.OleDb.OleDbParameter("Внес_комментарий_1", System.Data.OleDb.OleDbType.VarWChar, 0, "Внес комментарий 1"),
            new System.Data.OleDb.OleDbParameter("Комментарий_отдела_в_сфере_оборота_алк_и_таб_продукции", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Комментарий отдела в сфере оборота алк и таб продукции"),
            new System.Data.OleDb.OleDbParameter("Внес_комментарий_2", System.Data.OleDb.OleDbType.VarWChar, 0, "Внес комментарий 2")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection2;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Код_инспекции_по_СОНО", System.Data.OleDb.OleDbType.Integer, 0, "Код инспекции по СОНО"),
            new System.Data.OleDb.OleDbParameter("Название_инспекции", System.Data.OleDb.OleDbType.Integer, 0, "Название инспекции"),
            new System.Data.OleDb.OleDbParameter("Уникальный_номер_выходной_формы", System.Data.OleDb.OleDbType.Integer, 0, "Уникальный номер выходной формы"),
            new System.Data.OleDb.OleDbParameter("Наименование_плательщика", System.Data.OleDb.OleDbType.VarWChar, 0, "Наименование плательщика"),
            new System.Data.OleDb.OleDbParameter("ИНН", System.Data.OleDb.OleDbType.Integer, 0, "ИНН"),
            new System.Data.OleDb.OleDbParameter("КПП", System.Data.OleDb.OleDbType.Integer, 0, "КПП"),
            new System.Data.OleDb.OleDbParameter("Дата_состояния_КРСБ", System.Data.OleDb.OleDbType.Date, 0, "Дата состояния КРСБ"),
            new System.Data.OleDb.OleDbParameter("Дата_выдачи_справки", System.Data.OleDb.OleDbType.Date, 0, "Дата выдачи справки"),
            new System.Data.OleDb.OleDbParameter("Выдал_инспектор", System.Data.OleDb.OleDbType.VarWChar, 0, "Выдал инспектор"),
            new System.Data.OleDb.OleDbParameter("Подписал", System.Data.OleDb.OleDbType.VarWChar, 0, "Подписал"),
            new System.Data.OleDb.OleDbParameter("Согласование_с_отделом_недоимки", System.Data.OleDb.OleDbType.VarWChar, 0, "Согласование с отделом недоимки"),
            new System.Data.OleDb.OleDbParameter("Задолженность", System.Data.OleDb.OleDbType.VarWChar, 0, "Задолженность"),
            new System.Data.OleDb.OleDbParameter("Справка_внесена_в_базу", System.Data.OleDb.OleDbType.Date, 0, "Справка внесена в базу"),
            new System.Data.OleDb.OleDbParameter("Кто_внес_справку", System.Data.OleDb.OleDbType.Integer, 0, "Кто внес справку"),
            new System.Data.OleDb.OleDbParameter("Комментарий_отдела_работы_с_налогоплательщиками_и_СМИ", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Комментарий отдела работы с налогоплательщиками и СМИ"),
            new System.Data.OleDb.OleDbParameter("Внес_комментарий_1", System.Data.OleDb.OleDbType.VarWChar, 0, "Внес комментарий 1"),
            new System.Data.OleDb.OleDbParameter("Комментарий_отдела_в_сфере_оборота_алк_и_таб_продукции", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Комментарий отдела в сфере оборота алк и таб продукции"),
            new System.Data.OleDb.OleDbParameter("Внес_комментарий_2", System.Data.OleDb.OleDbType.VarWChar, 0, "Внес комментарий 2"),
            new System.Data.OleDb.OleDbParameter("IsNull_Код_инспекции_по_СОНО", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код инспекции по СОНО", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Код_инспекции_по_СОНО", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Код инспекции по СОНО", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Название_инспекции", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название инспекции", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Название_инспекции", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Название инспекции", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Номер_справки", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Номер справки", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Уникальный_номер_выходной_формы", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Уникальный номер выходной формы", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Уникальный_номер_выходной_формы", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Уникальный номер выходной формы", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Наименование_плательщика", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Наименование плательщика", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Наименование_плательщика", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Наименование плательщика", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ИНН", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ИНН", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ИНН", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ИНН", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_КПП", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "КПП", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_КПП", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "КПП", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Дата_состояния_КРСБ", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата состояния КРСБ", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Дата_состояния_КРСБ", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Дата состояния КРСБ", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Дата_выдачи_справки", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата выдачи справки", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Дата_выдачи_справки", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Дата выдачи справки", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Выдал_инспектор", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Выдал инспектор", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Выдал_инспектор", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Выдал инспектор", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Подписал", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Подписал", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Подписал", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Подписал", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Согласование_с_отделом_недоимки", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Согласование с отделом недоимки", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Согласование_с_отделом_недоимки", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Согласование с отделом недоимки", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Задолженность", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Задолженность", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Задолженность", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Задолженность", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Справка_внесена_в_базу", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Справка внесена в базу", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Справка_внесена_в_базу", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Справка внесена в базу", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Кто_внес_справку", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Кто внес справку", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Кто_внес_справку", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Кто внес справку", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Внес_комментарий_1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Внес комментарий 1", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Внес_комментарий_1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Внес комментарий 1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Внес_комментарий_2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Внес комментарий 2", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Внес_комментарий_2", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Внес комментарий 2", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection2;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("IsNull_Код_инспекции_по_СОНО", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Код инспекции по СОНО", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Код_инспекции_по_СОНО", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Код инспекции по СОНО", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Название_инспекции", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Название инспекции", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Название_инспекции", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Название инспекции", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Номер_справки", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Номер справки", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Уникальный_номер_выходной_формы", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Уникальный номер выходной формы", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Уникальный_номер_выходной_формы", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Уникальный номер выходной формы", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Наименование_плательщика", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Наименование плательщика", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Наименование_плательщика", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Наименование плательщика", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ИНН", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ИНН", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ИНН", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ИНН", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_КПП", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "КПП", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_КПП", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "КПП", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Дата_состояния_КРСБ", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата состояния КРСБ", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Дата_состояния_КРСБ", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Дата состояния КРСБ", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Дата_выдачи_справки", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата выдачи справки", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Дата_выдачи_справки", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Дата выдачи справки", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Выдал_инспектор", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Выдал инспектор", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Выдал_инспектор", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Выдал инспектор", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Подписал", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Подписал", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Подписал", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Подписал", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Согласование_с_отделом_недоимки", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Согласование с отделом недоимки", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Согласование_с_отделом_недоимки", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Согласование с отделом недоимки", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Задолженность", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Задолженность", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Задолженность", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Задолженность", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Справка_внесена_в_базу", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Справка внесена в базу", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Справка_внесена_в_базу", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Справка внесена в базу", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Кто_внес_справку", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Кто внес справку", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Кто_внес_справку", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Кто внес справку", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Внес_комментарий_1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Внес комментарий 1", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Внес_комментарий_1", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Внес комментарий 1", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Внес_комментарий_2", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Внес комментарий 2", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Внес_комментарий_2", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Внес комментарий 2", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Справки", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Код инспекции по СОНО", "Код инспекции по СОНО"),
                        new System.Data.Common.DataColumnMapping("Название инспекции", "Название инспекции"),
                        new System.Data.Common.DataColumnMapping("Номер справки", "Номер справки"),
                        new System.Data.Common.DataColumnMapping("Уникальный номер выходной формы", "Уникальный номер выходной формы"),
                        new System.Data.Common.DataColumnMapping("Наименование плательщика", "Наименование плательщика"),
                        new System.Data.Common.DataColumnMapping("ИНН", "ИНН"),
                        new System.Data.Common.DataColumnMapping("КПП", "КПП"),
                        new System.Data.Common.DataColumnMapping("Дата состояния КРСБ", "Дата состояния КРСБ"),
                        new System.Data.Common.DataColumnMapping("Дата выдачи справки", "Дата выдачи справки"),
                        new System.Data.Common.DataColumnMapping("Выдал инспектор", "Выдал инспектор"),
                        new System.Data.Common.DataColumnMapping("Подписал", "Подписал"),
                        new System.Data.Common.DataColumnMapping("Согласование с отделом недоимки", "Согласование с отделом недоимки"),
                        new System.Data.Common.DataColumnMapping("Задолженность", "Задолженность"),
                        new System.Data.Common.DataColumnMapping("Справка внесена в базу", "Справка внесена в базу"),
                        new System.Data.Common.DataColumnMapping("Кто внес справку", "Кто внес справку"),
                        new System.Data.Common.DataColumnMapping("Комментарий отдела работы с налогоплательщиками и СМИ", "Комментарий отдела работы с налогоплательщиками и СМИ"),
                        new System.Data.Common.DataColumnMapping("Внес комментарий 1", "Внес комментарий 1"),
                        new System.Data.Common.DataColumnMapping("Комментарий отдела в сфере оборота алк и таб продукции", "Комментарий отдела в сфере оборота алк и таб продукции"),
                        new System.Data.Common.DataColumnMapping("Внес комментарий 2", "Внес комментарий 2")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 686);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Database";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.Database_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}