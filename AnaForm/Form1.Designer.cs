namespace AnaForm
{
    partial class Form1
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
            this.grpProjectManager = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.lblCustomerFirstName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMusteriKaydı = new System.Windows.Forms.Button();
            this.btnProjectClose = new System.Windows.Forms.Button();
            this.ProjectOpen = new System.Windows.Forms.Button();
            this.dgwProject = new System.Windows.Forms.DataGridView();
            this.grpTeamLeader = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStatusControl = new System.Windows.Forms.Button();
            this.btnWorkingConditionUpdate = new System.Windows.Forms.Button();
            this.grpTamLeaderStatus = new System.Windows.Forms.GroupBox();
            this.grpBusinessAnalyst = new System.Windows.Forms.GroupBox();
            this.btnDocumantation = new System.Windows.Forms.Button();
            this.btnTaskAnalystUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grpTestSpecialist = new System.Windows.Forms.GroupBox();
            this.lblProjectTest = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.grpSoftwareDeveloper = new System.Windows.Forms.GroupBox();
            this.btnEndProject = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projeYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projeSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calısanEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpEmployeeAdd = new System.Windows.Forms.GroupBox();
            this.mskdPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmpAddress = new System.Windows.Forms.TextBox();
            this.txtEmployeeLastN = new System.Windows.Forms.TextBox();
            this.txtEmployeeFirstN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMAil = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblEmployeeLastN = new System.Windows.Forms.Label();
            this.lblEmployeeFirstN = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.customerAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpProjectManager.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProject)).BeginInit();
            this.grpTeamLeader.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpBusinessAnalyst.SuspendLayout();
            this.grpTestSpecialist.SuspendLayout();
            this.grpSoftwareDeveloper.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpEmployeeAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProjectManager
            // 
            this.grpProjectManager.Controls.Add(this.groupBox3);
            this.grpProjectManager.Controls.Add(this.groupBox1);
            this.grpProjectManager.Controls.Add(this.btnMusteriKaydı);
            this.grpProjectManager.Controls.Add(this.btnProjectClose);
            this.grpProjectManager.Controls.Add(this.ProjectOpen);
            this.grpProjectManager.Location = new System.Drawing.Point(12, 37);
            this.grpProjectManager.Name = "grpProjectManager";
            this.grpProjectManager.Size = new System.Drawing.Size(437, 317);
            this.grpProjectManager.TabIndex = 0;
            this.grpProjectManager.TabStop = false;
            this.grpProjectManager.Text = "Project Manager";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbCompanyName);
            this.groupBox3.Controls.Add(this.txtLastName);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.lblCompanyName);
            this.groupBox3.Controls.Add(this.lblCustomerLastName);
            this.groupBox3.Controls.Add(this.lblCustomerFirstName);
            this.groupBox3.Location = new System.Drawing.Point(198, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 162);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CustomerRegistration";
            // 
            // cmbCompanyName
            // 
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(105, 94);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(121, 21);
            this.cmbCompanyName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(105, 67);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(5, 97);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(85, 13);
            this.lblCompanyName.TabIndex = 4;
            this.lblCompanyName.Text = "CompanyName :";
            this.lblCompanyName.Click += new System.EventHandler(this.lblCompanyName_Click);
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Location = new System.Drawing.Point(5, 67);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(61, 13);
            this.lblCustomerLastName.TabIndex = 3;
            this.lblCustomerLastName.Text = "LastName :";
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.AutoSize = true;
            this.lblCustomerFirstName.Location = new System.Drawing.Point(6, 30);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblCustomerFirstName.TabIndex = 2;
            this.lblCustomerFirstName.Text = "FirstName :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "grpOpenProject";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(104, 71);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Starting Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Time";
            // 
            // btnMusteriKaydı
            // 
            this.btnMusteriKaydı.Location = new System.Drawing.Point(37, 145);
            this.btnMusteriKaydı.Name = "btnMusteriKaydı";
            this.btnMusteriKaydı.Size = new System.Drawing.Size(121, 23);
            this.btnMusteriKaydı.TabIndex = 2;
            this.btnMusteriKaydı.Text = "Customer Registration";
            this.btnMusteriKaydı.UseVisualStyleBackColor = true;
            this.btnMusteriKaydı.Click += new System.EventHandler(this.btnMusteriKaydı_Click);
            // 
            // btnProjectClose
            // 
            this.btnProjectClose.Location = new System.Drawing.Point(37, 98);
            this.btnProjectClose.Name = "btnProjectClose";
            this.btnProjectClose.Size = new System.Drawing.Size(121, 23);
            this.btnProjectClose.TabIndex = 1;
            this.btnProjectClose.Text = "Project Close";
            this.btnProjectClose.UseVisualStyleBackColor = true;
            // 
            // ProjectOpen
            // 
            this.ProjectOpen.Location = new System.Drawing.Point(37, 52);
            this.ProjectOpen.Name = "ProjectOpen";
            this.ProjectOpen.Size = new System.Drawing.Size(121, 23);
            this.ProjectOpen.TabIndex = 0;
            this.ProjectOpen.Text = "ProjectOpen";
            this.ProjectOpen.UseVisualStyleBackColor = true;
            this.ProjectOpen.Click += new System.EventHandler(this.ProjectOpen_Click);
            // 
            // dgwProject
            // 
            this.dgwProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProject.Location = new System.Drawing.Point(469, 22);
            this.dgwProject.Name = "dgwProject";
            this.dgwProject.Size = new System.Drawing.Size(240, 212);
            this.dgwProject.TabIndex = 4;
            // 
            // grpTeamLeader
            // 
            this.grpTeamLeader.Controls.Add(this.groupBox2);
            this.grpTeamLeader.Controls.Add(this.grpTamLeaderStatus);
            this.grpTeamLeader.Location = new System.Drawing.Point(12, 370);
            this.grpTeamLeader.Name = "grpTeamLeader";
            this.grpTeamLeader.Size = new System.Drawing.Size(437, 174);
            this.grpTeamLeader.TabIndex = 5;
            this.grpTeamLeader.TabStop = false;
            this.grpTeamLeader.Text = "Team Leader";
            this.grpTeamLeader.Enter += new System.EventHandler(this.grpTeamLeader_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStatusControl);
            this.groupBox2.Controls.Add(this.btnWorkingConditionUpdate);
            this.groupBox2.Location = new System.Drawing.Point(6, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 123);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Working Condition";
            // 
            // btnStatusControl
            // 
            this.btnStatusControl.Location = new System.Drawing.Point(21, 57);
            this.btnStatusControl.Name = "btnStatusControl";
            this.btnStatusControl.Size = new System.Drawing.Size(106, 23);
            this.btnStatusControl.TabIndex = 2;
            this.btnStatusControl.Text = "Status Control";
            this.btnStatusControl.UseVisualStyleBackColor = true;
            // 
            // btnWorkingConditionUpdate
            // 
            this.btnWorkingConditionUpdate.Location = new System.Drawing.Point(21, 86);
            this.btnWorkingConditionUpdate.Name = "btnWorkingConditionUpdate";
            this.btnWorkingConditionUpdate.Size = new System.Drawing.Size(106, 23);
            this.btnWorkingConditionUpdate.TabIndex = 4;
            this.btnWorkingConditionUpdate.Text = "Status Update";
            this.btnWorkingConditionUpdate.UseVisualStyleBackColor = true;
            // 
            // grpTamLeaderStatus
            // 
            this.grpTamLeaderStatus.Location = new System.Drawing.Point(164, 19);
            this.grpTamLeaderStatus.Name = "grpTamLeaderStatus";
            this.grpTamLeaderStatus.Size = new System.Drawing.Size(239, 141);
            this.grpTamLeaderStatus.TabIndex = 1;
            this.grpTamLeaderStatus.TabStop = false;
            this.grpTamLeaderStatus.Text = "TeamLeaderStatus";
            // 
            // grpBusinessAnalyst
            // 
            this.grpBusinessAnalyst.Controls.Add(this.btnDocumantation);
            this.grpBusinessAnalyst.Controls.Add(this.btnTaskAnalystUpdate);
            this.grpBusinessAnalyst.Controls.Add(this.label4);
            this.grpBusinessAnalyst.Location = new System.Drawing.Point(469, 254);
            this.grpBusinessAnalyst.Name = "grpBusinessAnalyst";
            this.grpBusinessAnalyst.Size = new System.Drawing.Size(294, 119);
            this.grpBusinessAnalyst.TabIndex = 6;
            this.grpBusinessAnalyst.TabStop = false;
            this.grpBusinessAnalyst.Text = "Business Analyst";
            // 
            // btnDocumantation
            // 
            this.btnDocumantation.Location = new System.Drawing.Point(89, 33);
            this.btnDocumantation.Name = "btnDocumantation";
            this.btnDocumantation.Size = new System.Drawing.Size(103, 23);
            this.btnDocumantation.TabIndex = 0;
            this.btnDocumantation.Text = "Documantation";
            this.btnDocumantation.UseVisualStyleBackColor = true;
            // 
            // btnTaskAnalystUpdate
            // 
            this.btnTaskAnalystUpdate.Location = new System.Drawing.Point(89, 62);
            this.btnTaskAnalystUpdate.Name = "btnTaskAnalystUpdate";
            this.btnTaskAnalystUpdate.Size = new System.Drawing.Size(103, 23);
            this.btnTaskAnalystUpdate.TabIndex = 1;
            this.btnTaskAnalystUpdate.Text = "Update";
            this.btnTaskAnalystUpdate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Task Analyst";
            // 
            // grpTestSpecialist
            // 
            this.grpTestSpecialist.Controls.Add(this.lblProjectTest);
            this.grpTestSpecialist.Controls.Add(this.btnTest);
            this.grpTestSpecialist.Location = new System.Drawing.Point(469, 380);
            this.grpTestSpecialist.Name = "grpTestSpecialist";
            this.grpTestSpecialist.Size = new System.Drawing.Size(273, 69);
            this.grpTestSpecialist.TabIndex = 7;
            this.grpTestSpecialist.TabStop = false;
            this.grpTestSpecialist.Text = "Test Specialist";
            // 
            // lblProjectTest
            // 
            this.lblProjectTest.AutoSize = true;
            this.lblProjectTest.Location = new System.Drawing.Point(6, 24);
            this.lblProjectTest.Name = "lblProjectTest";
            this.lblProjectTest.Size = new System.Drawing.Size(64, 13);
            this.lblProjectTest.TabIndex = 1;
            this.lblProjectTest.Text = "Project Test";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(89, 19);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test ";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // grpSoftwareDeveloper
            // 
            this.grpSoftwareDeveloper.Controls.Add(this.btnEndProject);
            this.grpSoftwareDeveloper.Location = new System.Drawing.Point(469, 455);
            this.grpSoftwareDeveloper.Name = "grpSoftwareDeveloper";
            this.grpSoftwareDeveloper.Size = new System.Drawing.Size(200, 89);
            this.grpSoftwareDeveloper.TabIndex = 2;
            this.grpSoftwareDeveloper.TabStop = false;
            this.grpSoftwareDeveloper.Text = "Software Developer";
            // 
            // btnEndProject
            // 
            this.btnEndProject.Location = new System.Drawing.Point(31, 19);
            this.btnEndProject.Name = "btnEndProject";
            this.btnEndProject.Size = new System.Drawing.Size(75, 23);
            this.btnEndProject.TabIndex = 0;
            this.btnEndProject.Text = "Project Ends";
            this.btnEndProject.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projeYönetimiToolStripMenuItem,
            this.müşteriBilgileriToolStripMenuItem,
            this.taskManagerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projeYönetimiToolStripMenuItem
            // 
            this.projeYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projeEkleToolStripMenuItem,
            this.projeSilToolStripMenuItem,
            this.calısanEkleToolStripMenuItem});
            this.projeYönetimiToolStripMenuItem.Name = "projeYönetimiToolStripMenuItem";
            this.projeYönetimiToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.projeYönetimiToolStripMenuItem.Text = "Proje Yönetimi";
            // 
            // projeEkleToolStripMenuItem
            // 
            this.projeEkleToolStripMenuItem.Name = "projeEkleToolStripMenuItem";
            this.projeEkleToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.projeEkleToolStripMenuItem.Text = "Proje Ekle";
            // 
            // projeSilToolStripMenuItem
            // 
            this.projeSilToolStripMenuItem.Name = "projeSilToolStripMenuItem";
            this.projeSilToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.projeSilToolStripMenuItem.Text = "Proje Sil";
            // 
            // calısanEkleToolStripMenuItem
            // 
            this.calısanEkleToolStripMenuItem.Name = "calısanEkleToolStripMenuItem";
            this.calısanEkleToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.calısanEkleToolStripMenuItem.Text = "Calısan Ekle";
            // 
            // müşteriBilgileriToolStripMenuItem
            // 
            this.müşteriBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerAddToolStripMenuItem});
            this.müşteriBilgileriToolStripMenuItem.Name = "müşteriBilgileriToolStripMenuItem";
            this.müşteriBilgileriToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.müşteriBilgileriToolStripMenuItem.Text = "Müşteri Bilgileri";
            // 
            // taskManagerToolStripMenuItem
            // 
            this.taskManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskAddToolStripMenuItem});
            this.taskManagerToolStripMenuItem.Name = "taskManagerToolStripMenuItem";
            this.taskManagerToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.taskManagerToolStripMenuItem.Text = "TaskManager";
            // 
            // taskAddToolStripMenuItem
            // 
            this.taskAddToolStripMenuItem.Name = "taskAddToolStripMenuItem";
            this.taskAddToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.taskAddToolStripMenuItem.Text = "Task Add";
            // 
            // grpEmployeeAdd
            // 
            this.grpEmployeeAdd.Controls.Add(this.radioButton2);
            this.grpEmployeeAdd.Controls.Add(this.radioButton1);
            this.grpEmployeeAdd.Controls.Add(this.maskedTextBox2);
            this.grpEmployeeAdd.Controls.Add(this.dateTimePicker3);
            this.grpEmployeeAdd.Controls.Add(this.label6);
            this.grpEmployeeAdd.Controls.Add(this.maskedTextBox1);
            this.grpEmployeeAdd.Controls.Add(this.lblGender);
            this.grpEmployeeAdd.Controls.Add(this.mskdPhone);
            this.grpEmployeeAdd.Controls.Add(this.txtEmpAddress);
            this.grpEmployeeAdd.Controls.Add(this.txtEmployeeLastN);
            this.grpEmployeeAdd.Controls.Add(this.txtEmployeeFirstN);
            this.grpEmployeeAdd.Controls.Add(this.label3);
            this.grpEmployeeAdd.Controls.Add(this.label5);
            this.grpEmployeeAdd.Controls.Add(this.lblMAil);
            this.grpEmployeeAdd.Controls.Add(this.lblTC);
            this.grpEmployeeAdd.Controls.Add(this.lblEmployeeLastN);
            this.grpEmployeeAdd.Controls.Add(this.lblEmployeeFirstN);
            this.grpEmployeeAdd.Location = new System.Drawing.Point(439, 33);
            this.grpEmployeeAdd.Name = "grpEmployeeAdd";
            this.grpEmployeeAdd.Size = new System.Drawing.Size(303, 340);
            this.grpEmployeeAdd.TabIndex = 8;
            this.grpEmployeeAdd.TabStop = false;
            this.grpEmployeeAdd.Text = "Employee ";
            this.grpEmployeeAdd.Enter += new System.EventHandler(this.grpEmployeeAdd_Enter);
            // 
            // mskdPhone
            // 
            this.mskdPhone.Location = new System.Drawing.Point(79, 226);
            this.mskdPhone.Mask = "(999) 000-0000";
            this.mskdPhone.Name = "mskdPhone";
            this.mskdPhone.Size = new System.Drawing.Size(100, 20);
            this.mskdPhone.TabIndex = 9;
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.Location = new System.Drawing.Point(79, 260);
            this.txtEmpAddress.Multiline = true;
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Size = new System.Drawing.Size(173, 71);
            this.txtEmpAddress.TabIndex = 8;
            // 
            // txtEmployeeLastN
            // 
            this.txtEmployeeLastN.Location = new System.Drawing.Point(82, 54);
            this.txtEmployeeLastN.Name = "txtEmployeeLastN";
            this.txtEmployeeLastN.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeLastN.TabIndex = 7;
            // 
            // txtEmployeeFirstN
            // 
            this.txtEmployeeFirstN.Location = new System.Drawing.Point(82, 30);
            this.txtEmployeeFirstN.Name = "txtEmployeeFirstN";
            this.txtEmployeeFirstN.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeFirstN.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address :";
            // 
            // lblMAil
            // 
            this.lblMAil.AutoSize = true;
            this.lblMAil.Location = new System.Drawing.Point(6, 198);
            this.lblMAil.Name = "lblMAil";
            this.lblMAil.Size = new System.Drawing.Size(42, 13);
            this.lblMAil.TabIndex = 3;
            this.lblMAil.Text = "E-Mail :";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(7, 130);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(30, 13);
            this.lblTC.TabIndex = 2;
            this.lblTC.Text = "T.C :";
            // 
            // lblEmployeeLastN
            // 
            this.lblEmployeeLastN.AutoSize = true;
            this.lblEmployeeLastN.Location = new System.Drawing.Point(7, 62);
            this.lblEmployeeLastN.Name = "lblEmployeeLastN";
            this.lblEmployeeLastN.Size = new System.Drawing.Size(61, 13);
            this.lblEmployeeLastN.TabIndex = 1;
            this.lblEmployeeLastN.Text = "LastName :";
            // 
            // lblEmployeeFirstN
            // 
            this.lblEmployeeFirstN.AutoSize = true;
            this.lblEmployeeFirstN.Location = new System.Drawing.Point(6, 30);
            this.lblEmployeeFirstN.Name = "lblEmployeeFirstN";
            this.lblEmployeeFirstN.Size = new System.Drawing.Size(60, 13);
            this.lblEmployeeFirstN.TabIndex = 0;
            this.lblEmployeeFirstN.Text = "FirstName :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(9, 94);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 13);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender :";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(82, 122);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "DateOfBirth : ";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(82, 159);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker3.TabIndex = 15;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(79, 195);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(143, 20);
            this.maskedTextBox2.TabIndex = 16;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(82, 89);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Female ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(167, 89);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 17);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Male";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // customerAddToolStripMenuItem
            // 
            this.customerAddToolStripMenuItem.Name = "customerAddToolStripMenuItem";
            this.customerAddToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customerAddToolStripMenuItem.Text = "Customer Add";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 618);
            this.Controls.Add(this.grpEmployeeAdd);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpSoftwareDeveloper);
            this.Controls.Add(this.grpTestSpecialist);
            this.Controls.Add(this.grpBusinessAnalyst);
            this.Controls.Add(this.grpTeamLeader);
            this.Controls.Add(this.dgwProject);
            this.Controls.Add(this.grpProjectManager);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpProjectManager.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProject)).EndInit();
            this.grpTeamLeader.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grpBusinessAnalyst.ResumeLayout(false);
            this.grpBusinessAnalyst.PerformLayout();
            this.grpTestSpecialist.ResumeLayout(false);
            this.grpTestSpecialist.PerformLayout();
            this.grpSoftwareDeveloper.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpEmployeeAdd.ResumeLayout(false);
            this.grpEmployeeAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProjectManager;
        private System.Windows.Forms.Button ProjectOpen;
        private System.Windows.Forms.Button btnMusteriKaydı;
        private System.Windows.Forms.Button btnProjectClose;
        private System.Windows.Forms.DataGridView dgwProject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTeamLeader;
        private System.Windows.Forms.GroupBox grpTamLeaderStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnWorkingConditionUpdate;
        private System.Windows.Forms.Button btnStatusControl;
        private System.Windows.Forms.GroupBox grpBusinessAnalyst;
        private System.Windows.Forms.Button btnTaskAnalystUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDocumantation;
        private System.Windows.Forms.GroupBox grpTestSpecialist;
        private System.Windows.Forms.Label lblProjectTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.GroupBox grpSoftwareDeveloper;
        private System.Windows.Forms.Button btnEndProject;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.Label lblCustomerFirstName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projeYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projeSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskAddToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpEmployeeAdd;
        private System.Windows.Forms.Label lblMAil;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblEmployeeLastN;
        private System.Windows.Forms.Label lblEmployeeFirstN;
        private System.Windows.Forms.ComboBox cmbCompanyName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem calısanEkleToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox mskdPhone;
        private System.Windows.Forms.TextBox txtEmpAddress;
        private System.Windows.Forms.TextBox txtEmployeeLastN;
        private System.Windows.Forms.TextBox txtEmployeeFirstN;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolStripMenuItem customerAddToolStripMenuItem;
    }
}

