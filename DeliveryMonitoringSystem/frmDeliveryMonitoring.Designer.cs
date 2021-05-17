namespace DeliveryMonitoringSystem
{
    partial class frmDeliveryMonitoring
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeliveryMonitoring));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.BunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbPartCode = new System.Windows.Forms.TextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.tbPartName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboDeliverySchedYear = new System.Windows.Forms.ComboBox();
            this.cboDeliverySchedMonth = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button19 = new System.Windows.Forms.Button();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.cboDSchedByYear = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dgvDeliverySchedule = new System.Windows.Forms.DataGridView();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmStripDeliveryMonitoring = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyDataThenInsertDeliveredQtyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSIDRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDRSIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverySchedule)).BeginInit();
            this.cmStripDeliveryMonitoring.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.BunifuImageButton1);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 40);
            this.panel1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1256, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 31);
            this.button2.TabIndex = 74;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BunifuImageButton1
            // 
            this.BunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("BunifuImageButton1.Image")));
            this.BunifuImageButton1.ImageActive = null;
            this.BunifuImageButton1.Location = new System.Drawing.Point(1289, 1);
            this.BunifuImageButton1.Name = "BunifuImageButton1";
            this.BunifuImageButton1.Size = new System.Drawing.Size(30, 31);
            this.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BunifuImageButton1.TabIndex = 69;
            this.BunifuImageButton1.TabStop = false;
            this.BunifuImageButton1.Zoom = 10;
            this.BunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeader.Location = new System.Drawing.Point(8, 8);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(285, 22);
            this.lblHeader.TabIndex = 14;
            this.lblHeader.Text = ".:: Sales Delivery Monitoring";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 40);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1321, 89);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Part Code";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.tbPartCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboCustomer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbPartName, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1315, 63);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbPartCode
            // 
            this.tbPartCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPartCode.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPartCode.Location = new System.Drawing.Point(441, 28);
            this.tbPartCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPartCode.Name = "tbPartCode";
            this.tbPartCode.Size = new System.Drawing.Size(432, 31);
            this.tbPartCode.TabIndex = 19;
            this.tbPartCode.TextChanged += new System.EventHandler(this.tbPartCode_TextChanged);
            this.tbPartCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPartCode_KeyDown);
            this.tbPartCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPartCode_KeyPress);
            this.tbPartCode.Leave += new System.EventHandler(this.tbPartCode_Leave);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(879, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(97, 24);
            this.metroLabel10.TabIndex = 18;
            this.metroLabel10.Text = "Part Name:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(441, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(91, 24);
            this.metroLabel9.TabIndex = 15;
            this.metroLabel9.Text = "Part Code:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(3, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(90, 24);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Customer:";
            // 
            // cboCustomer
            // 
            this.cboCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(5, 29);
            this.cboCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(428, 31);
            this.cboCustomer.TabIndex = 11;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // tbPartName
            // 
            this.tbPartName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPartName.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPartName.Location = new System.Drawing.Point(879, 28);
            this.tbPartName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPartName.Name = "tbPartName";
            this.tbPartName.ReadOnly = true;
            this.tbPartName.Size = new System.Drawing.Size(433, 31);
            this.tbPartName.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 129);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1321, 604);
            this.tabControl1.TabIndex = 95;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbTotal);
            this.tabPage3.Controls.Add(this.metroLabel17);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.dgvDeliverySchedule);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1313, 574);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delivery Schedule";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotal.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(1067, 128);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(243, 31);
            this.tbTotal.TabIndex = 95;
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // metroLabel17
            // 
            this.metroLabel17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel17.Location = new System.Drawing.Point(948, 130);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(116, 25);
            this.metroLabel17.TabIndex = 94;
            this.metroLabel17.Text = "Total Delivery:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1313, 124);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter Record";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Location = new System.Drawing.Point(3, 22);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1307, 98);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.metroLabel2);
            this.tabPage4.Controls.Add(this.metroLabel1);
            this.tabPage4.Controls.Add(this.cboDeliverySchedYear);
            this.tabPage4.Controls.Add(this.cboDeliverySchedMonth);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1299, 68);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "By Month and Year";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(465, 32);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 31);
            this.button3.TabIndex = 63;
            this.button3.Text = "Preview Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(353, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 62;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(5, 4);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 25);
            this.metroLabel2.TabIndex = 59;
            this.metroLabel2.Text = "Month:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(179, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 25);
            this.metroLabel1.TabIndex = 61;
            this.metroLabel1.Text = "Year:";
            // 
            // cboDeliverySchedYear
            // 
            this.cboDeliverySchedYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeliverySchedYear.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeliverySchedYear.FormattingEnabled = true;
            this.cboDeliverySchedYear.Location = new System.Drawing.Point(181, 32);
            this.cboDeliverySchedYear.Margin = new System.Windows.Forms.Padding(5);
            this.cboDeliverySchedYear.Name = "cboDeliverySchedYear";
            this.cboDeliverySchedYear.Size = new System.Drawing.Size(163, 31);
            this.cboDeliverySchedYear.TabIndex = 60;
            this.cboDeliverySchedYear.SelectedIndexChanged += new System.EventHandler(this.cboDeliverySchedYear_SelectedIndexChanged);
            // 
            // cboDeliverySchedMonth
            // 
            this.cboDeliverySchedMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeliverySchedMonth.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeliverySchedMonth.FormattingEnabled = true;
            this.cboDeliverySchedMonth.Location = new System.Drawing.Point(5, 32);
            this.cboDeliverySchedMonth.Margin = new System.Windows.Forms.Padding(5);
            this.cboDeliverySchedMonth.Name = "cboDeliverySchedMonth";
            this.cboDeliverySchedMonth.Size = new System.Drawing.Size(163, 31);
            this.cboDeliverySchedMonth.TabIndex = 58;
            this.cboDeliverySchedMonth.SelectedIndexChanged += new System.EventHandler(this.cboDeliverySchedMonth_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button19);
            this.tabPage5.Controls.Add(this.metroLabel12);
            this.tabPage5.Controls.Add(this.cboDSchedByYear);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1299, 68);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "By Year";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button19.Location = new System.Drawing.Point(178, 32);
            this.button19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(106, 31);
            this.button19.TabIndex = 65;
            this.button19.Text = "Filter";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.Location = new System.Drawing.Point(4, 4);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(49, 25);
            this.metroLabel12.TabIndex = 64;
            this.metroLabel12.Text = "Year:";
            // 
            // cboDSchedByYear
            // 
            this.cboDSchedByYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDSchedByYear.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDSchedByYear.FormattingEnabled = true;
            this.cboDSchedByYear.Location = new System.Drawing.Point(6, 32);
            this.cboDSchedByYear.Margin = new System.Windows.Forms.Padding(5);
            this.cboDSchedByYear.Name = "cboDSchedByYear";
            this.cboDSchedByYear.Size = new System.Drawing.Size(163, 31);
            this.cboDSchedByYear.TabIndex = 63;
            this.cboDSchedByYear.SelectedIndexChanged += new System.EventHandler(this.cboDSchedByYear_SelectedIndexChanged);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(1153, 38);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(154, 39);
            this.button8.TabIndex = 63;
            this.button8.Text = "Generate All Dates This Year";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(1153, 80);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(154, 31);
            this.button9.TabIndex = 64;
            this.button9.Text = "Insert All Dates This Year";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dgvDeliverySchedule
            // 
            this.dgvDeliverySchedule.AllowUserToAddRows = false;
            this.dgvDeliverySchedule.AllowUserToDeleteRows = false;
            this.dgvDeliverySchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeliverySchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeliverySchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDeliverySchedule.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDeliverySchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliverySchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column15,
            this.Column1,
            this.Column16,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDeliverySchedule.Location = new System.Drawing.Point(3, 165);
            this.dgvDeliverySchedule.Margin = new System.Windows.Forms.Padding(5);
            this.dgvDeliverySchedule.Name = "dgvDeliverySchedule";
            this.dgvDeliverySchedule.ReadOnly = true;
            this.dgvDeliverySchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliverySchedule.Size = new System.Drawing.Size(1308, 404);
            this.dgvDeliverySchedule.TabIndex = 0;
            this.dgvDeliverySchedule.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDeliverySchedule_CellFormatting);
            // 
            // Column15
            // 
            this.Column15.HeaderText = "ID";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Visible = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Format = "dd/MMM/yyyy";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Delivery Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Day";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Schedule: Quantity";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Schedule: Accumulative";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Actual: Delivery";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Actual: Accumulative";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column6.HeaderText = "Delivery Balance";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // cmStripDeliveryMonitoring
            // 
            this.cmStripDeliveryMonitoring.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmStripDeliveryMonitoring.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyDataThenInsertDeliveredQtyToolStripMenuItem,
            this.updateSIDRToolStripMenuItem,
            this.updateDRSIToolStripMenuItem});
            this.cmStripDeliveryMonitoring.Name = "cmStripDeliveryMonitoring";
            this.cmStripDeliveryMonitoring.Size = new System.Drawing.Size(305, 76);
            this.cmStripDeliveryMonitoring.Text = "Settings";
            // 
            // copyDataThenInsertDeliveredQtyToolStripMenuItem
            // 
            this.copyDataThenInsertDeliveredQtyToolStripMenuItem.Name = "copyDataThenInsertDeliveredQtyToolStripMenuItem";
            this.copyDataThenInsertDeliveredQtyToolStripMenuItem.Size = new System.Drawing.Size(304, 24);
            this.copyDataThenInsertDeliveredQtyToolStripMenuItem.Text = "Copy Data Then Insert Delivered Qty";
            // 
            // updateSIDRToolStripMenuItem
            // 
            this.updateSIDRToolStripMenuItem.Name = "updateSIDRToolStripMenuItem";
            this.updateSIDRToolStripMenuItem.Size = new System.Drawing.Size(304, 24);
            this.updateSIDRToolStripMenuItem.Text = "Update Delivered Qty";
            // 
            // updateDRSIToolStripMenuItem
            // 
            this.updateDRSIToolStripMenuItem.Name = "updateDRSIToolStripMenuItem";
            this.updateDRSIToolStripMenuItem.Size = new System.Drawing.Size(304, 24);
            this.updateDRSIToolStripMenuItem.Text = "Update DR / SI";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmDeliveryMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1321, 733);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeliveryMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Monitoring System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDeliveryMonitoring_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverySchedule)).EndInit();
            this.cmStripDeliveryMonitoring.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbPartCode;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.TextBox tbPartName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboDeliverySchedYear;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox cboDeliverySchedMonth;
        private System.Windows.Forms.DataGridView dgvDeliverySchedule;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ContextMenuStrip cmStripDeliveryMonitoring;
        private System.Windows.Forms.ToolStripMenuItem copyDataThenInsertDeliveredQtyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSIDRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDRSIToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        internal Bunifu.Framework.UI.BunifuImageButton BunifuImageButton1;
        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button19;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.ComboBox cboDSchedByYear;
        private System.Windows.Forms.TextBox tbTotal;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}