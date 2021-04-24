using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;



namespace lab2
{
    public partial class Form1 : Form
    {
        private Excel.Application excelapp;
        private Excel.Workbooks excelappworkbooks;
        private Excel.Workbook excelappworkbook;
        private Excel.Sheets excelsheets;
        private Excel.Worksheet excelworksheet;
        private Excel.Range excelcells;


        public Form1()
        {
            InitializeComponent();
            UpdateCombos();
        }

        void AsyncExcel(Dictionary<string, DataGridView> dataGridViews)
        {
            int i = 1;
            foreach (var dgv in dataGridViews)
            {
                var table = dgv.Value;
                var countColumns = table.Columns.Count;
                var countRows = table.Rows.Count;
                excelworksheet = excelappworkbook.Worksheets[i];
                char index = 'A';
                for (int j = 0; j < countColumns; j++)
                {
                    string cell = index + (1).ToString();
                    excelcells = excelworksheet.get_Range(cell, Type.Missing);
                    excelcells.set_Value(Type.Missing, table.Columns[j].HeaderText.ToString());
                    index++;
                }
                for (int j = 0; j < countRows; j++) { 
                    index = 'A';
                    for (int k = 0; k < countColumns; k++)
                    {
                        string cell = index + (j + 2).ToString();
                        excelcells = excelworksheet.get_Range(cell, Type.Missing);
                        if (j == 0)
                        {
                            excelcells.set_Value(Type.Missing, table.Columns[k].HeaderText.ToString());
                        }
                        excelcells.set_Value(Type.Missing, table[k, j].Value);
                        index++;
                    }
                }
                i++;
            }

            //Сохраняем книгу 1
            excelappworkbook.Save();
        }

        async void Excel()
        {
            Dictionary<string, DataGridView> dataGridViews = new Dictionary<string, DataGridView>();
            dataGridViews.Add("Люди", dgvEmployee);
            dataGridViews.Add("Профессии", dgvProf);
            dataGridViews.Add("Компании", dgvComp);
            dataGridViews.Add("Работники", dgvEmpProf);
            dataGridViews.Add("Работа", dgvCompProf);
            excelapp = new Excel.Application();
            excelapp.SheetsInNewWorkbook = 5;
            excelapp.Workbooks.Add(Type.Missing);
            excelapp.DisplayAlerts = true;
            excelappworkbooks = excelapp.Workbooks;
            excelappworkbook = excelappworkbooks[1];
            excelapp.DisplayAlerts = true;
            await Task.Run(() => AsyncExcel(dataGridViews));
            excelapp.Visible = true;
            //excelapp.Quit();
        }
        private void UpdateCombos()
        {
            cmbEdu.Text = cmbEdu.Items[0].ToString();
            cmbReg.Text = cmbReg.Items[0].ToString();
            cmbCur.Text = cmbCur.Items[0].ToString();
            cmbEduProf.Text = cmbEduProf.Items[0].ToString();
            cmbInd.Text = cmbInd.Items[0].ToString();
            cmbEmpl.Text = cmbEmpl.Items[0].ToString();
            cmbSch.Text = cmbSch.Items[0].ToString();
            cmbLoc.Text = cmbLoc.Items[0].ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDataSet7.GetCompanyProf". При необходимости она может быть перемещена или удалена.
            this.getCompanyProfTableAdapter.Fill(this.CompProfDataSet.GetCompanyProf);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDataSet6.GetEmployeeProf". При необходимости она может быть перемещена или удалена.
            this.getEmployeeProfTableAdapter.Fill(this.EmpProfDataSet.GetEmployeeProf);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDataSet5.GetCompany". При необходимости она может быть перемещена или удалена.
            this.getCompanyTableAdapter.Fill(this.CompDataSet.GetCompany);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDataSet4.GetCompany". При необходимости она может быть перемещена или удалена.
            this.getCompanyTableAdapter.Fill(this.CompDataSet.GetCompany);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDataSet3.GetProfession". При необходимости она может быть перемещена или удалена.
            this.getProfessionTableAdapter.Fill(this.ProfDataSet.GetProfession);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDataSet1.GetEmployee". При необходимости она может быть перемещена или удалена.
            this.getEmployeeTableAdapter.Fill(this.employeesDataSet1.GetEmployee);
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            sqlDataEmp.Update(employeesDataSet1);
            sqlDataProf.Update(ProfDataSet);
            sqlDataComp.Update(CompDataSet);
            sqlDataEmpProf.Update(EmpProfDataSet);
            sqlDataCompProf.Update(CompProfDataSet);
            sqlDataS1.Update(employeesDataSet8);
            sqlDataS2.Update(employeesDataSet10); 
        }

        public DataRow GetCurrentRow(DataGridView dg) {
            CurrencyManager cm = (CurrencyManager)dg.BindingContext[dg.DataSource, dg.DataMember];
            if (cm.Count == 0) { return null; }
            DataRowView drv = (DataRowView)cm.Current;
            return drv.Row;
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection1.Open();
                switch (Convert.ToInt32(tbcDB.SelectedTab.Tag))
                {
                    case 0:
                        {
                            sqlInsertCommand1.Parameters["@id"].Value = Convert.ToInt32(mtbPassport.Text);
                            sqlInsertCommand1.Parameters["@first_name"].Value = txbName.Text;
                            sqlInsertCommand1.Parameters["@second_name"].Value = txbS_name.Text;
                            sqlInsertCommand1.Parameters["@last_name"].Value = txbL_name.Text;
                            sqlInsertCommand1.Parameters["@educationEMP"].Value = cmbEdu.Text;
                            sqlInsertCommand1.Parameters["@region"].Value = cmbReg.Text;
                            sqlInsertCommand1.ExecuteNonQuery();
                            this.getEmployeeTableAdapter.Fill(this.employeesDataSet1.GetEmployee);
                        }
                        break;
                    case 1:
                        {
                            sqlInsertCommand2.Parameters["@SalaryTotal"].Value = (int)nudSal.Value;
                            sqlInsertCommand2.Parameters["@Currency"].Value = cmbCur.Text;
                            sqlInsertCommand2.Parameters["@Industry"].Value = cmbInd.Text;
                            sqlInsertCommand2.Parameters["@JobName"].Value = txbJobName.Text;
                            sqlInsertCommand2.Parameters["@Education"].Value = cmbEduProf.Text;
                            sqlInsertCommand2.ExecuteNonQuery();
                            this.getProfessionTableAdapter.Fill(this.ProfDataSet.GetProfession);
                        }
                        break;
                    case 2:
                        {
                            sqlInsertCommand3.Parameters["@CompanyEmail"].Value = txbMail.Text;
                            sqlInsertCommand3.Parameters["@CompanyName"].Value = txbCompName.Text;
                            sqlInsertCommand3.Parameters["@CompanyPhone"].Value = mtbPhone.Text;
                            sqlInsertCommand3.Parameters["@CompanySite"].Value = txbSite.Text;
                            if (sqlInsertCommand3.ExecuteNonQuery() != 1)
                            {
                                lblErrorComp.Text = "Такой сайт уже существует";
                            }
                            this.getCompanyTableAdapter.Fill(this.CompDataSet.GetCompany);
                            lblErrorComp.Text = "";
                        }
                        break;
                    case 3:
                        {
                            sqlInsertCommand4.Parameters["@Employee_id"].Value =  Convert.ToInt32(cmbEmp.SelectedValue.ToString());
                            sqlInsertCommand4.Parameters["@id"].Value = Convert.ToInt32(cmbProf.SelectedValue.ToString());
                            sqlInsertCommand4.ExecuteNonQuery();
                            this.getEmployeeProfTableAdapter.Fill(this.EmpProfDataSet.GetEmployeeProf);
                        }
                        break;
                    case 4:
                        {
                            sqlInsertCommand5.Parameters["@idProf"].Value = Convert.ToInt32(cmpProf.SelectedValue.ToString());
                            sqlInsertCommand5.Parameters["@idComp"].Value = Convert.ToInt32(cmdComp.SelectedValue.ToString());
                            sqlInsertCommand5.Parameters["@Salary"].Value = (int)numSalComp.Value;
                            sqlInsertCommand5.Parameters["@Schedule"].Value = cmbSch.Text;
                            sqlInsertCommand5.Parameters["@Employment"].Value = cmbEmpl.Text;
                            sqlInsertCommand5.Parameters["@Location"].Value = cmbLoc.Text;
                            sqlInsertCommand5.ExecuteNonQuery();
                            this.getCompanyProfTableAdapter.Fill(this.CompProfDataSet.GetCompanyProf);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sqlConnection1.Close();
            }
        }

        private void tsbDel_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection1.Open();
                switch (Convert.ToInt32(tbcDB.SelectedTab.Tag))
                {
                    case 0:
                        {
                            this.getEmployeeTableAdapter.Fill(this.employeesDataSet1.GetEmployee);
                            DataRow row = GetCurrentRow(dgvEmployee);
                            int Id = (int)row["id"];
                            sqlDeleteCommand1.Parameters["@id"].Value = Id;
                            sqlDeleteCommand1.ExecuteNonQuery();
                            this.getEmployeeTableAdapter.Fill(this.employeesDataSet1.GetEmployee);
                        }
                        break;
                    case 1:
                        {
                            DataRow row = GetCurrentRow(dgvProf);
                            int Id = (int)row["id"];
                            sqlDeleteCommand2.Parameters["@idProf"].Value = Id;
                            sqlDeleteCommand2.ExecuteNonQuery();
                            this.getProfessionTableAdapter.Fill(this.ProfDataSet.GetProfession);
                        }
                        break;
                    case 2:
                        {
                            DataRow row = GetCurrentRow(dgvComp);
                            int Id = (int)row["idCompany"];
                            sqlDeleteCommand3.Parameters["@CompId"].Value = Id;
                            sqlDeleteCommand3.ExecuteNonQuery();
                            this.getCompanyTableAdapter.Fill(this.CompDataSet.GetCompany);
                        }
                        break;
                    case 3:
                        {
                            DataRow row = GetCurrentRow(dgvEmpProf);
                            int Id = (int)row["id"];
                            int IdProf = (int)row["Profession_id"];
                            sqlDeleteCommand4.Parameters["@id"].Value = Id;
                            sqlDeleteCommand4.Parameters["@idProf"].Value = IdProf;
                            sqlDeleteCommand4.ExecuteNonQuery();
                            this.getEmployeeProfTableAdapter.Fill(this.EmpProfDataSet.GetEmployeeProf);
                        }
                        break;
                    case 4:
                        {
                            DataRow row = GetCurrentRow(dgvCompProf);
                            int Id = (int)row["id"];
                            sqlDeleteCommand5.Parameters["@id"].Value = Id;
                            sqlDeleteCommand5.ExecuteNonQuery();
                            this.getCompanyProfTableAdapter.Fill(this.CompProfDataSet.GetCompanyProf);
                        }
                        break;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sqlConnection1.Close();
            }
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection1.Open();
                switch (Convert.ToInt32(tbcDB.SelectedTab.Tag))
                {
                    case 0:
                        {
                            mtbPassport.Enabled = false;
                            DataRow row = GetCurrentRow(dgvEmployee);
                            mtbPassport.Text = row["id"].ToString();
                            txbName.Text = row["first_name"].ToString();
                            txbS_name.Text = row["second_name"].ToString();
                            txbL_name.Text = row["last_name"].ToString();
                            cmbEdu.Text = row["education"].ToString();
                            cmbReg.Text = row["region"].ToString();
                        }
                        break;
                    case 1:
                        {
                            DataRow row = GetCurrentRow(dgvProf);
                            cmbInd.Text = row["Industry"].ToString();
                            cmbEduProf.Text = row["Education"].ToString();
                            cmbCur.Text = row["Education"].ToString();
                            nudSal.Value = (int)row["SalaryTotal"];
                            txbJobName.Text = row["JobName"].ToString();
                        }
                        break;
                    case 2:
                        {
                            DataRow row = GetCurrentRow(dgvComp);
                            txbCompName.Text = row["CompanyName"].ToString();
                            txbMail.Text = row["CompanyEmail"].ToString();
                            txbSite.Text = row["CompanySite"].ToString();
                            mtbPhone.Text = row["CompanyPhone"].ToString();
                        }
                        break;
                    case 3:
                        {
                            DataRow row = GetCurrentRow(dgvEmpProf);
                            cmbEmp.SelectedValue =  Convert.ToInt32(row["id"].ToString());
                            cmbProf.SelectedValue = Convert.ToInt32(row["Profession_id"].ToString());
                            cmbEmp.Enabled = false;
                        }
                        break;
                    case 4:
                        {
                            DataRow row = GetCurrentRow(dgvCompProf);
                            cmdComp.SelectedValue = Convert.ToInt32(row["Company_idCompany"].ToString());
                            cmpProf.SelectedValue = Convert.ToInt32(row["Profession_id"].ToString());
                            numSalComp.Value = (int)row["Salary"];
                            cmbLoc.Text = row["Location"].ToString();
                            cmbSch.Text = row["Schedule"].ToString();
                            cmbEmpl.Text = row["Employment"].ToString();

                        }
                        break;

                }
                tsbUpd.Enabled = true;
                tsbSearch.Enabled = false;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sqlConnection1.Close();
            }
        }

        private void tsbUpd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection1.Open();
                switch (Convert.ToInt32(tbcDB.SelectedTab.Tag))
                {
                    case 0:
                        {                         
                            DataRow row = GetCurrentRow(dgvEmployee);
                            int Id = (int)row["id"];
                            sqlUpdateCommand1.Parameters["@id"].Value = Convert.ToInt32(mtbPassport.Text);
                            sqlUpdateCommand1.Parameters["@first_name"].Value = txbName.Text;
                            sqlUpdateCommand1.Parameters["@second_name"].Value = txbS_name.Text;
                            sqlUpdateCommand1.Parameters["@last_name"].Value = txbL_name.Text;
                            sqlUpdateCommand1.Parameters["@education"].Value = cmbEdu.Text;
                            sqlUpdateCommand1.Parameters["@region"].Value = cmbReg.Text;
                            sqlUpdateCommand1.ExecuteNonQuery();
                            mtbPassport.Enabled = true;
                            mtbPassport.Clear();
                            txbName.Clear();
                            txbS_name.Clear();
                            txbL_name.Clear();
                            mtbPassport.Enabled = true;
                            this.getEmployeeTableAdapter.Fill(this.employeesDataSet1.GetEmployee);
                        }
                        break;
                    case 1:
                        {
                            DataRow row = GetCurrentRow(dgvProf);
                            int Id = (int)row["id"];
                            sqlUpdateCommand2.Parameters["@id"].Value = Id;
                            sqlUpdateCommand2.Parameters["@SalaryTotal"].Value = (int)nudSal.Value;
                            sqlUpdateCommand2.Parameters["@Currency"].Value = cmbCur.Text;
                            sqlUpdateCommand2.Parameters["@Industry"].Value = cmbInd.Text;
                            sqlUpdateCommand2.Parameters["@JobName"].Value = txbJobName.Text;
                            sqlUpdateCommand2.Parameters["@Education"].Value = cmbEduProf.Text;
                            sqlUpdateCommand2.ExecuteNonQuery();
                            txbJobName.Clear();
                            this.getProfessionTableAdapter.Fill(this.ProfDataSet.GetProfession);
                        }
                        break;
                    case 2:
                        {
                            DataRow row = GetCurrentRow(dgvComp);
                            int Id = (int)row["idCompany"];
                            sqlUpdateCommand3.Parameters["@id"].Value = Id;
                            sqlUpdateCommand3.Parameters["@CompanyEmail"].Value = txbMail.Text;
                            sqlUpdateCommand3.Parameters["@CompanyName"].Value = txbCompName.Text;
                            sqlUpdateCommand3.Parameters["@CompanyPhone"].Value = mtbPhone.Text;
                            sqlUpdateCommand3.Parameters["@CompanySite"].Value = txbSite.Text;
                            sqlUpdateCommand3.ExecuteNonQuery();
                            txbCompName.Clear();
                            txbMail.Clear();
                            txbSite.Clear();
                            mtbPhone.Clear();
                            this.getCompanyTableAdapter.Fill(this.CompDataSet.GetCompany);
                        }
                        break;
                    case 3:
                        {
                            DataRow row = GetCurrentRow(dgvEmpProf);
                            int Id = (int)row["id"];
                            int IdProf = (int)row["Profession_id"];
                            sqlUpdateCommand4.Parameters["@id"].Value = Id;
                            sqlUpdateCommand4.Parameters["@OldIdProf"].Value = IdProf;
                            sqlUpdateCommand4.Parameters["@idProf"].Value = Convert.ToInt32(cmbProf.SelectedValue.ToString());
                            sqlUpdateCommand4.ExecuteNonQuery();
                            this.getEmployeeProfTableAdapter.Fill(this.EmpProfDataSet.GetEmployeeProf);
                            cmbEmp.Enabled = true;
                        }
                        break;
                    case 4:
                        {
                            DataRow row = GetCurrentRow(dgvCompProf);
                            int Id = (int)row["id"];
                            sqlUpdateCommand5.Parameters["@id"].Value = Id;
                            sqlUpdateCommand5.Parameters["@Salary"].Value = (int)numSalComp.Value;
                            sqlUpdateCommand5.Parameters["@Schedule"].Value = cmbSch.Text;
                            sqlUpdateCommand5.Parameters["@Employment"].Value = cmbEmpl.Text;
                            sqlUpdateCommand5.Parameters["@Location"].Value = cmbLoc.Text;
                            sqlUpdateCommand5.ExecuteNonQuery();
                            this.getCompanyProfTableAdapter.Fill(this.CompProfDataSet.GetCompanyProf);
                        }
                        break;
                }
                tsbSearch.Enabled = true;
                tsbUpd.Enabled = false;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sqlConnection1.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                S1();
            }
            catch(Exception ex)
            {

            }
        }
        private void S1()
        {
            try
            {
                lblErrorS1.Text = "";
                int id = 0;
                try
                {
                    id = Convert.ToInt32(cmbS1.SelectedValue.ToString());
                }
                catch(Exception ex1)
                {
                    return;
                }
                if (searchFromProfTableAdapter.Fill(employeesDataSet9.SearchFromProf, id) == null)
                {
                    lblErrorS1.Text = "По данному запросу нет совпадений";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            S2();
        }
        void S2()
        {
            try
            {
                int id = Convert.ToInt32(cmbS2.SelectedValue.ToString());
                int count = (int)nudCount.Value;
                search2TableAdapter.Fill(employeesDataSet11.Search2, count, id);
            }
            catch (Exception ex)
            {

            }
        }

        private void tbcDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(tbcDB.SelectedTab.Tag) == 5)
            {
                S1();
            }
        }

        private void tsbSaveExcel_Click(object sender, EventArgs e)
        {
            tslReport.Text = "Сохраняю файл...";
            Excel();
            tslReport.Text = "Файл сохранен";
        }
    }
}
