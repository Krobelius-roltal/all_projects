namespace SPR
{
    partial class search_spr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search_spr));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.dataSet11 = new SPR.DataSet1();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер справки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(324, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(297, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "УН выходной формы";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 121);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные для поиска";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(674, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 264);
            this.dataGridView1.TabIndex = 15;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        Справки.*\r\nFROM            Справки";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText");
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
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
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
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
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
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
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\спр.mdb;Jet OLEDB:Database Passwo" +
    "rd=123";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(689, 56);
            this.button2.TabIndex = 16;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // search_spr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 478);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "search_spr";
            this.Text = "search_spr";
            this.Load += new System.EventHandler(this.search_spr_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Button button2;
    }
}