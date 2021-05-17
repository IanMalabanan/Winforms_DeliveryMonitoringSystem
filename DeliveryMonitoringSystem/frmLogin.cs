using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClsLibBusiness;

namespace DeliveryMonitoringSystem
{
    public partial class frmLogin : Form
    {
        BusUsers dbuser = new BusUsers();

        public string empid = string.Empty, fullname_fnamefirst = string.Empty, deptcode = string.Empty, sectcode = string.Empty;


        private void Login()
        {
            try
            {
                DataTable dt;

                dbuser = new BusUsers();

                if (dbuser.UserLoginDT(textBox1.Text, textBox2.Text).Rows.Count == 0)
                {
                    MessageBox.Show("No Records Found");
                }
                else
                {
                    foreach (DataRow dr in dbuser.UserLoginDT(textBox1.Text, textBox2.Text).Rows)
                    {
                        empid = dr["empid"].ToString();
                    }

                    dt = dbuser.SKPI_GetAllEmployeesByEmpIDDT(empid);

                    foreach (DataRow row in dt.Rows)
                    {
                        deptcode = row["Dept_Code"].ToString();
                                                
                        sectcode = row["Sect_Code"].ToString();
                                                
                        fullname_fnamefirst = row["FullName_FnameFirst"].ToString();
                    }


                    if (deptcode == "S" && sectcode == "01")
                    {
                        frmDeliveryMonitoring frm = new frmDeliveryMonitoring();

                        this.Hide();

                        frm.lblHeader.Text = ".:: Sales Delivery Monitoring System";

                        frm.fullname_fnamefirst = fullname_fnamefirst;

                        //frm.button10.Visible = true;
                        
                        frm.deptcode = deptcode;

                        frm.sectcode = sectcode;

                        frm.Show();
                    }
                    else if (deptcode == "I" && sectcode == "01")
                    {
                        frmDeliveryMonitoring frm = new frmDeliveryMonitoring();

                        this.Hide();

                        frm.lblHeader.Text = ".:: Sales Delivery Monitoring System";

                        frm.fullname_fnamefirst = fullname_fnamefirst;

                        //frm.button10.Visible = true;

                        frm.deptcode = deptcode;

                        frm.sectcode = sectcode;

                        frm.Show();
                    }
                    else
                    {
                        frmDeliveryMonitoring frm = new frmDeliveryMonitoring();

                        this.Hide();

                        frm.lblHeader.Text = ".:: PMC Delivery Monitoring System";

                        frm.fullname_fnamefirst = fullname_fnamefirst;

                       
                        frm.deptcode = deptcode;

                        frm.sectcode = sectcode;

                        frm.Show();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Login();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
