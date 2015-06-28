namespace LibraryApplication
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tabMainMenu = new System.Windows.Forms.TabControl();
            this.BookSearch = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBSRole = new System.Windows.Forms.CheckBox();
            this.chkBSAuthor = new System.Windows.Forms.CheckBox();
            this.chkBSBookTitle = new System.Windows.Forms.CheckBox();
            this.chkBSBookId = new System.Windows.Forms.CheckBox();
            this.errorBookSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gdbookSerach = new System.Windows.Forms.DataGridView();
            this.Book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Branch_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_of_copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_of_Available_copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowerManagement = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.errorBorrower = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddBr = new System.Windows.Forms.Button();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BookLoans = new System.Windows.Forms.TabPage();
            this.tabLoans = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.errorCheckOut = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtCheckOutBranchId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCheckOutCardNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCheckOutbookId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.notifyCheckIn = new System.Windows.Forms.Label();
            this.btnCancelCheckIn = new System.Windows.Forms.Button();
            this.btnBookCheckIn = new System.Windows.Forms.Button();
            this.gdCheckIn = new System.Windows.Forms.DataGridView();
            this.chkBoxChekIn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Card_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCardNo = new System.Windows.Forms.CheckBox();
            this.chkBRName = new System.Windows.Forms.CheckBox();
            this.chkBookId = new System.Windows.Forms.CheckBox();
            this.errorCheckIn = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSearchCheckIn = new System.Windows.Forms.Button();
            this.txtCheckInBRName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCheckInCardNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCheckInBookId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Fines = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gdFines = new System.Windows.Forms.DataGridView();
            this.Payment = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FinesBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinesBranchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinesTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinesLoanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinesCardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinesFineAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.txtFinesTotal = new System.Windows.Forms.TextBox();
            this.notifyFines = new System.Windows.Forms.Label();
            this.btnFinesCancel = new System.Windows.Forms.Button();
            this.btnFinesPayment = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFinesBorrowerName = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.notifyUpdateFine = new System.Windows.Forms.Label();
            this.btnUpdateFines = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoFinesCardNumber = new System.Windows.Forms.RadioButton();
            this.rdoFinesBRName = new System.Windows.Forms.RadioButton();
            this.errorFines = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSearchFines = new System.Windows.Forms.Button();
            this.txtFinesCardNumber = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pdfManual = new AxAcroPDFLib.AxAcroPDF();
            this.panel1.SuspendLayout();
            this.tabMainMenu.SuspendLayout();
            this.BookSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdbookSerach)).BeginInit();
            this.BorrowerManagement.SuspendLayout();
            this.panel3.SuspendLayout();
            this.BookLoans.SuspendLayout();
            this.tabLoans.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdCheckIn)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Fines.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdFines)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Help.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdfManual)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.tabMainMenu);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 479);
            this.panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnLogOut.FlatAppearance.BorderSize = 2;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnLogOut.Image = global::LibraryApplication.Properties.Resources.logOut;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(886, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(130, 30);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tabMainMenu
            // 
            this.tabMainMenu.Controls.Add(this.BookSearch);
            this.tabMainMenu.Controls.Add(this.BorrowerManagement);
            this.tabMainMenu.Controls.Add(this.BookLoans);
            this.tabMainMenu.Controls.Add(this.Fines);
            this.tabMainMenu.Controls.Add(this.Help);
            this.tabMainMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMainMenu.Location = new System.Drawing.Point(3, 10);
            this.tabMainMenu.Name = "tabMainMenu";
            this.tabMainMenu.SelectedIndex = 0;
            this.tabMainMenu.Size = new System.Drawing.Size(1017, 466);
            this.tabMainMenu.TabIndex = 0;
            this.tabMainMenu.SelectedIndexChanged += new System.EventHandler(this.tabMainMenu_SelectedIndexChanged);
            // 
            // BookSearch
            // 
            this.BookSearch.Controls.Add(this.panel2);
            this.BookSearch.Controls.Add(this.gdbookSerach);
            this.BookSearch.Location = new System.Drawing.Point(4, 26);
            this.BookSearch.Name = "BookSearch";
            this.BookSearch.Padding = new System.Windows.Forms.Padding(3);
            this.BookSearch.Size = new System.Drawing.Size(1009, 436);
            this.BookSearch.TabIndex = 0;
            this.BookSearch.Text = "Book Search And Availability ";
            this.BookSearch.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtRole);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.errorBookSearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtBookId);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtAuthor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 377);
            this.panel2.TabIndex = 8;
            // 
            // txtRole
            // 
            this.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRole.Location = new System.Drawing.Point(148, 239);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(153, 25);
            this.txtRole.TabIndex = 4;
            this.txtRole.TextChanged += new System.EventHandler(this.txtRole_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(86, 241);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 19);
            this.label22.TabIndex = 11;
            this.label22.Text = "Role :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.chkBSRole);
            this.groupBox2.Controls.Add(this.chkBSAuthor);
            this.groupBox2.Controls.Add(this.chkBSBookTitle);
            this.groupBox2.Controls.Add(this.chkBSBookId);
            this.groupBox2.Location = new System.Drawing.Point(5, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 77);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter By";
            // 
            // chkBSRole
            // 
            this.chkBSRole.AutoSize = true;
            this.chkBSRole.BackColor = System.Drawing.Color.Silver;
            this.chkBSRole.Checked = true;
            this.chkBSRole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBSRole.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkBSRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBSRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBSRole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkBSRole.Location = new System.Drawing.Point(337, 34);
            this.chkBSRole.Name = "chkBSRole";
            this.chkBSRole.Size = new System.Drawing.Size(53, 23);
            this.chkBSRole.TabIndex = 3;
            this.chkBSRole.Text = "Role";
            this.chkBSRole.UseVisualStyleBackColor = false;
            this.chkBSRole.CheckedChanged += new System.EventHandler(this.chkBSRole_CheckedChanged);
            // 
            // chkBSAuthor
            // 
            this.chkBSAuthor.AutoSize = true;
            this.chkBSAuthor.BackColor = System.Drawing.Color.Silver;
            this.chkBSAuthor.Checked = true;
            this.chkBSAuthor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBSAuthor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkBSAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBSAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBSAuthor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkBSAuthor.Location = new System.Drawing.Point(238, 34);
            this.chkBSAuthor.Name = "chkBSAuthor";
            this.chkBSAuthor.Size = new System.Drawing.Size(68, 23);
            this.chkBSAuthor.TabIndex = 2;
            this.chkBSAuthor.Text = "Author";
            this.chkBSAuthor.UseVisualStyleBackColor = false;
            this.chkBSAuthor.CheckedChanged += new System.EventHandler(this.chkBSAuthor_CheckedChanged);
            // 
            // chkBSBookTitle
            // 
            this.chkBSBookTitle.AutoSize = true;
            this.chkBSBookTitle.Checked = true;
            this.chkBSBookTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBSBookTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBSBookTitle.Location = new System.Drawing.Point(21, 34);
            this.chkBSBookTitle.Name = "chkBSBookTitle";
            this.chkBSBookTitle.Size = new System.Drawing.Size(88, 23);
            this.chkBSBookTitle.TabIndex = 1;
            this.chkBSBookTitle.Text = "Book Title";
            this.chkBSBookTitle.UseVisualStyleBackColor = true;
            this.chkBSBookTitle.CheckedChanged += new System.EventHandler(this.chkBSBookTitle_CheckedChanged);
            // 
            // chkBSBookId
            // 
            this.chkBSBookId.AutoSize = true;
            this.chkBSBookId.Checked = true;
            this.chkBSBookId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBSBookId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBSBookId.Location = new System.Drawing.Point(143, 34);
            this.chkBSBookId.Name = "chkBSBookId";
            this.chkBSBookId.Size = new System.Drawing.Size(72, 23);
            this.chkBSBookId.TabIndex = 0;
            this.chkBSBookId.Text = "Book Id";
            this.chkBSBookId.UseVisualStyleBackColor = true;
            this.chkBSBookId.CheckedChanged += new System.EventHandler(this.chkBSBookId_CheckedChanged);
            // 
            // errorBookSearch
            // 
            this.errorBookSearch.AutoSize = true;
            this.errorBookSearch.ForeColor = System.Drawing.Color.Maroon;
            this.errorBookSearch.Location = new System.Drawing.Point(67, 282);
            this.errorBookSearch.Name = "errorBookSearch";
            this.errorBookSearch.Size = new System.Drawing.Size(26, 19);
            this.errorBookSearch.TabIndex = 8;
            this.errorBookSearch.Text = "txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Search Criteria";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::LibraryApplication.Properties.Resources.Search1;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearch.Location = new System.Drawing.Point(148, 311);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBookId
            // 
            this.txtBookId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookId.Location = new System.Drawing.Point(148, 169);
            this.txtBookId.MaxLength = 10;
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(153, 25);
            this.txtBookId.TabIndex = 2;
            this.txtBookId.TextChanged += new System.EventHandler(this.txtBookId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Title :";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthor.Location = new System.Drawing.Point(148, 204);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(153, 25);
            this.txtAuthor.TabIndex = 3;
            this.txtAuthor.TextChanged += new System.EventHandler(this.txtAuthor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author :";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Location = new System.Drawing.Point(148, 133);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(153, 25);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book Id :";
            // 
            // gdbookSerach
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdbookSerach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdbookSerach.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gdbookSerach.ColumnHeadersHeight = 30;
            this.gdbookSerach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_id,
            this.Title,
            this.Author_name,
            this.Role,
            this.Branch_id,
            this.Branch_name,
            this.No_of_copies,
            this.No_of_Available_copies});
            this.gdbookSerach.Location = new System.Drawing.Point(421, 3);
            this.gdbookSerach.Name = "gdbookSerach";
            this.gdbookSerach.ReadOnly = true;
            this.gdbookSerach.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdbookSerach.ShowCellToolTips = false;
            this.gdbookSerach.Size = new System.Drawing.Size(584, 377);
            this.gdbookSerach.TabIndex = 9;
            // 
            // Book_id
            // 
            this.Book_id.DataPropertyName = "Book_id";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.Book_id.HeaderText = "Book Id";
            this.Book_id.Name = "Book_id";
            this.Book_id.ReadOnly = true;
            this.Book_id.Width = 90;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.DefaultCellStyle = dataGridViewCellStyle3;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Author_name
            // 
            this.Author_name.DataPropertyName = "Author_name";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_name.DefaultCellStyle = dataGridViewCellStyle4;
            this.Author_name.HeaderText = "Author";
            this.Author_name.Name = "Author_name";
            this.Author_name.ReadOnly = true;
            this.Author_name.Width = 130;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Branch_id
            // 
            this.Branch_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Branch_id.DataPropertyName = "Branch_id";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Branch_id.DefaultCellStyle = dataGridViewCellStyle5;
            this.Branch_id.HeaderText = "Branch Id";
            this.Branch_id.Name = "Branch_id";
            this.Branch_id.ReadOnly = true;
            this.Branch_id.Width = 75;
            // 
            // Branch_name
            // 
            this.Branch_name.DataPropertyName = "Branch_name";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Branch_name.DefaultCellStyle = dataGridViewCellStyle6;
            this.Branch_name.HeaderText = "Branch Name";
            this.Branch_name.Name = "Branch_name";
            this.Branch_name.ReadOnly = true;
            // 
            // No_of_copies
            // 
            this.No_of_copies.DataPropertyName = "No_of_copies";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_of_copies.DefaultCellStyle = dataGridViewCellStyle7;
            this.No_of_copies.HeaderText = "Total Copies";
            this.No_of_copies.Name = "No_of_copies";
            this.No_of_copies.ReadOnly = true;
            // 
            // No_of_Available_copies
            // 
            this.No_of_Available_copies.DataPropertyName = "No_of_Available_copies";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No_of_Available_copies.DefaultCellStyle = dataGridViewCellStyle8;
            this.No_of_Available_copies.HeaderText = "Available Copies";
            this.No_of_Available_copies.Name = "No_of_Available_copies";
            this.No_of_Available_copies.ReadOnly = true;
            this.No_of_Available_copies.Width = 120;
            // 
            // BorrowerManagement
            // 
            this.BorrowerManagement.Controls.Add(this.panel3);
            this.BorrowerManagement.Location = new System.Drawing.Point(4, 26);
            this.BorrowerManagement.Name = "BorrowerManagement";
            this.BorrowerManagement.Padding = new System.Windows.Forms.Padding(3);
            this.BorrowerManagement.Size = new System.Drawing.Size(1009, 436);
            this.BorrowerManagement.TabIndex = 1;
            this.BorrowerManagement.Text = "Borrower Management";
            this.BorrowerManagement.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtState);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.txtCity);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.txtPhone);
            this.panel3.Controls.Add(this.lblPhone);
            this.panel3.Controls.Add(this.errorBorrower);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnAddBr);
            this.panel3.Controls.Add(this.txtLname);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.lblAddress);
            this.panel3.Controls.Add(this.txtFname);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 380);
            this.panel3.TabIndex = 9;
            // 
            // txtState
            // 
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtState.Location = new System.Drawing.Point(147, 197);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(153, 25);
            this.txtState.TabIndex = 5;
            this.txtState.TextChanged += new System.EventHandler(this.txtState_TextChanged);
            this.txtState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtState_KeyPress);
            this.txtState.Leave += new System.EventHandler(this.txtState_Leave);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(93, 199);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(48, 19);
            this.label24.TabIndex = 12;
            this.label24.Text = "State :";
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Location = new System.Drawing.Point(147, 164);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(153, 25);
            this.txtCity.TabIndex = 4;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            this.txtCity.Leave += new System.EventHandler(this.txtCity_Leave);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(100, 166);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 19);
            this.label23.TabIndex = 10;
            this.label23.Text = "City :";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(147, 231);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(153, 25);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(86, 233);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 19);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone :";
            // 
            // errorBorrower
            // 
            this.errorBorrower.AutoSize = true;
            this.errorBorrower.ForeColor = System.Drawing.Color.Maroon;
            this.errorBorrower.Location = new System.Drawing.Point(70, 291);
            this.errorBorrower.Name = "errorBorrower";
            this.errorBorrower.Size = new System.Drawing.Size(26, 19);
            this.errorBorrower.TabIndex = 8;
            this.errorBorrower.Text = "txt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter New Borrower Information";
            // 
            // btnAddBr
            // 
            this.btnAddBr.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddBr.FlatAppearance.BorderSize = 2;
            this.btnAddBr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBr.Image = global::LibraryApplication.Properties.Resources.add;
            this.btnAddBr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBr.Location = new System.Drawing.Point(149, 324);
            this.btnAddBr.Name = "btnAddBr";
            this.btnAddBr.Size = new System.Drawing.Size(152, 31);
            this.btnAddBr.TabIndex = 7;
            this.btnAddBr.Text = "Add Borrower";
            this.btnAddBr.UseVisualStyleBackColor = true;
            this.btnAddBr.Click += new System.EventHandler(this.btnAddBr_Click);
            // 
            // txtLname
            // 
            this.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLname.Location = new System.Drawing.Point(148, 94);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(153, 25);
            this.txtLname.TabIndex = 2;
            this.txtLname.TextChanged += new System.EventHandler(this.txtLname_TextChanged);
            this.txtLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLname_KeyPress);
            this.txtLname.Leave += new System.EventHandler(this.txtLname_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "First Name* :";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(148, 129);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(153, 25);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(70, 131);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 19);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address* :";
            // 
            // txtFname
            // 
            this.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFname.Location = new System.Drawing.Point(147, 60);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(153, 25);
            this.txtFname.TabIndex = 1;
            this.txtFname.TextChanged += new System.EventHandler(this.txtFname_TextChanged);
            this.txtFname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFname_KeyPress);
            this.txtFname.Leave += new System.EventHandler(this.txtFname_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Last Name* :";
            // 
            // BookLoans
            // 
            this.BookLoans.Controls.Add(this.tabLoans);
            this.BookLoans.Location = new System.Drawing.Point(4, 26);
            this.BookLoans.Name = "BookLoans";
            this.BookLoans.Size = new System.Drawing.Size(1009, 436);
            this.BookLoans.TabIndex = 2;
            this.BookLoans.Text = "Book Loans";
            this.BookLoans.UseVisualStyleBackColor = true;
            // 
            // tabLoans
            // 
            this.tabLoans.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabLoans.Controls.Add(this.tabPage1);
            this.tabLoans.Controls.Add(this.tabPage2);
            this.tabLoans.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLoans.Location = new System.Drawing.Point(4, 3);
            this.tabLoans.Multiline = true;
            this.tabLoans.Name = "tabLoans";
            this.tabLoans.SelectedIndex = 0;
            this.tabLoans.Size = new System.Drawing.Size(1009, 433);
            this.tabLoans.TabIndex = 0;
            this.tabLoans.SelectedIndexChanged += new System.EventHandler(this.tabLoans_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(28, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(977, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Check Out";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.errorCheckOut);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btnCheckOut);
            this.panel4.Controls.Add(this.txtCheckOutBranchId);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtCheckOutCardNumber);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtCheckOutbookId);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(442, 378);
            this.panel4.TabIndex = 9;
            // 
            // errorCheckOut
            // 
            this.errorCheckOut.AutoSize = true;
            this.errorCheckOut.ForeColor = System.Drawing.Color.Maroon;
            this.errorCheckOut.Location = new System.Drawing.Point(51, 171);
            this.errorCheckOut.Name = "errorCheckOut";
            this.errorCheckOut.Size = new System.Drawing.Size(26, 19);
            this.errorCheckOut.TabIndex = 8;
            this.errorCheckOut.Text = "txt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Enter Information to Check Out";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCheckOut.FlatAppearance.BorderSize = 2;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Image = global::LibraryApplication.Properties.Resources.tick1;
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.Location = new System.Drawing.Point(148, 226);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(153, 31);
            this.btnCheckOut.TabIndex = 4;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtCheckOutBranchId
            // 
            this.txtCheckOutBranchId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckOutBranchId.Location = new System.Drawing.Point(148, 99);
            this.txtCheckOutBranchId.Name = "txtCheckOutBranchId";
            this.txtCheckOutBranchId.Size = new System.Drawing.Size(153, 25);
            this.txtCheckOutBranchId.TabIndex = 2;
            this.txtCheckOutBranchId.TextChanged += new System.EventHandler(this.txtCheckOutBranchId_TextChanged);
            this.txtCheckOutBranchId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheckOutBranchId_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(67, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Book Id* :";
            // 
            // txtCheckOutCardNumber
            // 
            this.txtCheckOutCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckOutCardNumber.Location = new System.Drawing.Point(148, 134);
            this.txtCheckOutCardNumber.Name = "txtCheckOutCardNumber";
            this.txtCheckOutCardNumber.Size = new System.Drawing.Size(153, 25);
            this.txtCheckOutCardNumber.TabIndex = 3;
            this.txtCheckOutCardNumber.TextChanged += new System.EventHandler(this.txtCheckOutCardNumber_TextChanged);
            this.txtCheckOutCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheckOutCardNumber_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Card Number* :";
            // 
            // txtCheckOutbookId
            // 
            this.txtCheckOutbookId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckOutbookId.Location = new System.Drawing.Point(148, 64);
            this.txtCheckOutbookId.MaxLength = 10;
            this.txtCheckOutbookId.Name = "txtCheckOutbookId";
            this.txtCheckOutbookId.Size = new System.Drawing.Size(153, 25);
            this.txtCheckOutbookId.TabIndex = 1;
            this.txtCheckOutbookId.TextChanged += new System.EventHandler(this.txtCheckOutbookId_TextChanged);
            this.txtCheckOutbookId.Leave += new System.EventHandler(this.txtCheckOutbookId_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "Branch Id* :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(28, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(977, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Check In";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.notifyCheckIn);
            this.panel6.Controls.Add(this.btnCancelCheckIn);
            this.panel6.Controls.Add(this.btnBookCheckIn);
            this.panel6.Controls.Add(this.gdCheckIn);
            this.panel6.Location = new System.Drawing.Point(399, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(575, 376);
            this.panel6.TabIndex = 13;
            // 
            // notifyCheckIn
            // 
            this.notifyCheckIn.AutoSize = true;
            this.notifyCheckIn.ForeColor = System.Drawing.Color.Maroon;
            this.notifyCheckIn.Location = new System.Drawing.Point(108, 271);
            this.notifyCheckIn.Name = "notifyCheckIn";
            this.notifyCheckIn.Size = new System.Drawing.Size(26, 19);
            this.notifyCheckIn.TabIndex = 14;
            this.notifyCheckIn.Text = "txt";
            // 
            // btnCancelCheckIn
            // 
            this.btnCancelCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelCheckIn.FlatAppearance.BorderSize = 2;
            this.btnCancelCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCheckIn.Image = global::LibraryApplication.Properties.Resources.Cancel1;
            this.btnCancelCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelCheckIn.Location = new System.Drawing.Point(359, 314);
            this.btnCancelCheckIn.Name = "btnCancelCheckIn";
            this.btnCancelCheckIn.Size = new System.Drawing.Size(119, 31);
            this.btnCancelCheckIn.TabIndex = 6;
            this.btnCancelCheckIn.Text = "Cancel";
            this.btnCancelCheckIn.UseVisualStyleBackColor = true;
            this.btnCancelCheckIn.Click += new System.EventHandler(this.btnCancelCheckIn_Click);
            // 
            // btnBookCheckIn
            // 
            this.btnBookCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBookCheckIn.FlatAppearance.BorderSize = 2;
            this.btnBookCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookCheckIn.Image = global::LibraryApplication.Properties.Resources.tick1;
            this.btnBookCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookCheckIn.Location = new System.Drawing.Point(167, 314);
            this.btnBookCheckIn.Name = "btnBookCheckIn";
            this.btnBookCheckIn.Size = new System.Drawing.Size(122, 31);
            this.btnBookCheckIn.TabIndex = 5;
            this.btnBookCheckIn.Text = "Check In";
            this.btnBookCheckIn.UseVisualStyleBackColor = true;
            this.btnBookCheckIn.Click += new System.EventHandler(this.btnBookCheckIn_Click);
            // 
            // gdCheckIn
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdCheckIn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gdCheckIn.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gdCheckIn.ColumnHeadersHeight = 25;
            this.gdCheckIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkBoxChekIn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Card_no,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5});
            this.gdCheckIn.Location = new System.Drawing.Point(2, 3);
            this.gdCheckIn.Name = "gdCheckIn";
            this.gdCheckIn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdCheckIn.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.gdCheckIn.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdCheckIn.ShowCellToolTips = false;
            this.gdCheckIn.Size = new System.Drawing.Size(576, 217);
            this.gdCheckIn.TabIndex = 11;
            this.gdCheckIn.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gdCheckIn_CellBeginEdit);
            this.gdCheckIn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdCheckIn_CellClick);
            this.gdCheckIn.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdCheckIn_CellEndEdit);
            this.gdCheckIn.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdCheckIn_CellValueChanged);
            this.gdCheckIn.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gdCheckIn_Scroll);
            // 
            // chkBoxChekIn
            // 
            this.chkBoxChekIn.HeaderText = "Check In";
            this.chkBoxChekIn.Name = "chkBoxChekIn";
            this.chkBoxChekIn.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Book_id";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn1.HeaderText = "Book Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Branch_id";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn4.HeaderText = "Branch Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // Card_no
            // 
            this.Card_no.DataPropertyName = "Card_no";
            this.Card_no.HeaderText = "Card Number";
            this.Card_no.Name = "Card_no";
            this.Card_no.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Fname";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn7.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Lname";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn6.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date_in";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn5.HeaderText = "Date In";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.errorCheckIn);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.btnSearchCheckIn);
            this.panel5.Controls.Add(this.txtCheckInBRName);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.txtCheckInCardNumber);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.txtCheckInBookId);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(393, 376);
            this.panel5.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.chkCardNo);
            this.groupBox1.Controls.Add(this.chkBRName);
            this.groupBox1.Controls.Add(this.chkBookId);
            this.groupBox1.Location = new System.Drawing.Point(2, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 77);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter By";
            // 
            // chkCardNo
            // 
            this.chkCardNo.AutoSize = true;
            this.chkCardNo.Checked = true;
            this.chkCardNo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCardNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkCardNo.Location = new System.Drawing.Point(268, 34);
            this.chkCardNo.Name = "chkCardNo";
            this.chkCardNo.Size = new System.Drawing.Size(109, 23);
            this.chkCardNo.TabIndex = 2;
            this.chkCardNo.Text = "Card Number";
            this.chkCardNo.UseVisualStyleBackColor = true;
            this.chkCardNo.CheckedChanged += new System.EventHandler(this.chkCardNo_CheckedChanged);
            // 
            // chkBRName
            // 
            this.chkBRName.AutoSize = true;
            this.chkBRName.Checked = true;
            this.chkBRName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBRName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBRName.Location = new System.Drawing.Point(116, 34);
            this.chkBRName.Name = "chkBRName";
            this.chkBRName.Size = new System.Drawing.Size(123, 23);
            this.chkBRName.TabIndex = 1;
            this.chkBRName.Text = "Borrower Name";
            this.chkBRName.UseVisualStyleBackColor = true;
            this.chkBRName.CheckedChanged += new System.EventHandler(this.chkBRName_CheckedChanged);
            // 
            // chkBookId
            // 
            this.chkBookId.AutoSize = true;
            this.chkBookId.Checked = true;
            this.chkBookId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBookId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBookId.Location = new System.Drawing.Point(18, 34);
            this.chkBookId.Name = "chkBookId";
            this.chkBookId.Size = new System.Drawing.Size(72, 23);
            this.chkBookId.TabIndex = 0;
            this.chkBookId.Text = "Book Id";
            this.chkBookId.UseVisualStyleBackColor = true;
            this.chkBookId.CheckedChanged += new System.EventHandler(this.chkBookId_CheckedChanged);
            // 
            // errorCheckIn
            // 
            this.errorCheckIn.AutoSize = true;
            this.errorCheckIn.ForeColor = System.Drawing.Color.Maroon;
            this.errorCheckIn.Location = new System.Drawing.Point(69, 282);
            this.errorCheckIn.Name = "errorCheckIn";
            this.errorCheckIn.Size = new System.Drawing.Size(26, 19);
            this.errorCheckIn.TabIndex = 8;
            this.errorCheckIn.Text = "txt";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Search to Check In the book";
            // 
            // btnSearchCheckIn
            // 
            this.btnSearchCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSearchCheckIn.FlatAppearance.BorderSize = 2;
            this.btnSearchCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCheckIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCheckIn.Image = global::LibraryApplication.Properties.Resources.Search1;
            this.btnSearchCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCheckIn.Location = new System.Drawing.Point(148, 314);
            this.btnSearchCheckIn.Name = "btnSearchCheckIn";
            this.btnSearchCheckIn.Size = new System.Drawing.Size(153, 31);
            this.btnSearchCheckIn.TabIndex = 4;
            this.btnSearchCheckIn.Text = "Search";
            this.btnSearchCheckIn.UseVisualStyleBackColor = true;
            this.btnSearchCheckIn.Click += new System.EventHandler(this.btnSearchCheckIn_Click);
            // 
            // txtCheckInBRName
            // 
            this.txtCheckInBRName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckInBRName.Location = new System.Drawing.Point(148, 182);
            this.txtCheckInBRName.Name = "txtCheckInBRName";
            this.txtCheckInBRName.Size = new System.Drawing.Size(153, 25);
            this.txtCheckInBRName.TabIndex = 2;
            this.txtCheckInBRName.TextChanged += new System.EventHandler(this.txtCheckInBRName_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(69, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 19);
            this.label14.TabIndex = 1;
            this.label14.Text = "Book Id :";
            // 
            // txtCheckInCardNumber
            // 
            this.txtCheckInCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckInCardNumber.Location = new System.Drawing.Point(148, 229);
            this.txtCheckInCardNumber.Name = "txtCheckInCardNumber";
            this.txtCheckInCardNumber.Size = new System.Drawing.Size(153, 25);
            this.txtCheckInCardNumber.TabIndex = 3;
            this.txtCheckInCardNumber.Text = "0";
            this.txtCheckInCardNumber.TextChanged += new System.EventHandler(this.txtCheckInCardNumber_TextChanged);
            this.txtCheckInCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheckInCardNumber_KeyPress);
            this.txtCheckInCardNumber.Leave += new System.EventHandler(this.txtCheckInCardNumber_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(32, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "Card Number :";
            // 
            // txtCheckInBookId
            // 
            this.txtCheckInBookId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckInBookId.Location = new System.Drawing.Point(148, 137);
            this.txtCheckInBookId.MaxLength = 10;
            this.txtCheckInBookId.Name = "txtCheckInBookId";
            this.txtCheckInBookId.Size = new System.Drawing.Size(153, 25);
            this.txtCheckInBookId.TabIndex = 1;
            this.txtCheckInBookId.TextChanged += new System.EventHandler(this.txtCheckInBookId_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 19);
            this.label16.TabIndex = 3;
            this.label16.Text = "Borrower Name :";
            // 
            // Fines
            // 
            this.Fines.Controls.Add(this.panel8);
            this.Fines.Controls.Add(this.panel7);
            this.Fines.Location = new System.Drawing.Point(4, 26);
            this.Fines.Name = "Fines";
            this.Fines.Size = new System.Drawing.Size(1009, 436);
            this.Fines.TabIndex = 3;
            this.Fines.Text = "Fines";
            this.Fines.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Silver;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.gdFines);
            this.panel8.Controls.Add(this.label18);
            this.panel8.Controls.Add(this.txtFinesTotal);
            this.panel8.Controls.Add(this.notifyFines);
            this.panel8.Controls.Add(this.btnFinesCancel);
            this.panel8.Controls.Add(this.btnFinesPayment);
            this.panel8.Location = new System.Drawing.Point(428, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(575, 376);
            this.panel8.TabIndex = 14;
            // 
            // gdFines
            // 
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdFines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.gdFines.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gdFines.ColumnHeadersHeight = 30;
            this.gdFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gdFines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Payment,
            this.FinesBookId,
            this.FinesBranchId,
            this.FinesTitle,
            this.FinesLoanId,
            this.FinesCardNo,
            this.FinesName,
            this.FinesFineAmount});
            this.gdFines.Location = new System.Drawing.Point(-1, -1);
            this.gdFines.Name = "gdFines";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdFines.RowsDefaultCellStyle = dataGridViewCellStyle17;
            this.gdFines.Size = new System.Drawing.Size(575, 191);
            this.gdFines.TabIndex = 17;
            this.gdFines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdFines_CellClick);
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.Name = "Payment";
            // 
            // FinesBookId
            // 
            this.FinesBookId.DataPropertyName = "Book_id";
            this.FinesBookId.HeaderText = "Book Id";
            this.FinesBookId.Name = "FinesBookId";
            this.FinesBookId.ReadOnly = true;
            // 
            // FinesBranchId
            // 
            this.FinesBranchId.DataPropertyName = "Branch_id";
            this.FinesBranchId.HeaderText = "Branch Id";
            this.FinesBranchId.Name = "FinesBranchId";
            this.FinesBranchId.ReadOnly = true;
            // 
            // FinesTitle
            // 
            this.FinesTitle.DataPropertyName = "Title";
            this.FinesTitle.HeaderText = "Title";
            this.FinesTitle.Name = "FinesTitle";
            this.FinesTitle.ReadOnly = true;
            // 
            // FinesLoanId
            // 
            this.FinesLoanId.DataPropertyName = "Loan_id";
            this.FinesLoanId.HeaderText = "Loan Id";
            this.FinesLoanId.Name = "FinesLoanId";
            this.FinesLoanId.ReadOnly = true;
            this.FinesLoanId.Visible = false;
            // 
            // FinesCardNo
            // 
            this.FinesCardNo.DataPropertyName = "Card_no";
            this.FinesCardNo.HeaderText = "Card Number";
            this.FinesCardNo.Name = "FinesCardNo";
            this.FinesCardNo.ReadOnly = true;
            // 
            // FinesName
            // 
            this.FinesName.DataPropertyName = "Name";
            this.FinesName.HeaderText = "Name";
            this.FinesName.Name = "FinesName";
            this.FinesName.ReadOnly = true;
            // 
            // FinesFineAmount
            // 
            this.FinesFineAmount.DataPropertyName = "Fine_amount";
            this.FinesFineAmount.HeaderText = "Fine Amount";
            this.FinesFineAmount.Name = "FinesFineAmount";
            this.FinesFineAmount.ReadOnly = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(382, 209);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 19);
            this.label18.TabIndex = 16;
            this.label18.Text = "Total Fine :";
            // 
            // txtFinesTotal
            // 
            this.txtFinesTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinesTotal.Enabled = false;
            this.txtFinesTotal.Location = new System.Drawing.Point(466, 207);
            this.txtFinesTotal.Name = "txtFinesTotal";
            this.txtFinesTotal.Size = new System.Drawing.Size(104, 25);
            this.txtFinesTotal.TabIndex = 15;
            this.txtFinesTotal.Text = "0";
            this.txtFinesTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // notifyFines
            // 
            this.notifyFines.AutoSize = true;
            this.notifyFines.ForeColor = System.Drawing.Color.Maroon;
            this.notifyFines.Location = new System.Drawing.Point(185, 299);
            this.notifyFines.Name = "notifyFines";
            this.notifyFines.Size = new System.Drawing.Size(26, 19);
            this.notifyFines.TabIndex = 14;
            this.notifyFines.Text = "txt";
            // 
            // btnFinesCancel
            // 
            this.btnFinesCancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFinesCancel.FlatAppearance.BorderSize = 2;
            this.btnFinesCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinesCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinesCancel.Image = global::LibraryApplication.Properties.Resources.Cancel1;
            this.btnFinesCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinesCancel.Location = new System.Drawing.Point(361, 331);
            this.btnFinesCancel.Name = "btnFinesCancel";
            this.btnFinesCancel.Size = new System.Drawing.Size(117, 31);
            this.btnFinesCancel.TabIndex = 6;
            this.btnFinesCancel.Text = "Cancel";
            this.btnFinesCancel.UseVisualStyleBackColor = true;
            this.btnFinesCancel.Click += new System.EventHandler(this.btnFinesCancel_Click);
            // 
            // btnFinesPayment
            // 
            this.btnFinesPayment.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFinesPayment.FlatAppearance.BorderSize = 2;
            this.btnFinesPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinesPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinesPayment.Image = global::LibraryApplication.Properties.Resources.payment;
            this.btnFinesPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinesPayment.Location = new System.Drawing.Point(189, 331);
            this.btnFinesPayment.Name = "btnFinesPayment";
            this.btnFinesPayment.Size = new System.Drawing.Size(126, 31);
            this.btnFinesPayment.TabIndex = 5;
            this.btnFinesPayment.Text = "Payment";
            this.btnFinesPayment.UseVisualStyleBackColor = true;
            this.btnFinesPayment.Click += new System.EventHandler(this.btnFinesPayment_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.cmbStatus);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.txtFinesBorrowerName);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.groupBox3);
            this.panel7.Controls.Add(this.errorFines);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.btnSearchFines);
            this.panel7.Controls.Add(this.txtFinesCardNumber);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(422, 379);
            this.panel7.TabIndex = 13;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Returned",
            "Not Yet Returned"});
            this.cmbStatus.Location = new System.Drawing.Point(175, 266);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(153, 25);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(79, 269);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 19);
            this.label21.TabIndex = 14;
            this.label21.Text = "Book Status :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(69, 227);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 19);
            this.label20.TabIndex = 13;
            this.label20.Text = "Card Number :";
            // 
            // txtFinesBorrowerName
            // 
            this.txtFinesBorrowerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinesBorrowerName.Location = new System.Drawing.Point(175, 187);
            this.txtFinesBorrowerName.Name = "txtFinesBorrowerName";
            this.txtFinesBorrowerName.Size = new System.Drawing.Size(153, 25);
            this.txtFinesBorrowerName.TabIndex = 1;
            this.txtFinesBorrowerName.TextChanged += new System.EventHandler(this.txtFinesBorrowerName_TextChanged);
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.notifyUpdateFine);
            this.panel9.Controls.Add(this.btnUpdateFines);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(414, 77);
            this.panel9.TabIndex = 11;
            // 
            // notifyUpdateFine
            // 
            this.notifyUpdateFine.AutoSize = true;
            this.notifyUpdateFine.ForeColor = System.Drawing.Color.Maroon;
            this.notifyUpdateFine.Location = new System.Drawing.Point(95, 47);
            this.notifyUpdateFine.Name = "notifyUpdateFine";
            this.notifyUpdateFine.Size = new System.Drawing.Size(26, 19);
            this.notifyUpdateFine.TabIndex = 9;
            this.notifyUpdateFine.Text = "txt";
            // 
            // btnUpdateFines
            // 
            this.btnUpdateFines.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnUpdateFines.FlatAppearance.BorderSize = 2;
            this.btnUpdateFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateFines.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFines.Image = global::LibraryApplication.Properties.Resources.update;
            this.btnUpdateFines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateFines.Location = new System.Drawing.Point(171, 8);
            this.btnUpdateFines.Name = "btnUpdateFines";
            this.btnUpdateFines.Size = new System.Drawing.Size(153, 31);
            this.btnUpdateFines.TabIndex = 1;
            this.btnUpdateFines.Text = "Update Fines";
            this.btnUpdateFines.UseVisualStyleBackColor = true;
            this.btnUpdateFines.Click += new System.EventHandler(this.btnUpdateFines_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Click To Update Fines :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.rdoFinesCardNumber);
            this.groupBox3.Controls.Add(this.rdoFinesBRName);
            this.groupBox3.Location = new System.Drawing.Point(3, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 77);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter Criteria";
            // 
            // rdoFinesCardNumber
            // 
            this.rdoFinesCardNumber.AutoSize = true;
            this.rdoFinesCardNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoFinesCardNumber.Location = new System.Drawing.Point(225, 34);
            this.rdoFinesCardNumber.Name = "rdoFinesCardNumber";
            this.rdoFinesCardNumber.Size = new System.Drawing.Size(110, 23);
            this.rdoFinesCardNumber.TabIndex = 1;
            this.rdoFinesCardNumber.Text = "Card Number";
            this.rdoFinesCardNumber.UseVisualStyleBackColor = true;
            this.rdoFinesCardNumber.CheckedChanged += new System.EventHandler(this.rdoFinesCardNumber_CheckedChanged);
            // 
            // rdoFinesBRName
            // 
            this.rdoFinesBRName.AutoSize = true;
            this.rdoFinesBRName.Checked = true;
            this.rdoFinesBRName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoFinesBRName.Location = new System.Drawing.Point(26, 34);
            this.rdoFinesBRName.Name = "rdoFinesBRName";
            this.rdoFinesBRName.Size = new System.Drawing.Size(124, 23);
            this.rdoFinesBRName.TabIndex = 0;
            this.rdoFinesBRName.TabStop = true;
            this.rdoFinesBRName.Text = "Borrower Name";
            this.rdoFinesBRName.UseVisualStyleBackColor = true;
            // 
            // errorFines
            // 
            this.errorFines.AutoSize = true;
            this.errorFines.ForeColor = System.Drawing.Color.Maroon;
            this.errorFines.Location = new System.Drawing.Point(99, 302);
            this.errorFines.Name = "errorFines";
            this.errorFines.Size = new System.Drawing.Size(26, 19);
            this.errorFines.TabIndex = 8;
            this.errorFines.Text = "txt";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(2, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "Search Book Fines";
            // 
            // btnSearchFines
            // 
            this.btnSearchFines.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSearchFines.FlatAppearance.BorderSize = 2;
            this.btnSearchFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFines.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFines.Image = global::LibraryApplication.Properties.Resources.Search1;
            this.btnSearchFines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFines.Location = new System.Drawing.Point(175, 334);
            this.btnSearchFines.Name = "btnSearchFines";
            this.btnSearchFines.Size = new System.Drawing.Size(153, 31);
            this.btnSearchFines.TabIndex = 4;
            this.btnSearchFines.Text = "Search Fines";
            this.btnSearchFines.UseVisualStyleBackColor = true;
            this.btnSearchFines.Click += new System.EventHandler(this.btnSearchFines_Click);
            // 
            // txtFinesCardNumber
            // 
            this.txtFinesCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinesCardNumber.Enabled = false;
            this.txtFinesCardNumber.Location = new System.Drawing.Point(175, 225);
            this.txtFinesCardNumber.Name = "txtFinesCardNumber";
            this.txtFinesCardNumber.Size = new System.Drawing.Size(153, 25);
            this.txtFinesCardNumber.TabIndex = 2;
            this.txtFinesCardNumber.Text = "0";
            this.txtFinesCardNumber.TextChanged += new System.EventHandler(this.txtFinesCardNumber_TextChanged);
            this.txtFinesCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinesCardNumber_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(55, 189);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 19);
            this.label19.TabIndex = 2;
            this.label19.Text = "Borrower Name :";
            // 
            // Help
            // 
            this.Help.Controls.Add(this.panel10);
            this.Help.Location = new System.Drawing.Point(4, 26);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(1009, 436);
            this.Help.TabIndex = 4;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DimGray;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.pdfManual);
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1009, 433);
            this.panel10.TabIndex = 0;
            // 
            // pdfManual
            // 
            this.pdfManual.Enabled = true;
            this.pdfManual.Location = new System.Drawing.Point(-1, -1);
            this.pdfManual.Name = "pdfManual";
            this.pdfManual.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("pdfManual.OcxState")));
            this.pdfManual.Size = new System.Drawing.Size(1005, 433);
            this.pdfManual.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 482);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Opacity = 0.96D;
            this.Text = "Library Application";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.tabMainMenu.ResumeLayout(false);
            this.BookSearch.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdbookSerach)).EndInit();
            this.BorrowerManagement.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.BookLoans.ResumeLayout(false);
            this.tabLoans.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdCheckIn)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Fines.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdFines)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Help.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdfManual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabMainMenu;
        private System.Windows.Forms.TabPage BookSearch;
        private System.Windows.Forms.TabPage BorrowerManagement;
        private System.Windows.Forms.TabPage BookLoans;
        private System.Windows.Forms.TabPage Fines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage Help;
        private System.Windows.Forms.DataGridView gdbookSerach;
        private System.Windows.Forms.Label errorBookSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label errorBorrower;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddBr;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TabControl tabLoans;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label errorCheckOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtCheckOutBranchId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCheckOutCardNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCheckOutbookId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView gdCheckIn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label errorCheckIn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSearchCheckIn;
        private System.Windows.Forms.TextBox txtCheckInBRName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCheckInCardNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCheckInBookId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkBoxChekIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Card_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label notifyCheckIn;
        private System.Windows.Forms.Button btnCancelCheckIn;
        private System.Windows.Forms.Button btnBookCheckIn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label notifyFines;
        private System.Windows.Forms.Button btnFinesCancel;
        private System.Windows.Forms.Button btnFinesPayment;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label errorFines;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSearchFines;
        private System.Windows.Forms.TextBox txtFinesCardNumber;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCardNo;
        private System.Windows.Forms.CheckBox chkBRName;
        private System.Windows.Forms.CheckBox chkBookId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkBSAuthor;
        private System.Windows.Forms.CheckBox chkBSBookTitle;
        private System.Windows.Forms.CheckBox chkBSBookId;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label notifyUpdateFine;
        private System.Windows.Forms.Button btnUpdateFines;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoFinesCardNumber;
        private System.Windows.Forms.RadioButton rdoFinesBRName;
        private System.Windows.Forms.TextBox txtFinesTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView gdFines;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinesBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinesBranchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinesTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinesLoanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinesCardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinesFineAmount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtFinesBorrowerName;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox chkBSRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_of_copies;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_of_Available_copies;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel10;
        private AxAcroPDFLib.AxAcroPDF pdfManual;
    }
}