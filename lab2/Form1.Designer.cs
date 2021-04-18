
namespace lab2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataEmp = new System.Data.SqlClient.SqlDataAdapter();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDataSet1 = new lab2.employeesDataSet1();
            this.getEmployeeTableAdapter = new lab2.employeesDataSet1TableAdapters.GetEmployeeTableAdapter();
            this.txbName = new System.Windows.Forms.TextBox();
            this.mtbPassport = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbS_name = new System.Windows.Forms.TextBox();
            this.txbL_name = new System.Windows.Forms.TextBox();
            this.cmbEdu = new System.Windows.Forms.ComboBox();
            this.cmbReg = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbcDB = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvProf = new System.Windows.Forms.DataGridView();
            this.jobNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.industryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getProfessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProfDataSet = new lab2.employeesDataSet3();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEduProf = new System.Windows.Forms.ComboBox();
            this.cmbInd = new System.Windows.Forms.ComboBox();
            this.cmbCur = new System.Windows.Forms.ComboBox();
            this.nudSal = new System.Windows.Forms.NumericUpDown();
            this.txbJobName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblErrorComp = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txbSite = new System.Windows.Forms.TextBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbCompName = new System.Windows.Forms.TextBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.dgvComp = new System.Windows.Forms.DataGridView();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companySiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompDataSet = new lab2.employeesDataSet5();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbProf = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.dgvEmpProf = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.education1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.industryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getEmployeeProfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpProfDataSet = new lab2.employeesDataSet6();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbEmpl = new System.Windows.Forms.ComboBox();
            this.cmbSch = new System.Windows.Forms.ComboBox();
            this.cmbLoc = new System.Windows.Forms.ComboBox();
            this.numSalComp = new System.Windows.Forms.NumericUpDown();
            this.cmpProf = new System.Windows.Forms.ComboBox();
            this.cmdComp = new System.Windows.Forms.ComboBox();
            this.dgvCompProf = new System.Windows.Forms.DataGridView();
            this.companyNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyEmailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyPhoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companySiteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.industryDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getCompanyProfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompProfDataSet = new lab2.employeesDataSet7();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataProf = new System.Data.SqlClient.SqlDataAdapter();
            this.getProfessionTableAdapter = new lab2.employeesDataSet3TableAdapters.GetProfessionTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbUpd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataComp = new System.Data.SqlClient.SqlDataAdapter();
            this.getCompanyTableAdapter = new lab2.employeesDataSet5TableAdapters.GetCompanyTableAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataEmpProf = new System.Data.SqlClient.SqlDataAdapter();
            this.getEmployeeProfTableAdapter = new lab2.employeesDataSet6TableAdapters.GetEmployeeProfTableAdapter();
            this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataCompProf = new System.Data.SqlClient.SqlDataAdapter();
            this.getCompanyProfTableAdapter = new lab2.employeesDataSet7TableAdapters.GetCompanyProfTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tbcDB.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProfessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSal)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompDataSet)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeeProfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpProfDataSet)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCompanyProfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompProfDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.GetEmployee";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=COMPUTER;Initial Catalog=employees;Persist Security Info=True;User ID" +
    "=sa;Password=123";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "dbo.AddEmployee";
            this.sqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@first_name", System.Data.SqlDbType.VarChar, 20, "first_name"),
            new System.Data.SqlClient.SqlParameter("@second_name", System.Data.SqlDbType.VarChar, 20, "second_name"),
            new System.Data.SqlClient.SqlParameter("@last_name", System.Data.SqlDbType.VarChar, 30, "last_name"),
            new System.Data.SqlClient.SqlParameter("@educationEMP", System.Data.SqlDbType.VarChar, 30, "education"),
            new System.Data.SqlClient.SqlParameter("@region", System.Data.SqlDbType.VarChar, 255, "region")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = "dbo.UpdateEmployee";
            this.sqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@first_name", System.Data.SqlDbType.VarChar, 20, "first_name"),
            new System.Data.SqlClient.SqlParameter("@second_name", System.Data.SqlDbType.VarChar, 20, "second_name"),
            new System.Data.SqlClient.SqlParameter("@last_name", System.Data.SqlDbType.VarChar, 30, "last_name"),
            new System.Data.SqlClient.SqlParameter("@education", System.Data.SqlDbType.VarChar, 30, "education"),
            new System.Data.SqlClient.SqlParameter("@region", System.Data.SqlDbType.VarChar, 255, "region")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "dbo.DeleteEmployee";
            this.sqlDeleteCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // sqlDataEmp
            // 
            this.sqlDataEmp.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataEmp.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataEmp.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataEmp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "GetEmployee", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("first_name", "first_name"),
                        new System.Data.Common.DataColumnMapping("second_name", "second_name"),
                        new System.Data.Common.DataColumnMapping("last_name", "last_name"),
                        new System.Data.Common.DataColumnMapping("education", "education"),
                        new System.Data.Common.DataColumnMapping("region", "region")})});
            this.sqlDataEmp.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.secondnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.educationDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn});
            this.dgvEmployee.DataSource = this.getEmployeeBindingSource;
            this.dgvEmployee.Location = new System.Drawing.Point(7, 79);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(644, 434);
            this.dgvEmployee.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Паспорт";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // secondnameDataGridViewTextBoxColumn
            // 
            this.secondnameDataGridViewTextBoxColumn.DataPropertyName = "second_name";
            this.secondnameDataGridViewTextBoxColumn.HeaderText = "Отчетсво";
            this.secondnameDataGridViewTextBoxColumn.Name = "secondnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // educationDataGridViewTextBoxColumn
            // 
            this.educationDataGridViewTextBoxColumn.DataPropertyName = "education";
            this.educationDataGridViewTextBoxColumn.HeaderText = "Образование";
            this.educationDataGridViewTextBoxColumn.Name = "educationDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Регион";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // getEmployeeBindingSource
            // 
            this.getEmployeeBindingSource.DataMember = "GetEmployee";
            this.getEmployeeBindingSource.DataSource = this.employeesDataSet1;
            // 
            // employeesDataSet1
            // 
            this.employeesDataSet1.DataSetName = "employeesDataSet1";
            this.employeesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getEmployeeTableAdapter
            // 
            this.getEmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(154, 30);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 4;
            // 
            // mtbPassport
            // 
            this.mtbPassport.Location = new System.Drawing.Point(24, 30);
            this.mtbPassport.Mask = "000000";
            this.mtbPassport.Name = "mtbPassport";
            this.mtbPassport.Size = new System.Drawing.Size(100, 20);
            this.mtbPassport.TabIndex = 5;
            this.mtbPassport.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Паспорт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчетсво";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Образование";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(700, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Регион";
            // 
            // txbS_name
            // 
            this.txbS_name.Location = new System.Drawing.Point(288, 30);
            this.txbS_name.Name = "txbS_name";
            this.txbS_name.Size = new System.Drawing.Size(100, 20);
            this.txbS_name.TabIndex = 12;
            // 
            // txbL_name
            // 
            this.txbL_name.Location = new System.Drawing.Point(408, 29);
            this.txbL_name.Name = "txbL_name";
            this.txbL_name.Size = new System.Drawing.Size(100, 20);
            this.txbL_name.TabIndex = 13;
            // 
            // cmbEdu
            // 
            this.cmbEdu.FormattingEnabled = true;
            this.cmbEdu.Items.AddRange(new object[] {
            "Среднее, незаконченное",
            "Среднее, законченное",
            "Средне-специальное",
            "Высшее(Бакалавриат)",
            "Высшее(Магистрат)"});
            this.cmbEdu.Location = new System.Drawing.Point(530, 29);
            this.cmbEdu.Name = "cmbEdu";
            this.cmbEdu.Size = new System.Drawing.Size(121, 21);
            this.cmbEdu.TabIndex = 14;
            // 
            // cmbReg
            // 
            this.cmbReg.FormattingEnabled = true;
            this.cmbReg.Items.AddRange(new object[] {
            "Иркусткая область",
            "Московская область",
            "Ленинградская область",
            "Красноярский край",
            "Калиниградская область",
            "Новосибирская область"});
            this.cmbReg.Location = new System.Drawing.Point(667, 28);
            this.cmbReg.Name = "cmbReg";
            this.cmbReg.Size = new System.Drawing.Size(121, 21);
            this.cmbReg.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbReg);
            this.panel1.Controls.Add(this.cmbEdu);
            this.panel1.Controls.Add(this.txbL_name);
            this.panel1.Controls.Add(this.txbS_name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mtbPassport);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Controls.Add(this.dgvEmployee);
            this.panel1.Location = new System.Drawing.Point(23, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 525);
            this.panel1.TabIndex = 17;
            // 
            // tbcDB
            // 
            this.tbcDB.Controls.Add(this.tabPage1);
            this.tbcDB.Controls.Add(this.tabPage2);
            this.tbcDB.Controls.Add(this.tabPage3);
            this.tbcDB.Controls.Add(this.tabPage4);
            this.tbcDB.Controls.Add(this.tabPage5);
            this.tbcDB.Location = new System.Drawing.Point(12, 52);
            this.tbcDB.Name = "tbcDB";
            this.tbcDB.SelectedIndex = 0;
            this.tbcDB.Size = new System.Drawing.Size(874, 572);
            this.tbcDB.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(866, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "0";
            this.tabPage1.Text = "Люди";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvProf);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cmbEduProf);
            this.tabPage2.Controls.Add(this.cmbInd);
            this.tabPage2.Controls.Add(this.cmbCur);
            this.tabPage2.Controls.Add(this.nudSal);
            this.tabPage2.Controls.Add(this.txbJobName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(866, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "1";
            this.tabPage2.Text = "Профессии";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvProf
            // 
            this.dgvProf.AutoGenerateColumns = false;
            this.dgvProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobNameDataGridViewTextBoxColumn,
            this.salaryTotalDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.industryDataGridViewTextBoxColumn,
            this.educationDataGridViewTextBoxColumn1});
            this.dgvProf.DataSource = this.getProfessionBindingSource;
            this.dgvProf.Location = new System.Drawing.Point(20, 84);
            this.dgvProf.Name = "dgvProf";
            this.dgvProf.Size = new System.Drawing.Size(544, 375);
            this.dgvProf.TabIndex = 21;
            // 
            // jobNameDataGridViewTextBoxColumn
            // 
            this.jobNameDataGridViewTextBoxColumn.DataPropertyName = "JobName";
            this.jobNameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.jobNameDataGridViewTextBoxColumn.Name = "jobNameDataGridViewTextBoxColumn";
            // 
            // salaryTotalDataGridViewTextBoxColumn
            // 
            this.salaryTotalDataGridViewTextBoxColumn.DataPropertyName = "SalaryTotal";
            this.salaryTotalDataGridViewTextBoxColumn.HeaderText = "Зп";
            this.salaryTotalDataGridViewTextBoxColumn.Name = "salaryTotalDataGridViewTextBoxColumn";
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Валюта";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            // 
            // industryDataGridViewTextBoxColumn
            // 
            this.industryDataGridViewTextBoxColumn.DataPropertyName = "Industry";
            this.industryDataGridViewTextBoxColumn.HeaderText = "Направление";
            this.industryDataGridViewTextBoxColumn.Name = "industryDataGridViewTextBoxColumn";
            // 
            // educationDataGridViewTextBoxColumn1
            // 
            this.educationDataGridViewTextBoxColumn1.DataPropertyName = "Education";
            this.educationDataGridViewTextBoxColumn1.HeaderText = "Образование";
            this.educationDataGridViewTextBoxColumn1.Name = "educationDataGridViewTextBoxColumn1";
            // 
            // getProfessionBindingSource
            // 
            this.getProfessionBindingSource.DataMember = "GetProfession";
            this.getProfessionBindingSource.DataSource = this.ProfDataSet;
            // 
            // ProfDataSet
            // 
            this.ProfDataSet.DataSetName = "employeesDataSet3";
            this.ProfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(605, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Образование";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Направление";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Валюта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ЗП";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Название профессии";
            // 
            // cmbEduProf
            // 
            this.cmbEduProf.FormattingEnabled = true;
            this.cmbEduProf.Items.AddRange(new object[] {
            "Среднее, незаконченное",
            "Среднее, законченное",
            "Средне-специальное",
            "Высшее(Бакалавриат)",
            "Высшее(Магистрат)"});
            this.cmbEduProf.Location = new System.Drawing.Point(588, 36);
            this.cmbEduProf.Name = "cmbEduProf";
            this.cmbEduProf.Size = new System.Drawing.Size(121, 21);
            this.cmbEduProf.TabIndex = 15;
            // 
            // cmbInd
            // 
            this.cmbInd.FormattingEnabled = true;
            this.cmbInd.Items.AddRange(new object[] {
            "Кино",
            "Обрзование",
            "Программирование",
            "Медицина",
            "Политика"});
            this.cmbInd.Location = new System.Drawing.Point(443, 36);
            this.cmbInd.Name = "cmbInd";
            this.cmbInd.Size = new System.Drawing.Size(121, 21);
            this.cmbInd.TabIndex = 8;
            // 
            // cmbCur
            // 
            this.cmbCur.FormattingEnabled = true;
            this.cmbCur.Items.AddRange(new object[] {
            "Руб",
            "Дол",
            "Евр"});
            this.cmbCur.Location = new System.Drawing.Point(291, 36);
            this.cmbCur.Name = "cmbCur";
            this.cmbCur.Size = new System.Drawing.Size(121, 21);
            this.cmbCur.TabIndex = 7;
            // 
            // nudSal
            // 
            this.nudSal.Location = new System.Drawing.Point(147, 36);
            this.nudSal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSal.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudSal.Name = "nudSal";
            this.nudSal.Size = new System.Drawing.Size(120, 20);
            this.nudSal.TabIndex = 6;
            this.nudSal.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // txbJobName
            // 
            this.txbJobName.Location = new System.Drawing.Point(20, 34);
            this.txbJobName.Name = "txbJobName";
            this.txbJobName.Size = new System.Drawing.Size(100, 20);
            this.txbJobName.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblErrorComp);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txbSite);
            this.tabPage3.Controls.Add(this.txbMail);
            this.tabPage3.Controls.Add(this.txbCompName);
            this.tabPage3.Controls.Add(this.mtbPhone);
            this.tabPage3.Controls.Add(this.dgvComp);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(866, 546);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = "2";
            this.tabPage3.Text = "Компании";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblErrorComp
            // 
            this.lblErrorComp.AutoSize = true;
            this.lblErrorComp.Location = new System.Drawing.Point(662, 60);
            this.lblErrorComp.Name = "lblErrorComp";
            this.lblErrorComp.Size = new System.Drawing.Size(0, 13);
            this.lblErrorComp.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(570, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Сайт";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(451, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Почта";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(313, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Телефон";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(174, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Название";
            // 
            // txbSite
            // 
            this.txbSite.Location = new System.Drawing.Point(542, 60);
            this.txbSite.Name = "txbSite";
            this.txbSite.Size = new System.Drawing.Size(100, 20);
            this.txbSite.TabIndex = 4;
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(423, 60);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(100, 20);
            this.txbMail.TabIndex = 3;
            // 
            // txbCompName
            // 
            this.txbCompName.Location = new System.Drawing.Point(152, 60);
            this.txbCompName.Name = "txbCompName";
            this.txbCompName.Size = new System.Drawing.Size(100, 20);
            this.txbCompName.TabIndex = 2;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(286, 60);
            this.mtbPhone.Mask = "+7(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(101, 20);
            this.mtbPhone.TabIndex = 1;
            // 
            // dgvComp
            // 
            this.dgvComp.AutoGenerateColumns = false;
            this.dgvComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyNameDataGridViewTextBoxColumn,
            this.companyEmailDataGridViewTextBoxColumn,
            this.companyPhoneDataGridViewTextBoxColumn,
            this.companySiteDataGridViewTextBoxColumn});
            this.dgvComp.DataSource = this.getCompanyBindingSource;
            this.dgvComp.Location = new System.Drawing.Point(177, 100);
            this.dgvComp.Name = "dgvComp";
            this.dgvComp.Size = new System.Drawing.Size(445, 258);
            this.dgvComp.TabIndex = 0;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // companyEmailDataGridViewTextBoxColumn
            // 
            this.companyEmailDataGridViewTextBoxColumn.DataPropertyName = "CompanyEmail";
            this.companyEmailDataGridViewTextBoxColumn.HeaderText = "Почта";
            this.companyEmailDataGridViewTextBoxColumn.Name = "companyEmailDataGridViewTextBoxColumn";
            // 
            // companyPhoneDataGridViewTextBoxColumn
            // 
            this.companyPhoneDataGridViewTextBoxColumn.DataPropertyName = "CompanyPhone";
            this.companyPhoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.companyPhoneDataGridViewTextBoxColumn.Name = "companyPhoneDataGridViewTextBoxColumn";
            // 
            // companySiteDataGridViewTextBoxColumn
            // 
            this.companySiteDataGridViewTextBoxColumn.DataPropertyName = "CompanySite";
            this.companySiteDataGridViewTextBoxColumn.HeaderText = "Сайт";
            this.companySiteDataGridViewTextBoxColumn.Name = "companySiteDataGridViewTextBoxColumn";
            // 
            // getCompanyBindingSource
            // 
            this.getCompanyBindingSource.DataMember = "GetCompany";
            this.getCompanyBindingSource.DataSource = this.CompDataSet;
            // 
            // CompDataSet
            // 
            this.CompDataSet.DataSetName = "employeesDataSet5";
            this.CompDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.cmbProf);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.cmbEmp);
            this.tabPage4.Controls.Add(this.dgvEmpProf);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(866, 546);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Tag = "3";
            this.tabPage4.Text = "Работники";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(218, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Профессия";
            // 
            // cmbProf
            // 
            this.cmbProf.DataSource = this.getProfessionBindingSource;
            this.cmbProf.DisplayMember = "JobName";
            this.cmbProf.FormattingEnabled = true;
            this.cmbProf.Location = new System.Drawing.Point(203, 55);
            this.cmbProf.Name = "cmbProf";
            this.cmbProf.Size = new System.Drawing.Size(121, 21);
            this.cmbProf.TabIndex = 3;
            this.cmbProf.ValueMember = "id";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(52, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Паспорт работника";
            // 
            // cmbEmp
            // 
            this.cmbEmp.DataSource = this.getEmployeeBindingSource;
            this.cmbEmp.DisplayMember = "id";
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(46, 55);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(121, 21);
            this.cmbEmp.TabIndex = 1;
            this.cmbEmp.ValueMember = "id";
            // 
            // dgvEmpProf
            // 
            this.dgvEmpProf.AutoGenerateColumns = false;
            this.dgvEmpProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpProf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.firstnameDataGridViewTextBoxColumn1,
            this.secondnameDataGridViewTextBoxColumn1,
            this.lastnameDataGridViewTextBoxColumn1,
            this.educationDataGridViewTextBoxColumn2,
            this.regionDataGridViewTextBoxColumn1,
            this.jobNameDataGridViewTextBoxColumn1,
            this.education1DataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn1,
            this.industryDataGridViewTextBoxColumn1});
            this.dgvEmpProf.DataSource = this.getEmployeeProfBindingSource;
            this.dgvEmpProf.Location = new System.Drawing.Point(3, 101);
            this.dgvEmpProf.Name = "dgvEmpProf";
            this.dgvEmpProf.Size = new System.Drawing.Size(846, 211);
            this.dgvEmpProf.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.FillWeight = 70F;
            this.idDataGridViewTextBoxColumn1.HeaderText = "Папорт";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 70;
            // 
            // firstnameDataGridViewTextBoxColumn1
            // 
            this.firstnameDataGridViewTextBoxColumn1.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.firstnameDataGridViewTextBoxColumn1.Name = "firstnameDataGridViewTextBoxColumn1";
            // 
            // secondnameDataGridViewTextBoxColumn1
            // 
            this.secondnameDataGridViewTextBoxColumn1.DataPropertyName = "second_name";
            this.secondnameDataGridViewTextBoxColumn1.HeaderText = "Отчество";
            this.secondnameDataGridViewTextBoxColumn1.Name = "secondnameDataGridViewTextBoxColumn1";
            // 
            // lastnameDataGridViewTextBoxColumn1
            // 
            this.lastnameDataGridViewTextBoxColumn1.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.lastnameDataGridViewTextBoxColumn1.Name = "lastnameDataGridViewTextBoxColumn1";
            // 
            // educationDataGridViewTextBoxColumn2
            // 
            this.educationDataGridViewTextBoxColumn2.DataPropertyName = "education";
            this.educationDataGridViewTextBoxColumn2.HeaderText = "Образование работника";
            this.educationDataGridViewTextBoxColumn2.Name = "educationDataGridViewTextBoxColumn2";
            // 
            // regionDataGridViewTextBoxColumn1
            // 
            this.regionDataGridViewTextBoxColumn1.DataPropertyName = "region";
            this.regionDataGridViewTextBoxColumn1.HeaderText = "Регион";
            this.regionDataGridViewTextBoxColumn1.Name = "regionDataGridViewTextBoxColumn1";
            // 
            // jobNameDataGridViewTextBoxColumn1
            // 
            this.jobNameDataGridViewTextBoxColumn1.DataPropertyName = "JobName";
            this.jobNameDataGridViewTextBoxColumn1.HeaderText = "Название профессии";
            this.jobNameDataGridViewTextBoxColumn1.Name = "jobNameDataGridViewTextBoxColumn1";
            // 
            // education1DataGridViewTextBoxColumn
            // 
            this.education1DataGridViewTextBoxColumn.DataPropertyName = "Education1";
            this.education1DataGridViewTextBoxColumn.HeaderText = "Требование к образованию";
            this.education1DataGridViewTextBoxColumn.Name = "education1DataGridViewTextBoxColumn";
            // 
            // currencyDataGridViewTextBoxColumn1
            // 
            this.currencyDataGridViewTextBoxColumn1.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn1.FillWeight = 50F;
            this.currencyDataGridViewTextBoxColumn1.HeaderText = "Валюта";
            this.currencyDataGridViewTextBoxColumn1.Name = "currencyDataGridViewTextBoxColumn1";
            this.currencyDataGridViewTextBoxColumn1.Width = 50;
            // 
            // industryDataGridViewTextBoxColumn1
            // 
            this.industryDataGridViewTextBoxColumn1.DataPropertyName = "Industry";
            this.industryDataGridViewTextBoxColumn1.HeaderText = "Направление";
            this.industryDataGridViewTextBoxColumn1.Name = "industryDataGridViewTextBoxColumn1";
            // 
            // getEmployeeProfBindingSource
            // 
            this.getEmployeeProfBindingSource.DataMember = "GetEmployeeProf";
            this.getEmployeeProfBindingSource.DataSource = this.EmpProfDataSet;
            // 
            // EmpProfDataSet
            // 
            this.EmpProfDataSet.DataSetName = "employeesDataSet6";
            this.EmpProfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label23);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.cmbEmpl);
            this.tabPage5.Controls.Add(this.cmbSch);
            this.tabPage5.Controls.Add(this.cmbLoc);
            this.tabPage5.Controls.Add(this.numSalComp);
            this.tabPage5.Controls.Add(this.cmpProf);
            this.tabPage5.Controls.Add(this.cmdComp);
            this.tabPage5.Controls.Add(this.dgvCompProf);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(866, 546);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Tag = "4";
            this.tabPage5.Text = "Работа";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(728, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 12;
            this.label23.Text = "Занятость";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(587, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 13);
            this.label22.TabIndex = 11;
            this.label22.Text = "График";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(454, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 13);
            this.label21.TabIndex = 10;
            this.label21.Text = "Расположение";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(292, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "Оплата";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(154, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Профессия";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Компания";
            // 
            // cmbEmpl
            // 
            this.cmbEmpl.FormattingEnabled = true;
            this.cmbEmpl.Items.AddRange(new object[] {
            "Полная ставка",
            "Полставки",
            "Четверть ставки"});
            this.cmbEmpl.Location = new System.Drawing.Point(728, 55);
            this.cmbEmpl.Name = "cmbEmpl";
            this.cmbEmpl.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpl.TabIndex = 6;
            // 
            // cmbSch
            // 
            this.cmbSch.FormattingEnabled = true;
            this.cmbSch.Items.AddRange(new object[] {
            "2/2",
            "5/2",
            "3/3",
            "40/40",
            "Свободный"});
            this.cmbSch.Location = new System.Drawing.Point(587, 55);
            this.cmbSch.Name = "cmbSch";
            this.cmbSch.Size = new System.Drawing.Size(121, 21);
            this.cmbSch.TabIndex = 5;
            // 
            // cmbLoc
            // 
            this.cmbLoc.FormattingEnabled = true;
            this.cmbLoc.Items.AddRange(new object[] {
            "Иркусткая область",
            "Московская область",
            "Ленинградская область",
            "Красноярский край",
            "Калиниградская область",
            "Новосибирская область"});
            this.cmbLoc.Location = new System.Drawing.Point(439, 55);
            this.cmbLoc.Name = "cmbLoc";
            this.cmbLoc.Size = new System.Drawing.Size(121, 21);
            this.cmbLoc.TabIndex = 4;
            // 
            // numSalComp
            // 
            this.numSalComp.Location = new System.Drawing.Point(283, 56);
            this.numSalComp.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.numSalComp.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numSalComp.Name = "numSalComp";
            this.numSalComp.Size = new System.Drawing.Size(120, 20);
            this.numSalComp.TabIndex = 3;
            this.numSalComp.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // cmpProf
            // 
            this.cmpProf.DataSource = this.getProfessionBindingSource;
            this.cmpProf.DisplayMember = "JobName";
            this.cmpProf.FormattingEnabled = true;
            this.cmpProf.Location = new System.Drawing.Point(142, 56);
            this.cmpProf.Name = "cmpProf";
            this.cmpProf.Size = new System.Drawing.Size(121, 21);
            this.cmpProf.TabIndex = 2;
            this.cmpProf.ValueMember = "id";
            // 
            // cmdComp
            // 
            this.cmdComp.DataSource = this.getCompanyBindingSource;
            this.cmdComp.DisplayMember = "CompanyName";
            this.cmdComp.FormattingEnabled = true;
            this.cmdComp.Location = new System.Drawing.Point(3, 55);
            this.cmdComp.Name = "cmdComp";
            this.cmdComp.Size = new System.Drawing.Size(121, 21);
            this.cmdComp.TabIndex = 1;
            this.cmdComp.ValueMember = "idCompany";
            // 
            // dgvCompProf
            // 
            this.dgvCompProf.AutoGenerateColumns = false;
            this.dgvCompProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompProf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyNameDataGridViewTextBoxColumn1,
            this.companyEmailDataGridViewTextBoxColumn1,
            this.companyPhoneDataGridViewTextBoxColumn1,
            this.companySiteDataGridViewTextBoxColumn1,
            this.jobNameDataGridViewTextBoxColumn2,
            this.currencyDataGridViewTextBoxColumn2,
            this.educationDataGridViewTextBoxColumn3,
            this.industryDataGridViewTextBoxColumn2,
            this.employmentDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.scheduleDataGridViewTextBoxColumn});
            this.dgvCompProf.DataSource = this.getCompanyProfBindingSource;
            this.dgvCompProf.Location = new System.Drawing.Point(0, 120);
            this.dgvCompProf.Name = "dgvCompProf";
            this.dgvCompProf.Size = new System.Drawing.Size(858, 247);
            this.dgvCompProf.TabIndex = 0;
            // 
            // companyNameDataGridViewTextBoxColumn1
            // 
            this.companyNameDataGridViewTextBoxColumn1.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn1.HeaderText = "Название компании";
            this.companyNameDataGridViewTextBoxColumn1.Name = "companyNameDataGridViewTextBoxColumn1";
            // 
            // companyEmailDataGridViewTextBoxColumn1
            // 
            this.companyEmailDataGridViewTextBoxColumn1.DataPropertyName = "CompanyEmail";
            this.companyEmailDataGridViewTextBoxColumn1.HeaderText = "Почта компании";
            this.companyEmailDataGridViewTextBoxColumn1.Name = "companyEmailDataGridViewTextBoxColumn1";
            // 
            // companyPhoneDataGridViewTextBoxColumn1
            // 
            this.companyPhoneDataGridViewTextBoxColumn1.DataPropertyName = "CompanyPhone";
            this.companyPhoneDataGridViewTextBoxColumn1.HeaderText = "Телефон компании";
            this.companyPhoneDataGridViewTextBoxColumn1.Name = "companyPhoneDataGridViewTextBoxColumn1";
            // 
            // companySiteDataGridViewTextBoxColumn1
            // 
            this.companySiteDataGridViewTextBoxColumn1.DataPropertyName = "CompanySite";
            this.companySiteDataGridViewTextBoxColumn1.HeaderText = "Сайт компании";
            this.companySiteDataGridViewTextBoxColumn1.Name = "companySiteDataGridViewTextBoxColumn1";
            // 
            // jobNameDataGridViewTextBoxColumn2
            // 
            this.jobNameDataGridViewTextBoxColumn2.DataPropertyName = "JobName";
            this.jobNameDataGridViewTextBoxColumn2.HeaderText = "Название профессии";
            this.jobNameDataGridViewTextBoxColumn2.Name = "jobNameDataGridViewTextBoxColumn2";
            // 
            // currencyDataGridViewTextBoxColumn2
            // 
            this.currencyDataGridViewTextBoxColumn2.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn2.HeaderText = "Валюта";
            this.currencyDataGridViewTextBoxColumn2.Name = "currencyDataGridViewTextBoxColumn2";
            // 
            // educationDataGridViewTextBoxColumn3
            // 
            this.educationDataGridViewTextBoxColumn3.DataPropertyName = "Education";
            this.educationDataGridViewTextBoxColumn3.HeaderText = "Образование";
            this.educationDataGridViewTextBoxColumn3.Name = "educationDataGridViewTextBoxColumn3";
            // 
            // industryDataGridViewTextBoxColumn2
            // 
            this.industryDataGridViewTextBoxColumn2.DataPropertyName = "Industry";
            this.industryDataGridViewTextBoxColumn2.HeaderText = "Направление";
            this.industryDataGridViewTextBoxColumn2.Name = "industryDataGridViewTextBoxColumn2";
            // 
            // employmentDataGridViewTextBoxColumn
            // 
            this.employmentDataGridViewTextBoxColumn.DataPropertyName = "Employment";
            this.employmentDataGridViewTextBoxColumn.HeaderText = "Занятость";
            this.employmentDataGridViewTextBoxColumn.Name = "employmentDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Расположение";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Оплата";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // scheduleDataGridViewTextBoxColumn
            // 
            this.scheduleDataGridViewTextBoxColumn.DataPropertyName = "Schedule";
            this.scheduleDataGridViewTextBoxColumn.HeaderText = "График";
            this.scheduleDataGridViewTextBoxColumn.Name = "scheduleDataGridViewTextBoxColumn";
            // 
            // getCompanyProfBindingSource
            // 
            this.getCompanyProfBindingSource.DataMember = "GetCompanyProf";
            this.getCompanyProfBindingSource.DataSource = this.CompProfDataSet;
            // 
            // CompProfDataSet
            // 
            this.CompProfDataSet.DataSetName = "employeesDataSet7";
            this.CompProfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "dbo.GetProfession";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = "dbo.AddProfession";
            this.sqlInsertCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand2.Connection = this.sqlConnection1;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@SalaryTotal", System.Data.SqlDbType.Int, 4, "SalaryTotal"),
            new System.Data.SqlClient.SqlParameter("@Currency", System.Data.SqlDbType.VarChar, 3, "Currency"),
            new System.Data.SqlClient.SqlParameter("@Industry", System.Data.SqlDbType.VarChar, 255, "Industry"),
            new System.Data.SqlClient.SqlParameter("@JobName", System.Data.SqlDbType.VarChar, 255, "JobName"),
            new System.Data.SqlClient.SqlParameter("@Education", System.Data.SqlDbType.VarChar, 30, "Education")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = "dbo.UpdateProfession";
            this.sqlUpdateCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand2.Connection = this.sqlConnection1;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@SalaryTotal", System.Data.SqlDbType.Int, 4, "SalaryTotal"),
            new System.Data.SqlClient.SqlParameter("@Currency", System.Data.SqlDbType.VarChar, 3, "Currency"),
            new System.Data.SqlClient.SqlParameter("@Industry", System.Data.SqlDbType.VarChar, 255, "Industry"),
            new System.Data.SqlClient.SqlParameter("@JobName", System.Data.SqlDbType.VarChar, 255, "JobName"),
            new System.Data.SqlClient.SqlParameter("@Education", System.Data.SqlDbType.VarChar, 30, "Education")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = "dbo.DeleteProfession";
            this.sqlDeleteCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand2.Connection = this.sqlConnection1;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@idProf", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // sqlDataProf
            // 
            this.sqlDataProf.DeleteCommand = this.sqlDeleteCommand2;
            this.sqlDataProf.InsertCommand = this.sqlInsertCommand2;
            this.sqlDataProf.SelectCommand = this.sqlSelectCommand2;
            this.sqlDataProf.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "GetProfession", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("SalaryTotal", "SalaryTotal"),
                        new System.Data.Common.DataColumnMapping("Currency", "Currency"),
                        new System.Data.Common.DataColumnMapping("Industry", "Industry"),
                        new System.Data.Common.DataColumnMapping("JobName", "JobName"),
                        new System.Data.Common.DataColumnMapping("Education", "Education")})});
            this.sqlDataProf.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // getProfessionTableAdapter
            // 
            this.getProfessionTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbDel,
            this.tsbSearch,
            this.tsbUpd,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(877, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(63, 22);
            this.tsbAdd.Text = "Добавить";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbDel
            // 
            this.tsbDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbDel.Image")));
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(55, 22);
            this.tsbDel.Text = "Удалить";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            // 
            // tsbSearch
            // 
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(45, 22);
            this.tsbSearch.Text = "Найти";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tsbUpd
            // 
            this.tsbUpd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbUpd.Enabled = false;
            this.tsbUpd.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpd.Image")));
            this.tsbUpd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpd.Name = "tsbUpd";
            this.tsbUpd.Size = new System.Drawing.Size(65, 22);
            this.tsbUpd.Text = "Обновить";
            this.tsbUpd.Click += new System.EventHandler(this.tsbUpd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "dbo.GetCompany";
            this.sqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand3.Connection = this.sqlConnection1;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand3
            // 
            this.sqlInsertCommand3.CommandText = "dbo.AddCompany";
            this.sqlInsertCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand3.Connection = this.sqlConnection1;
            this.sqlInsertCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CompanyEmail", System.Data.SqlDbType.VarChar, 40, "CompanyEmail"),
            new System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.VarChar, 255, "CompanyName"),
            new System.Data.SqlClient.SqlParameter("@CompanyPhone", System.Data.SqlDbType.VarChar, 20, "CompanyPhone"),
            new System.Data.SqlClient.SqlParameter("@CompanySite", System.Data.SqlDbType.VarChar, 60, "CompanySite")});
            // 
            // sqlUpdateCommand3
            // 
            this.sqlUpdateCommand3.CommandText = "dbo.UpdateCompany";
            this.sqlUpdateCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand3.Connection = this.sqlConnection1;
            this.sqlUpdateCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@CompanyEmail", System.Data.SqlDbType.VarChar, 40, "CompanyEmail"),
            new System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.VarChar, 255, "CompanyName"),
            new System.Data.SqlClient.SqlParameter("@CompanyPhone", System.Data.SqlDbType.VarChar, 20, "CompanyPhone"),
            new System.Data.SqlClient.SqlParameter("@CompanySite", System.Data.SqlDbType.VarChar, 60, "CompanySite")});
            // 
            // sqlDeleteCommand3
            // 
            this.sqlDeleteCommand3.CommandText = "dbo.DeleteCompany";
            this.sqlDeleteCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand3.Connection = this.sqlConnection1;
            this.sqlDeleteCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CompId", System.Data.SqlDbType.VarChar, 255)});
            // 
            // sqlDataComp
            // 
            this.sqlDataComp.DeleteCommand = this.sqlDeleteCommand3;
            this.sqlDataComp.InsertCommand = this.sqlInsertCommand3;
            this.sqlDataComp.SelectCommand = this.sqlSelectCommand3;
            this.sqlDataComp.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "GetCompany", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("idCompany", "idCompany"),
                        new System.Data.Common.DataColumnMapping("CompanyEmail", "CompanyEmail"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("CompanyPhone", "CompanyPhone"),
                        new System.Data.Common.DataColumnMapping("CompanySite", "CompanySite")})});
            this.sqlDataComp.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // getCompanyTableAdapter
            // 
            this.getCompanyTableAdapter.ClearBeforeFill = true;
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "dbo.GetEmployeeProf";
            this.sqlSelectCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand4.Connection = this.sqlConnection1;
            this.sqlSelectCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand4
            // 
            this.sqlInsertCommand4.CommandText = "dbo.AddEmployeeProf";
            this.sqlInsertCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand4.Connection = this.sqlConnection1;
            this.sqlInsertCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Employee_id", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // sqlUpdateCommand4
            // 
            this.sqlUpdateCommand4.CommandText = "dbo.UpdateEmployeeProf";
            this.sqlUpdateCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand4.Connection = this.sqlConnection1;
            this.sqlUpdateCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@idProf", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@OldIdProf", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // sqlDeleteCommand4
            // 
            this.sqlDeleteCommand4.CommandText = "dbo.DeleteEmployeeProf";
            this.sqlDeleteCommand4.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand4.Connection = this.sqlConnection1;
            this.sqlDeleteCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id"),
            new System.Data.SqlClient.SqlParameter("@idProf", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // sqlDataEmpProf
            // 
            this.sqlDataEmpProf.DeleteCommand = this.sqlDeleteCommand4;
            this.sqlDataEmpProf.InsertCommand = this.sqlInsertCommand4;
            this.sqlDataEmpProf.SelectCommand = this.sqlSelectCommand4;
            this.sqlDataEmpProf.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "GetEmployeeProf", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("Profession_id", "Profession_id"),
                        new System.Data.Common.DataColumnMapping("first_name", "first_name"),
                        new System.Data.Common.DataColumnMapping("last_name", "last_name"),
                        new System.Data.Common.DataColumnMapping("second_name", "second_name"),
                        new System.Data.Common.DataColumnMapping("education", "education"),
                        new System.Data.Common.DataColumnMapping("region", "region"),
                        new System.Data.Common.DataColumnMapping("Education1", "Education1"),
                        new System.Data.Common.DataColumnMapping("Currency", "Currency"),
                        new System.Data.Common.DataColumnMapping("Industry", "Industry"),
                        new System.Data.Common.DataColumnMapping("JobName", "JobName"),
                        new System.Data.Common.DataColumnMapping("SalaryTotal", "SalaryTotal")})});
            this.sqlDataEmpProf.UpdateCommand = this.sqlUpdateCommand4;
            // 
            // getEmployeeProfTableAdapter
            // 
            this.getEmployeeProfTableAdapter.ClearBeforeFill = true;
            // 
            // sqlSelectCommand5
            // 
            this.sqlSelectCommand5.CommandText = "dbo.GetCompanyProf";
            this.sqlSelectCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand5.Connection = this.sqlConnection1;
            this.sqlSelectCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand5
            // 
            this.sqlInsertCommand5.CommandText = "dbo.AddProfCompany";
            this.sqlInsertCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand5.Connection = this.sqlConnection1;
            this.sqlInsertCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@idProf", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@idComp", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@Salary", System.Data.SqlDbType.Int, 4, "Salary"),
            new System.Data.SqlClient.SqlParameter("@Schedule", System.Data.SqlDbType.VarChar, 20, "Schedule"),
            new System.Data.SqlClient.SqlParameter("@Employment", System.Data.SqlDbType.VarChar, 20, "Employment"),
            new System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.VarChar, 255, "Location")});
            // 
            // sqlUpdateCommand5
            // 
            this.sqlUpdateCommand5.CommandText = "dbo.UpdateProfCompany";
            this.sqlUpdateCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand5.Connection = this.sqlConnection1;
            this.sqlUpdateCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CompId", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@idProf", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@Salary", System.Data.SqlDbType.Int, 4, "Salary"),
            new System.Data.SqlClient.SqlParameter("@Schedule", System.Data.SqlDbType.VarChar, 20, "Schedule"),
            new System.Data.SqlClient.SqlParameter("@Employment", System.Data.SqlDbType.VarChar, 20, "Employment"),
            new System.Data.SqlClient.SqlParameter("@Location", System.Data.SqlDbType.VarChar, 255, "Location")});
            // 
            // sqlDeleteCommand5
            // 
            this.sqlDeleteCommand5.CommandText = "dbo.DeleteProfCompany";
            this.sqlDeleteCommand5.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand5.Connection = this.sqlConnection1;
            this.sqlDeleteCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@ProfId", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@CompId", System.Data.SqlDbType.Int, 4)});
            // 
            // sqlDataCompProf
            // 
            this.sqlDataCompProf.DeleteCommand = this.sqlDeleteCommand5;
            this.sqlDataCompProf.InsertCommand = this.sqlInsertCommand5;
            this.sqlDataCompProf.SelectCommand = this.sqlSelectCommand5;
            this.sqlDataCompProf.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "GetCompanyProf", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Company_idCompany", "Company_idCompany"),
                        new System.Data.Common.DataColumnMapping("Profession_id", "Profession_id"),
                        new System.Data.Common.DataColumnMapping("CompanyEmail", "CompanyEmail"),
                        new System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"),
                        new System.Data.Common.DataColumnMapping("CompanyPhone", "CompanyPhone"),
                        new System.Data.Common.DataColumnMapping("CompanySite", "CompanySite"),
                        new System.Data.Common.DataColumnMapping("Currency", "Currency"),
                        new System.Data.Common.DataColumnMapping("Education", "Education"),
                        new System.Data.Common.DataColumnMapping("Industry", "Industry"),
                        new System.Data.Common.DataColumnMapping("JobName", "JobName"),
                        new System.Data.Common.DataColumnMapping("SalaryTotal", "SalaryTotal"),
                        new System.Data.Common.DataColumnMapping("Employment", "Employment"),
                        new System.Data.Common.DataColumnMapping("Location", "Location"),
                        new System.Data.Common.DataColumnMapping("Salary", "Salary"),
                        new System.Data.Common.DataColumnMapping("Schedule", "Schedule")})});
            this.sqlDataCompProf.UpdateCommand = this.sqlUpdateCommand5;
            // 
            // getCompanyProfTableAdapter
            // 
            this.getCompanyProfTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 625);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbcDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbcDB.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProfessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSal)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompDataSet)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getEmployeeProfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpProfDataSet)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getCompanyProfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompProfDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataEmp;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private employeesDataSet1 employeesDataSet1;
        private System.Windows.Forms.BindingSource getEmployeeBindingSource;
        private employeesDataSet1TableAdapters.GetEmployeeTableAdapter getEmployeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.MaskedTextBox mtbPassport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbS_name;
        private System.Windows.Forms.TextBox txbL_name;
        private System.Windows.Forms.ComboBox cmbEdu;
        private System.Windows.Forms.ComboBox cmbReg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tbcDB;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox cmbInd;
        private System.Windows.Forms.ComboBox cmbCur;
        private System.Windows.Forms.NumericUpDown nudSal;
        private System.Windows.Forms.TextBox txbJobName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEduProf;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDataProf;
        private System.Windows.Forms.DataGridView dgvProf;
        private employeesDataSet3 ProfDataSet;
        private System.Windows.Forms.BindingSource getProfessionBindingSource;
        private employeesDataSet3TableAdapters.GetProfessionTableAdapter getProfessionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn industryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvComp;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbSite;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox txbCompName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbUpd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private System.Data.SqlClient.SqlDataAdapter sqlDataComp;
        private employeesDataSet5 CompDataSet;
        private System.Windows.Forms.BindingSource getCompanyBindingSource;
        private employeesDataSet5TableAdapters.GetCompanyTableAdapter getCompanyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companySiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblErrorComp;
        private System.Windows.Forms.DataGridView dgvEmpProf;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand4;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand4;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand4;
        private System.Data.SqlClient.SqlDataAdapter sqlDataEmpProf;
        private employeesDataSet6 EmpProfDataSet;
        private System.Windows.Forms.BindingSource getEmployeeProfBindingSource;
        private employeesDataSet6TableAdapters.GetEmployeeProfTableAdapter getEmployeeProfTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn education1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn industryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.ComboBox cmbProf;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvCompProf;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand5;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand5;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand5;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand5;
        private System.Data.SqlClient.SqlDataAdapter sqlDataCompProf;
        private employeesDataSet7 CompProfDataSet;
        private System.Windows.Forms.BindingSource getCompanyProfBindingSource;
        private employeesDataSet7TableAdapters.GetCompanyProfTableAdapter getCompanyProfTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyEmailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyPhoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn companySiteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn industryDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn employmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbEmpl;
        private System.Windows.Forms.ComboBox cmbSch;
        private System.Windows.Forms.ComboBox cmbLoc;
        private System.Windows.Forms.NumericUpDown numSalComp;
        private System.Windows.Forms.ComboBox cmpProf;
        private System.Windows.Forms.ComboBox cmdComp;
    }
}

