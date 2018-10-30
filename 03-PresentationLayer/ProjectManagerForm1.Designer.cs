namespace _03_PresentationLayer
{
    partial class ProjectManagerForm1
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
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.tbEmployeeAdd = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEmployeeRole = new System.Windows.Forms.ComboBox();
            this.eBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtELastName = new System.Windows.Forms.TextBox();
            this.txtEPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtETc = new System.Windows.Forms.MaskedTextBox();
            this.txtEAddress = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtEFirstName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.tbProjectManagement = new System.Windows.Forms.TabControl();
            this.tbNewProject = new System.Windows.Forms.TabPage();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbAllProject = new System.Windows.Forms.TabPage();
            this.dgvAllProject = new System.Windows.Forms.DataGridView();
            this.tbCustomerAdd = new System.Windows.Forms.TabPage();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.tbEmployeeAdd.SuspendLayout();
            this.tbProjectManagement.SuspendLayout();
            this.tbNewProject.SuspendLayout();
            this.tbAllProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProject)).BeginInit();
            this.tbCustomerAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(197, 97);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(171, 20);
            this.txtCompanyName.TabIndex = 51;
            // 
            // tbEmployeeAdd
            // 
            this.tbEmployeeAdd.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.tbEmployeeAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbEmployeeAdd.Controls.Add(this.label2);
            this.tbEmployeeAdd.Controls.Add(this.cmbEmployeeRole);
            this.tbEmployeeAdd.Controls.Add(this.eBirthDate);
            this.tbEmployeeAdd.Controls.Add(this.btnSaveEmployee);
            this.tbEmployeeAdd.Controls.Add(this.lblDateOfBirth);
            this.tbEmployeeAdd.Controls.Add(this.txtELastName);
            this.tbEmployeeAdd.Controls.Add(this.txtEPhone);
            this.tbEmployeeAdd.Controls.Add(this.txtETc);
            this.tbEmployeeAdd.Controls.Add(this.txtEAddress);
            this.tbEmployeeAdd.Controls.Add(this.txtEMail);
            this.tbEmployeeAdd.Controls.Add(this.txtEFirstName);
            this.tbEmployeeAdd.Controls.Add(this.lblAddress);
            this.tbEmployeeAdd.Controls.Add(this.lblPhone);
            this.tbEmployeeAdd.Controls.Add(this.lblMail);
            this.tbEmployeeAdd.Controls.Add(this.lblTC);
            this.tbEmployeeAdd.Controls.Add(this.lblLastName);
            this.tbEmployeeAdd.Controls.Add(this.lblFirstName);
            this.tbEmployeeAdd.Location = new System.Drawing.Point(4, 22);
            this.tbEmployeeAdd.Name = "tbEmployeeAdd";
            this.tbEmployeeAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tbEmployeeAdd.Size = new System.Drawing.Size(676, 435);
            this.tbEmployeeAdd.TabIndex = 3;
            this.tbEmployeeAdd.Tag = "tabEmployeeAdd";
            this.tbEmployeeAdd.Text = "EmployeeAdd";
            this.tbEmployeeAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(54, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Role :";
            // 
            // cmbEmployeeRole
            // 
            this.cmbEmployeeRole.FormattingEnabled = true;
            this.cmbEmployeeRole.Location = new System.Drawing.Point(180, 228);
            this.cmbEmployeeRole.Name = "cmbEmployeeRole";
            this.cmbEmployeeRole.Size = new System.Drawing.Size(181, 21);
            this.cmbEmployeeRole.TabIndex = 65;
            // 
            // eBirthDate
            // 
            this.eBirthDate.Location = new System.Drawing.Point(180, 100);
            this.eBirthDate.Name = "eBirthDate";
            this.eBirthDate.Size = new System.Drawing.Size(181, 20);
            this.eBirthDate.TabIndex = 64;
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.btnSaveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveEmployee.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSaveEmployee.Location = new System.Drawing.Point(217, 324);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(148, 40);
            this.btnSaveEmployee.TabIndex = 63;
            this.btnSaveEmployee.Text = "Save";
            this.btnSaveEmployee.UseVisualStyleBackColor = true;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateOfBirth.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDateOfBirth.Location = new System.Drawing.Point(54, 102);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(130, 20);
            this.lblDateOfBirth.TabIndex = 62;
            this.lblDateOfBirth.Text = "DateOfBirth :";
            // 
            // txtELastName
            // 
            this.txtELastName.Location = new System.Drawing.Point(180, 66);
            this.txtELastName.Name = "txtELastName";
            this.txtELastName.Size = new System.Drawing.Size(181, 20);
            this.txtELastName.TabIndex = 61;
            // 
            // txtEPhone
            // 
            this.txtEPhone.Location = new System.Drawing.Point(180, 202);
            this.txtEPhone.Mask = "(999) 000-0000";
            this.txtEPhone.Name = "txtEPhone";
            this.txtEPhone.Size = new System.Drawing.Size(181, 20);
            this.txtEPhone.TabIndex = 60;
            // 
            // txtETc
            // 
            this.txtETc.Location = new System.Drawing.Point(180, 168);
            this.txtETc.Name = "txtETc";
            this.txtETc.Size = new System.Drawing.Size(181, 20);
            this.txtETc.TabIndex = 59;
            // 
            // txtEAddress
            // 
            this.txtEAddress.Location = new System.Drawing.Point(180, 257);
            this.txtEAddress.Multiline = true;
            this.txtEAddress.Name = "txtEAddress";
            this.txtEAddress.Size = new System.Drawing.Size(185, 61);
            this.txtEAddress.TabIndex = 58;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(180, 134);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(181, 20);
            this.txtEMail.TabIndex = 57;
            // 
            // txtEFirstName
            // 
            this.txtEFirstName.Location = new System.Drawing.Point(180, 32);
            this.txtEFirstName.Name = "txtEFirstName";
            this.txtEFirstName.Size = new System.Drawing.Size(181, 20);
            this.txtEFirstName.TabIndex = 56;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAddress.Location = new System.Drawing.Point(54, 258);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(122, 20);
            this.lblAddress.TabIndex = 55;
            this.lblAddress.Text = "Address :";
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPhone.Location = new System.Drawing.Point(54, 201);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(130, 20);
            this.lblPhone.TabIndex = 54;
            this.lblPhone.Text = "Phone :";
            // 
            // lblMail
            // 
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMail.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMail.Location = new System.Drawing.Point(54, 133);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(130, 20);
            this.lblMail.TabIndex = 53;
            this.lblMail.Text = "E-Mail :";
            // 
            // lblTC
            // 
            this.lblTC.BackColor = System.Drawing.Color.Transparent;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTC.Location = new System.Drawing.Point(54, 167);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(112, 20);
            this.lblTC.TabIndex = 52;
            this.lblTC.Text = "T.C :";
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblLastName.Location = new System.Drawing.Point(54, 65);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(130, 20);
            this.lblLastName.TabIndex = 51;
            this.lblLastName.Text = "LastName :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFirstName.Location = new System.Drawing.Point(54, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(112, 20);
            this.lblFirstName.TabIndex = 50;
            this.lblFirstName.Text = "FirstName :";
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.btnSaveCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveCustomer.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSaveCustomer.Location = new System.Drawing.Point(220, 137);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(148, 40);
            this.btnSaveCustomer.TabIndex = 52;
            this.btnSaveCustomer.Text = "Save";
            this.btnSaveCustomer.UseVisualStyleBackColor = true;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(197, 58);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(171, 20);
            this.txtCustomerName.TabIndex = 50;
            // 
            // tbProjectManagement
            // 
            this.tbProjectManagement.Controls.Add(this.tbNewProject);
            this.tbProjectManagement.Controls.Add(this.tbAllProject);
            this.tbProjectManagement.Controls.Add(this.tbCustomerAdd);
            this.tbProjectManagement.Controls.Add(this.tbEmployeeAdd);
            this.tbProjectManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProjectManagement.Location = new System.Drawing.Point(0, 0);
            this.tbProjectManagement.Name = "tbProjectManagement";
            this.tbProjectManagement.SelectedIndex = 0;
            this.tbProjectManagement.Size = new System.Drawing.Size(684, 461);
            this.tbProjectManagement.TabIndex = 2;
            this.tbProjectManagement.Tag = "tabAllproject";
            // 
            // tbNewProject
            // 
            this.tbNewProject.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbNewProject.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.tbNewProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbNewProject.Controls.Add(this.lblProjectName);
            this.tbNewProject.Controls.Add(this.btnSave);
            this.tbNewProject.Controls.Add(this.cmbCustomer);
            this.tbNewProject.Controls.Add(this.label1);
            this.tbNewProject.Controls.Add(this.dtpStartDate);
            this.tbNewProject.Controls.Add(this.dtpEndDate);
            this.tbNewProject.Controls.Add(this.txtProjectName);
            this.tbNewProject.Controls.Add(this.lblStartDate);
            this.tbNewProject.Controls.Add(this.txtDescription);
            this.tbNewProject.Controls.Add(this.lblEndDate);
            this.tbNewProject.Controls.Add(this.lblDescription);
            this.tbNewProject.Location = new System.Drawing.Point(4, 22);
            this.tbNewProject.Name = "tbNewProject";
            this.tbNewProject.Padding = new System.Windows.Forms.Padding(3);
            this.tbNewProject.Size = new System.Drawing.Size(676, 435);
            this.tbNewProject.TabIndex = 0;
            this.tbNewProject.Tag = "tabNewProject";
            this.tbNewProject.Text = " New Project";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoEllipsis = true;
            this.lblProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblProjectName.Location = new System.Drawing.Point(72, 50);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(116, 18);
            this.lblProjectName.TabIndex = 61;
            this.lblProjectName.Text = "Project Name :";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(261, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 40);
            this.btnSave.TabIndex = 60;
            this.btnSave.Text = " Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(203, 154);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(206, 21);
            this.cmbCustomer.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(72, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Customer";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(203, 81);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(206, 20);
            this.dtpStartDate.TabIndex = 50;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(203, 117);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(206, 20);
            this.dtpEndDate.TabIndex = 51;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(203, 49);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(206, 20);
            this.txtProjectName.TabIndex = 57;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoEllipsis = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStartDate.Location = new System.Drawing.Point(72, 85);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(125, 16);
            this.lblStartDate.TabIndex = 52;
            this.lblStartDate.Text = "Start Date :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(203, 194);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(206, 50);
            this.txtDescription.TabIndex = 56;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoEllipsis = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEndDate.Location = new System.Drawing.Point(72, 121);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(125, 18);
            this.lblEndDate.TabIndex = 53;
            this.lblEndDate.Text = "End Date :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDescription.Location = new System.Drawing.Point(72, 195);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(103, 18);
            this.lblDescription.TabIndex = 55;
            this.lblDescription.Text = "Description :";
            // 
            // tbAllProject
            // 
            this.tbAllProject.Controls.Add(this.dgvAllProject);
            this.tbAllProject.Location = new System.Drawing.Point(4, 22);
            this.tbAllProject.Name = "tbAllProject";
            this.tbAllProject.Padding = new System.Windows.Forms.Padding(3);
            this.tbAllProject.Size = new System.Drawing.Size(676, 435);
            this.tbAllProject.TabIndex = 1;
            this.tbAllProject.Tag = "tabAllProject";
            this.tbAllProject.Text = "AllProject";
            this.tbAllProject.UseVisualStyleBackColor = true;
            // 
            // dgvAllProject
            // 
            this.dgvAllProject.AllowUserToAddRows = false;
            this.dgvAllProject.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAllProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAllProject.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAllProject.Location = new System.Drawing.Point(3, 20);
            this.dgvAllProject.Name = "dgvAllProject";
            this.dgvAllProject.Size = new System.Drawing.Size(670, 412);
            this.dgvAllProject.TabIndex = 38;
            // 
            // tbCustomerAdd
            // 
            this.tbCustomerAdd.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.tbCustomerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbCustomerAdd.Controls.Add(this.btnSaveCustomer);
            this.tbCustomerAdd.Controls.Add(this.txtCompanyName);
            this.tbCustomerAdd.Controls.Add(this.txtCustomerName);
            this.tbCustomerAdd.Controls.Add(this.lblCompanyName);
            this.tbCustomerAdd.Controls.Add(this.lblCustomerName);
            this.tbCustomerAdd.Location = new System.Drawing.Point(4, 22);
            this.tbCustomerAdd.Name = "tbCustomerAdd";
            this.tbCustomerAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tbCustomerAdd.Size = new System.Drawing.Size(676, 435);
            this.tbCustomerAdd.TabIndex = 2;
            this.tbCustomerAdd.Tag = "tabCustomerAdd";
            this.tbCustomerAdd.Text = "CustomerAdd";
            this.tbCustomerAdd.UseVisualStyleBackColor = true;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCompanyName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCompanyName.Location = new System.Drawing.Point(45, 98);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(146, 22);
            this.lblCompanyName.TabIndex = 49;
            this.lblCompanyName.Text = "Company Name : ";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCustomerName.Location = new System.Drawing.Point(44, 59);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(147, 20);
            this.lblCustomerName.TabIndex = 48;
            this.lblCustomerName.Text = "Customer Name : ";
            // 
            // ProjectManagerForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tbProjectManagement);
            this.Name = "ProjectManagerForm1";
            this.Text = "ProjectManagerForm1";
            this.Load += new System.EventHandler(this.ProjectManagerForm1_Load);
            this.tbEmployeeAdd.ResumeLayout(false);
            this.tbEmployeeAdd.PerformLayout();
            this.tbProjectManagement.ResumeLayout(false);
            this.tbNewProject.ResumeLayout(false);
            this.tbNewProject.PerformLayout();
            this.tbAllProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProject)).EndInit();
            this.tbCustomerAdd.ResumeLayout(false);
            this.tbCustomerAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TabPage tbEmployeeAdd;
        private System.Windows.Forms.DateTimePicker eBirthDate;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtELastName;
        private System.Windows.Forms.MaskedTextBox txtEPhone;
        private System.Windows.Forms.MaskedTextBox txtETc;
        private System.Windows.Forms.TextBox txtEAddress;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtEFirstName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TabControl tbProjectManagement;
        private System.Windows.Forms.TabPage tbNewProject;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TabPage tbAllProject;
        private System.Windows.Forms.DataGridView dgvAllProject;
        private System.Windows.Forms.TabPage tbCustomerAdd;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ComboBox cmbEmployeeRole;
        private System.Windows.Forms.Label label2;
    }
}