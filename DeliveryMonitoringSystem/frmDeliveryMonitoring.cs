using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClsLibConnection;
using ClsLibBusiness;


namespace DeliveryMonitoringSystem
{
    public partial class frmDeliveryMonitoring : Form
    {
        BusDeliverySchedule dbsched = new BusDeliverySchedule();

        BusDeliverySchedule _sched = new BusDeliverySchedule();

        BusPOMonitoring _dbpo = new BusPOMonitoring();

        BusPOMonitoring _pomonitoring = new BusPOMonitoring();

        BusDeliveryMonitoring _dbdm = new BusDeliveryMonitoring();

        BusDeliveryMonitoring _dm = new BusDeliveryMonitoring();


        public string empid = string.Empty, fullname_fnamefirst = string.Empty, deptcode = string.Empty, sectcode = string.Empty;

        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

        public static string dateremarks = string.Empty, _PartID = string.Empty, _PONo = string.Empty, _dmremarks = string.Empty;


        public frmDeliveryMonitoring()
        {
            InitializeComponent();

            GenerateYear();

            GenerateMonth();
        }


       
        #region DeliverySchedule

        private Boolean _ValidateDeliverySched()
        {
            if (tbPartCode.Text.Length == 0)
            {
                MessageBox.Show("Part Code is required.");

                return false;
            }

            //if (cboDeliverySchedMonth.SelectedValue.ToString() == string.Empty)
            //{
            //    MessageBox.Show("Scheduled month is required.");

            //    return false;
            //}

            //if (cboDeliverySchedYear.SelectedItem.ToString() == string.Empty)
            //{
            //    MessageBox.Show("Scheduled year is required.");

            //    return false;
            //}

            return true;
        }

        private Boolean GenerateDeliverySchedule()
        {
            dbsched = new BusDeliverySchedule();

            if (dbsched.GetDeliveryScheduleByMonthandYearDT(tbPartCode.Text, Convert.ToInt32(cboDeliverySchedMonth.SelectedValue.ToString())
                    , Convert.ToInt32(cboDeliverySchedYear.SelectedItem.ToString())).Rows.Count == 0)
            {
                MessageBox.Show("All dates from this year has not been created. Dates must be created first.");

                return false;
            }
            else
            {
                Boolean _validate = false;

                _validate = _ValidateDeliverySched();


                if (!_validate)
                {
                    return false;
                }

                _sched = new BusDeliverySchedule();

                _sched.PartID = tbPartCode.Text;

                //_sched.DeliveryDate = Convert.ToDateTime(tbDateRequired.Text);

                _sched.DateMonth = Convert.ToInt32(cboDeliverySchedMonth.SelectedValue.ToString());

                _sched.DateYear = Convert.ToInt32(cboDeliverySchedYear.SelectedItem.ToString());

                _sched.RefreshedDeliverySchedule();


                foreach (DataRow dr in dbsched.GetDeliveryScheduleByMonthandYearDT(tbPartCode.Text
                    , Convert.ToInt32(cboDeliverySchedMonth.SelectedValue.ToString())
                    , Convert.ToInt32(cboDeliverySchedYear.SelectedItem.ToString())
                    ).Rows)
                {
                    _sched = new BusDeliverySchedule();

                    _sched.PartID = tbPartCode.Text;

                    _sched.DeliveryDate = Convert.ToDateTime(dr["DeliveryDate"].ToString());

                    _sched.UpdateDeliveryData();
                }

                //GetDeliveryScheduleByYear();

                GetDeliveryScheduleByMonthandYear();

                return true;
            }
        }

        private Boolean GenerateDeliveryScheduleThisYear()
        {
            dbsched = new BusDeliverySchedule();

            if (dbsched.GetDeliveryScheduleByThisYearDT(tbPartCode.Text).Rows.Count == 0)
            {
                MessageBox.Show("All dates from this year has not been created. Dates must be created first.");

                return false;
            }
            else
            {
                Boolean _validate = false;

                _validate = _ValidateDeliverySched();


                if (!_validate)
                {
                    return false;
                }

                _sched = new BusDeliverySchedule();

                _sched.PartID = tbPartCode.Text;

                _sched.RefreshedDeliveryScheduleThisYear();


                foreach (DataRow dr in dbsched.GetDeliveryScheduleByThisYearDT(tbPartCode.Text).Rows)
                {
                    _sched = new BusDeliverySchedule();

                    _sched.PartID = tbPartCode.Text;

                    _sched.DeliveryDate = Convert.ToDateTime(dr["DeliveryDate"].ToString());

                    _sched.UpdateDeliveryData();
                }

                //GetDeliveryScheduleByYear();

                //GetDeliveryScheduleByMonthandYear();

                GetDeliveryScheduleByThisYear();

                return true;
            }
        }

        private Boolean GenerateDeliveryScheduleByYear()
        {
            dbsched = new BusDeliverySchedule();

            if (dbsched.GetDeliveryScheduleByYearDT(tbPartCode.Text, Convert.ToInt32(cboDSchedByYear.SelectedItem.ToString())).Rows.Count == 0)
            {
                MessageBox.Show("All dates from this year has not been created. Dates must be created first.");

                return false;
            }
            else
            {
                Boolean _validate = false;

                _validate = _ValidateDeliverySched();


                if (!_validate)
                {
                    return false;
                }

                _sched = new BusDeliverySchedule();

                _sched.PartID = tbPartCode.Text;

                _sched.DateYear = Convert.ToInt32(cboDSchedByYear.SelectedItem.ToString());

                _sched.RefreshedDeliveryScheduleByYear();


                foreach (DataRow dr in dbsched.GetDeliveryScheduleByYearDT(tbPartCode.Text, Convert.ToInt32(cboDSchedByYear.SelectedItem.ToString())).Rows)
                {
                    _sched = new BusDeliverySchedule();

                    _sched.PartID = tbPartCode.Text;

                    _sched.DeliveryDate = Convert.ToDateTime(dr["DeliveryDate"].ToString());

                    _sched.UpdateDeliveryData();
                }

                GetDeliveryScheduleByYear();

                //GetDeliveryScheduleByMonthandYear();

                //GetDeliveryScheduleByThisYear();

                return true;
            }
        }

        private Boolean GenerateSchedule()
        {
            string minyear = string.Empty;

            dbsched = new BusDeliverySchedule();

            foreach (DataRow dr in dbsched.SOMS_DeliveryMonitoring_GetMinimumYearDT(tbPartCode.Text).Rows)
            {
                minyear = dr["MinYear"].ToString().TrimEnd();
            }

            _sched = new BusDeliverySchedule();

            _sched.PartID = tbPartCode.Text;

            _sched.CusID = Convert.ToInt32(cboCustomer.SelectedValue.ToString());

            _sched.DateYear = Convert.ToInt32(minyear);

            _sched.SOMS_CreateSchedule();


            BusDeliverySchedule refreshSched = new BusDeliverySchedule();

            refreshSched.PartID = tbPartCode.Text;

            refreshSched.SOMS_RefreshedDeliverySchedule();


            return true;
        }

        private Boolean UpdateQtyRequired()
        {
            dbsched = new BusDeliverySchedule();

            foreach (DataRow dr in dbsched.SOMS_DeliveryMonitoring_GetQtyRequiredDT(tbPartCode.Text).Rows)
            {
                _sched = new BusDeliverySchedule();

                _sched.PartID = tbPartCode.Text;

                _sched.DeliveryDate = Convert.ToDateTime(dr["Delivery_Date_Planned"]);

                _sched.DeliverySched_Qty = Convert.ToInt32(dr["Qty_Reqd"].ToString());

                _sched.SOMS_UpdateQtyRequired();
            }

            //MessageBox.Show(dbsched.SOMS_DeliveryMonitoring_GetQtyRequiredDT(tbPartCode.Text).Rows.Count);

            return true;
        }

        private Boolean UpdateDeliveredQty()
        {
            dbsched = new BusDeliverySchedule();

            foreach (DataRow dr in dbsched.SOMS_DeliveryMonitoring_GetTotalDeliveredDT(tbPartCode.Text).Rows)
            {
                _sched = new BusDeliverySchedule();

                _sched.PartID = tbPartCode.Text;

                _sched.DeliveryDate = Convert.ToDateTime(dr["LastUpdate"]);

                _sched.ActDelivery_Qty = Convert.ToInt32(dr["TotalDelivered"].ToString());

                _sched.SOMS_UpdateDeliverySchedule();
            }

            return true;
        }

        private void GenerateSched()
        {
            Boolean r1, r2, r3;

            r1 = GenerateSchedule();

            r2 = UpdateQtyRequired();

            r3 = UpdateDeliveredQty();
        }

        private Boolean _ValidateReportFields()
        {
            if (cboCustomer.SelectedValue == null || cboCustomer.SelectedValue.ToString() == string.Empty)
            {
                MessageBox.Show("Select Customer");
                return false;
            }

            if (cboDeliverySchedMonth.SelectedValue == null || cboDeliverySchedMonth.SelectedValue.ToString() == string.Empty)
            {
                MessageBox.Show("Select Month");
                return false;
            }


            if (cboDeliverySchedYear.SelectedItem == null || cboDeliverySchedYear.SelectedItem.ToString() == string.Empty)
            {
                MessageBox.Show("Select Year");
                return false;
            }

            return true;
        }

        private Boolean GenerateSchedReport()
        {
            Boolean res = false;

            res = _ValidateReportFields();

            if (!res)
            {
                return false;
            }

            try
            {
                frmPrintReport frm = new frmPrintReport();

                CrystalDecisions.CrystalReports.Engine.ReportDocument objReport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

                CrystalDecisions.Shared.TableLogOnInfos crtableLogoninfos = new CrystalDecisions.Shared.TableLogOnInfos();

                CrystalDecisions.Shared.TableLogOnInfo ConInfo = new CrystalDecisions.Shared.TableLogOnInfo();

                CrystalDecisions.Shared.ConnectionInfo crConnectionInfo = new CrystalDecisions.Shared.ConnectionInfo();

                CrystalDecisions.CrystalReports.Engine.Tables CrTables;

                CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinitions crParameterFieldDefinitions;

                CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition crParameterFieldDefinition;

                CrystalDecisions.Shared.ParameterValues crParameterValues = new CrystalDecisions.Shared.ParameterValues();

                CrystalDecisions.Shared.ParameterDiscreteValue crParameterDiscreteValue = new CrystalDecisions.Shared.ParameterDiscreteValue();


                objReport.Load(ClsConfig.PrintMonthlySchedule);

                //tbPartCode.Text, Convert.ToInt32(cboDeliverySchedMonth.SelectedValue.ToString())
                //    , Convert.ToInt32(cboDeliverySchedYear.SelectedItem.ToString())

                crParameterDiscreteValue.Value = cboDeliverySchedMonth.SelectedValue.ToString();
                crParameterFieldDefinitions = objReport.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["@month"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crParameterDiscreteValue.Value = cboDeliverySchedYear.SelectedItem.ToString();
                crParameterFieldDefinitions = objReport.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["@year"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crParameterDiscreteValue.Value = cboCustomer.SelectedValue.ToString();
                crParameterFieldDefinitions = objReport.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["@Cus_ID"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);



                string sUserID = ClsConfig.User;
                string sPassword = ClsConfig.Password;
                string sServerName = ClsConfig.Server;
                string sDatabaseName = ClsConfig.Database;

                crConnectionInfo.ServerName = sServerName;
                crConnectionInfo.DatabaseName = sDatabaseName;
                //crConnectionInfo.IntegratedSecurity = true;
                crConnectionInfo.UserID = sUserID;
                crConnectionInfo.Password = sPassword;

                CrTables = objReport.Database.Tables;

                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    ConInfo = CrTable.LogOnInfo;
                    ConInfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(ConInfo);
                }

                frm.crystalReportViewer1.ReportSource = objReport;
                frm.crystalReportViewer1.Zoom(100);
                frm.crystalReportViewer1.Refresh();
            }
            catch
            {
                MessageBox.Show("Report File Does Not Exists!");
            }


            return true;
        }


        private void GenerateDates()
        {
            _sched = new BusDeliverySchedule();

            _sched.PartID = tbPartCode.Text;

            _sched.CreateDeliverySchedule();

            MessageBox.Show("Dates has been generated");
        }

        private void GetDeliveryScheduleByYear()
        {
            dbsched = new BusDeliverySchedule();

            int index = 0;

            dgvDeliverySchedule.Rows.Clear();

            if (dbsched.GetDeliveryScheduleByYearDT(tbPartCode.Text, Convert.ToInt32(cboDSchedByYear.SelectedItem.ToString())).Rows.Count == 0)
            {
                MessageBox.Show("No Records Found");
            }
            else
            {
                foreach (DataRow dr in dbsched.GetDeliveryScheduleByYearDT(tbPartCode.Text, Convert.ToInt32(cboDSchedByYear.SelectedItem.ToString())).Rows)
                {
                    dgvDeliverySchedule.Rows.Insert(index, dr["schedid"], dr["DeliveryDate"], dr["NameOfDay"], dr["DeliverySched_Qty"], dr["DeliverySched_Acc"]
                        , dr["ActDelivery_Qty"], dr["ActDelivery_Acc"], dr["DeliveryBal"]);
                    index++;
                }
            }
        }

        private void GetDeliveryScheduleByThisYear()
        {
            dbsched = new BusDeliverySchedule();

            int index = 0;

            dgvDeliverySchedule.Rows.Clear();

            if (dbsched.GetDeliveryScheduleByThisYearDT(tbPartCode.Text).Rows.Count == 0)
            {
                MessageBox.Show("No Records Found");
            }
            else
            {
                foreach (DataRow dr in dbsched.GetDeliveryScheduleByThisYearDT(tbPartCode.Text).Rows)
                {
                    dgvDeliverySchedule.Rows.Insert(index, dr["schedid"], dr["DeliveryDate"], dr["NameOfDay"], dr["DeliverySched_Qty"], dr["DeliverySched_Acc"]
                        , dr["ActDelivery_Qty"], dr["ActDelivery_Acc"], dr["DeliveryBal"]);
                    index++;
                }
            }
        }

        private void GetDeliveryScheduleByMonthandYear()
        {
            dbsched = new BusDeliverySchedule();

            int index = 0;

            dgvDeliverySchedule.Rows.Clear();

            if (dbsched.GetDeliveryScheduleByMonthandYearDT(tbPartCode.Text
                , Convert.ToInt32(cboDeliverySchedMonth.SelectedValue.ToString())
                , Convert.ToInt32(cboDeliverySchedYear.SelectedItem.ToString())
                ).Rows.Count == 0)
            {
                MessageBox.Show("No Records Found");
            }
            else
            {
                foreach (DataRow dr in dbsched.GetDeliveryScheduleByMonthandYearDT(tbPartCode.Text
                , Convert.ToInt32(cboDeliverySchedMonth.SelectedValue.ToString())
                , Convert.ToInt32(cboDeliverySchedYear.SelectedItem.ToString())
                ).Rows)
                {
                    dgvDeliverySchedule.Rows.Insert(index, dr["schedid"], dr["DeliveryDate"], dr["NameOfDay"], dr["DeliverySched_Qty"], dr["DeliverySched_Acc"]
                        , dr["ActDelivery_Qty"], dr["ActDelivery_Acc"], dr["DeliveryBal"]);
                    index++;
                }
            }
        }

        #endregion

        private void GenerateMonth()
        {
            dbsched = new BusDeliverySchedule();

            cboDeliverySchedMonth.DisplayMember = "Month_Name";

            cboDeliverySchedMonth.ValueMember = "Month_Number";

            cboDeliverySchedMonth.DataSource = dbsched.GenerateMonthDT();
        }

        private void GenerateYear()
        {
            int i = 0;

            for (i = DateTime.Now.Year; i >= 2000; i--)
            {
                
                cboDeliverySchedYear.Items.Add(i.ToString());

                cboDSchedByYear.Items.Add(i.ToString());
            }

            cboDeliverySchedYear.SelectedIndex = 0;

            cboDSchedByYear.SelectedIndex = 0;
        }

        private void LoadCustomers()
        {
            _dbpo = new BusPOMonitoring();

            cboCustomer.DisplayMember = "ModifiedCustomer";

            cboCustomer.ValueMember = "Cust_ID";

            cboCustomer.DataSource = _dbpo.GetAllCustomersDT();
        }

        private void AutoSuggestPartCode()
        {
            DataTable dt = new DataTable();

            _dbpo = new BusPOMonitoring();

            dt = _dbpo.GetPartsByCustomerDT(Convert.ToInt32(cboCustomer.SelectedValue.ToString()));

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    coll.Add(dt.Rows[i]["Part_ID"].ToString());
                }
            }
            else
            {
            }

            tbPartCode.AutoCompleteMode = AutoCompleteMode.Suggest;

            tbPartCode.AutoCompleteSource = AutoCompleteSource.CustomSource;

            tbPartCode.AutoCompleteCustomSource = coll;
        }

        private void GetPartName()
        {
            _dbpo = new BusPOMonitoring();

            if (_dbpo.GetPartNameByPartIDDT(Convert.ToInt32(cboCustomer.SelectedValue.ToString()), tbPartCode.Text).Rows.Count == 0)
            {
                MessageBox.Show("No Part Name Found");
            }
            else
            {
                foreach (DataRow dr in _dbpo.GetPartNameByPartIDDT(Convert.ToInt32(cboCustomer.SelectedValue.ToString()), tbPartCode.Text).Rows)
                {
                    tbPartName.Text = dr["Part_Description"].ToString();
                }
            }
        }

        private void FormatGridViewDesign(DataGridView dgv)
        {
            //dataGridView1.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 191, 191);//Color.DarkTurquoise;

            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;//Color.WhiteSmoke;

            dgv.DefaultCellStyle.ForeColor = Color.Black;

            dgv.BackgroundColor = Color.White;


            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            Padding newPadding = new Padding(0, 10, 0, 10);

            dgv.ColumnHeadersDefaultCellStyle.Padding = newPadding;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);//0, 136, 204);//0, 174, 219);

            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11);

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void ClearFields(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)

                    if (((TextBox)c).Text != string.Empty)

                        ((TextBox)c).Clear();

                    else

                        ClearFields(c);

                //if (c is MetroFramework.Controls.MetroComboBox)
                //{
                //    ((MetroFramework.Controls.MetroComboBox)c).DataSource = null;

                //    ((MetroFramework.Controls.MetroComboBox)c).Text = "Select";
                //}
            }
        }

        private void GetTotalDelivery()
        {
            long sum = 0;

            for (int i = 0; i < dgvDeliverySchedule.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvDeliverySchedule.Rows[i].Cells[5].Value);
            }

            //long i = 3280831231231231230;

            string ss = sum.ToString("N3").Replace(".00", "");

            tbTotal.Text = ss.Remove(ss.Length - 1);
        }





        private void frmDeliveryMonitoring_Load(object sender, EventArgs e)
        {
            LoadCustomers();

            FormatGridViewDesign(dgvDeliverySchedule);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbPartCode.Text.Length == 0)
            {
                MessageBox.Show("Select Part First");
            }
            else
            {
                try
                {
                    GenerateSched();

                    Boolean res;

                    res = GenerateDeliverySchedule();

                    if (dgvDeliverySchedule.Rows.Count > 0)
                    {
                        GetTotalDelivery();
                    }
                }
                catch
                {
                    MessageBox.Show("No Records Found");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tbPartCode.Text.Length == 0)
            {
                MessageBox.Show("Select Part First");
            }
            else
            {
                try
                {
                    Boolean res;

                    res = GenerateDeliveryScheduleThisYear();

                    if (dgvDeliverySchedule.Rows.Count > 0)
                    {
                        GetTotalDelivery();
                    }
                }
                catch
                {
                    MessageBox.Show("No Records Found");
                }
            }
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvDeliverySchedule.Rows.Count > 0)
            {
                dgvDeliverySchedule.Rows.Clear();

                tbTotal.Clear();
            }

            AutoSuggestPartCode();

            tbPartCode.ReadOnly = false;

            tbPartCode.Clear();

            tbPartName.Clear();

            tbPartCode.Focus();
        }

        private void tbPartCode_TextChanged(object sender, EventArgs e)
        {
            if (tbPartCode.TextLength == 0)
            {
                tbPartName.Clear();
            }
        }

        private void tbPartCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (tbPartCode.TextLength == 0)
                {
                    tbPartName.Clear();
                }
                else
                {
                    GetPartName();
                }
            }
        }

        private void tbPartCode_Leave(object sender, EventArgs e)
        {
            if (tbPartCode.TextLength > 0)
            {
                GetPartName();
            }
        }

        private void tbPartCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (tbPartCode.TextLength == 0)
                {
                    tbPartName.Clear();
                }
                else
                {
                    GetPartName();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tbPartCode.TextLength == 0)
            {
                MessageBox.Show("Must select parts first.");
            }
            else
            {
                dbsched = new BusDeliverySchedule();

                if (dbsched.GetDeliveryScheduleByThisYearDT(tbPartCode.Text).Rows.Count > 0)
                {
                    MessageBox.Show("All dates for this year have already been generated.");
                }
                else
                {
                    DialogResult _result =
                        MessageBox.Show("This function will generate dates for the whole year. Do you want to proceed?", "Message"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (_result == DialogResult.Yes)
                    {
                        if (tbPartCode.TextLength == 0)
                        {
                            MessageBox.Show("Must select parts first.");
                        }
                        else
                        {
                            GenerateDates();
                        }
                    }
                }
            }
        }

        private void dgvDeliverySchedule_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDeliverySchedule.Rows.Count > 0)
            {
                foreach (DataGridViewRow Myrow in dgvDeliverySchedule.Rows)
                {
                    if (Convert.ToInt32(Myrow.Cells[7].Value) < 0)
                    {
                        Myrow.Cells[7].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        Myrow.Cells[7].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void tbDMDelivered_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void tbRevNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            //frmLogin frm = new frmLogin();

            //this.Hide();

            //frm.Show();
            Application.Exit();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (tbPartCode.Text.Length == 0)
            {
                MessageBox.Show("Must select part first");
            }
            else
            {
                try
                {
                    GenerateSched();

                    Boolean res;

                    res = GenerateDeliveryScheduleByYear();


                    if (dgvDeliverySchedule.Rows.Count > 0)
                    {
                        GetTotalDelivery();
                    }
                }
                catch
                {
                    MessageBox.Show("No Records Found");
                }
            }
        }

        private void cboDeliverySchedMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvDeliverySchedule.Rows.Count > 0)
            {
                dgvDeliverySchedule.Rows.Clear();

                tbTotal.Clear();
            }
        }

        private void cboDeliverySchedYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvDeliverySchedule.Rows.Count > 0)
            {
                dgvDeliverySchedule.Rows.Clear();

                tbTotal.Clear();
            }
        }

        private void cboDSchedByYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvDeliverySchedule.Rows.Count > 0)
            {
                dgvDeliverySchedule.Rows.Clear();

                tbTotal.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean res;

            res = GenerateSchedReport();
        }
    }
}
