namespace _03_PresentationLayer
{
    partial class BusinessAnalystForm1
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
            this.tbCreateTask = new System.Windows.Forms.TabPage();
            this.btnAddTasks = new System.Windows.Forms.Button();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.cmbProjectName = new System.Windows.Forms.ComboBox();
            this.lblProjeName = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBusinessStartDate = new System.Windows.Forms.Label();
            this.lblBusinessEndDate = new System.Windows.Forms.Label();
            this.lblBusinessProjectName = new System.Windows.Forms.Label();
            this.tbTaskAssigment = new System.Windows.Forms.TabPage();
            this.btnAssignment = new System.Windows.Forms.Button();
            this.cmbProjectAssignment = new System.Windows.Forms.ComboBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.cmbTaskAssignment = new System.Windows.Forms.ComboBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.cmbEmployeeName = new System.Windows.Forms.ComboBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.tbBusinessAnalyst = new System.Windows.Forms.TabControl();
            this.tbCreateTask.SuspendLayout();
            this.tbTaskAssigment.SuspendLayout();
            this.tbBusinessAnalyst.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCreateTask
            // 
            this.tbCreateTask.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.tbCreateTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbCreateTask.Controls.Add(this.btnAddTasks);
            this.tbCreateTask.Controls.Add(this.txtTaskName);
            this.tbCreateTask.Controls.Add(this.cmbProjectName);
            this.tbCreateTask.Controls.Add(this.lblProjeName);
            this.tbCreateTask.Controls.Add(this.dtpStartDate);
            this.tbCreateTask.Controls.Add(this.cmbState);
            this.tbCreateTask.Controls.Add(this.dtpEndDate);
            this.tbCreateTask.Controls.Add(this.label1);
            this.tbCreateTask.Controls.Add(this.lblBusinessStartDate);
            this.tbCreateTask.Controls.Add(this.lblBusinessEndDate);
            this.tbCreateTask.Controls.Add(this.lblBusinessProjectName);
            this.tbCreateTask.Location = new System.Drawing.Point(4, 22);
            this.tbCreateTask.Name = "tbCreateTask";
            this.tbCreateTask.Padding = new System.Windows.Forms.Padding(3);
            this.tbCreateTask.Size = new System.Drawing.Size(582, 357);
            this.tbCreateTask.TabIndex = 1;
            this.tbCreateTask.Text = "CreateTask";
            this.tbCreateTask.UseVisualStyleBackColor = true;
            this.tbCreateTask.Click += new System.EventHandler(this.tbCreateTask_Click);
            // 
            // btnAddTasks
            // 
            this.btnAddTasks.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.btnAddTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddTasks.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddTasks.Location = new System.Drawing.Point(208, 234);
            this.btnAddTasks.Name = "btnAddTasks";
            this.btnAddTasks.Size = new System.Drawing.Size(80, 31);
            this.btnAddTasks.TabIndex = 61;
            this.btnAddTasks.Text = "Add";
            this.btnAddTasks.UseVisualStyleBackColor = true;
            this.btnAddTasks.Click += new System.EventHandler(this.btnAddTasks_Click);
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(124, 65);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(164, 20);
            this.txtTaskName.TabIndex = 30;
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.FormattingEnabled = true;
            this.cmbProjectName.Location = new System.Drawing.Point(124, 20);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(164, 21);
            this.cmbProjectName.TabIndex = 34;
            // 
            // lblProjeName
            // 
            this.lblProjeName.BackColor = System.Drawing.Color.Transparent;
            this.lblProjeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjeName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblProjeName.Location = new System.Drawing.Point(22, 23);
            this.lblProjeName.Name = "lblProjeName";
            this.lblProjeName.Size = new System.Drawing.Size(64, 18);
            this.lblProjeName.TabIndex = 33;
            this.lblProjeName.Text = "Proje Name:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(124, 101);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(164, 20);
            this.dtpStartDate.TabIndex = 25;
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(124, 188);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(164, 21);
            this.cmbState.TabIndex = 32;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(124, 143);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(164, 20);
            this.dtpEndDate.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(22, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "State:";
            // 
            // lblBusinessStartDate
            // 
            this.lblBusinessStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBusinessStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBusinessStartDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBusinessStartDate.Location = new System.Drawing.Point(22, 107);
            this.lblBusinessStartDate.Name = "lblBusinessStartDate";
            this.lblBusinessStartDate.Size = new System.Drawing.Size(93, 14);
            this.lblBusinessStartDate.TabIndex = 27;
            this.lblBusinessStartDate.Text = "Start Date :";
            // 
            // lblBusinessEndDate
            // 
            this.lblBusinessEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblBusinessEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBusinessEndDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBusinessEndDate.Location = new System.Drawing.Point(22, 149);
            this.lblBusinessEndDate.Name = "lblBusinessEndDate";
            this.lblBusinessEndDate.Size = new System.Drawing.Size(81, 14);
            this.lblBusinessEndDate.TabIndex = 28;
            this.lblBusinessEndDate.Text = "End Date :";
            // 
            // lblBusinessProjectName
            // 
            this.lblBusinessProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblBusinessProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBusinessProjectName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblBusinessProjectName.Location = new System.Drawing.Point(22, 68);
            this.lblBusinessProjectName.Name = "lblBusinessProjectName";
            this.lblBusinessProjectName.Size = new System.Drawing.Size(98, 17);
            this.lblBusinessProjectName.TabIndex = 29;
            this.lblBusinessProjectName.Text = "Task Name :";
            // 
            // tbTaskAssigment
            // 
            this.tbTaskAssigment.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.tbTaskAssigment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTaskAssigment.Controls.Add(this.btnAssignment);
            this.tbTaskAssigment.Controls.Add(this.cmbProjectAssignment);
            this.tbTaskAssigment.Controls.Add(this.lblProjectName);
            this.tbTaskAssigment.Controls.Add(this.cmbTaskAssignment);
            this.tbTaskAssigment.Controls.Add(this.lblTaskName);
            this.tbTaskAssigment.Controls.Add(this.cmbEmployeeName);
            this.tbTaskAssigment.Controls.Add(this.lblEmployeeName);
            this.tbTaskAssigment.ForeColor = System.Drawing.SystemColors.Window;
            this.tbTaskAssigment.Location = new System.Drawing.Point(4, 22);
            this.tbTaskAssigment.Name = "tbTaskAssigment";
            this.tbTaskAssigment.Padding = new System.Windows.Forms.Padding(3);
            this.tbTaskAssigment.Size = new System.Drawing.Size(582, 357);
            this.tbTaskAssigment.TabIndex = 0;
            this.tbTaskAssigment.Text = "TaskAssigment";
            this.tbTaskAssigment.UseVisualStyleBackColor = true;
            this.tbTaskAssigment.Click += new System.EventHandler(this.tbTaskAssigment_Click);
            // 
            // btnAssignment
            // 
            this.btnAssignment.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.btnAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAssignment.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAssignment.Location = new System.Drawing.Point(198, 186);
            this.btnAssignment.Name = "btnAssignment";
            this.btnAssignment.Size = new System.Drawing.Size(115, 44);
            this.btnAssignment.TabIndex = 62;
            this.btnAssignment.Text = "Assignment";
            this.btnAssignment.UseVisualStyleBackColor = true;
            this.btnAssignment.Click += new System.EventHandler(this.btnAssignment_Click);
            // 
            // cmbProjectAssignment
            // 
            this.cmbProjectAssignment.FormattingEnabled = true;
            this.cmbProjectAssignment.Location = new System.Drawing.Point(172, 91);
            this.cmbProjectAssignment.Name = "cmbProjectAssignment";
            this.cmbProjectAssignment.Size = new System.Drawing.Size(141, 21);
            this.cmbProjectAssignment.TabIndex = 47;
            this.cmbProjectAssignment.SelectedIndexChanged += new System.EventHandler(this.cmbProjectAssignment_SelectedIndexChanged);
            // 
            // lblProjectName
            // 
            this.lblProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblProjectName.Location = new System.Drawing.Point(72, 93);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(81, 18);
            this.lblProjectName.TabIndex = 46;
            this.lblProjectName.Text = "Project Name:";
            // 
            // cmbTaskAssignment
            // 
            this.cmbTaskAssignment.FormattingEnabled = true;
            this.cmbTaskAssignment.Location = new System.Drawing.Point(172, 130);
            this.cmbTaskAssignment.Name = "cmbTaskAssignment";
            this.cmbTaskAssignment.Size = new System.Drawing.Size(141, 21);
            this.cmbTaskAssignment.TabIndex = 45;
            // 
            // lblTaskName
            // 
            this.lblTaskName.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaskName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTaskName.Location = new System.Drawing.Point(72, 130);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(72, 18);
            this.lblTaskName.TabIndex = 44;
            this.lblTaskName.Text = "Task Name:";
            // 
            // cmbEmployeeName
            // 
            this.cmbEmployeeName.FormattingEnabled = true;
            this.cmbEmployeeName.Location = new System.Drawing.Point(172, 56);
            this.cmbEmployeeName.Name = "cmbEmployeeName";
            this.cmbEmployeeName.Size = new System.Drawing.Size(141, 21);
            this.cmbEmployeeName.TabIndex = 43;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmployeeName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEmployeeName.Location = new System.Drawing.Point(72, 56);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(94, 18);
            this.lblEmployeeName.TabIndex = 42;
            this.lblEmployeeName.Text = "Employee Name:";
            // 
            // tbBusinessAnalyst
            // 
            this.tbBusinessAnalyst.Controls.Add(this.tbTaskAssigment);
            this.tbBusinessAnalyst.Controls.Add(this.tbCreateTask);
            this.tbBusinessAnalyst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBusinessAnalyst.Location = new System.Drawing.Point(0, 0);
            this.tbBusinessAnalyst.Name = "tbBusinessAnalyst";
            this.tbBusinessAnalyst.SelectedIndex = 0;
            this.tbBusinessAnalyst.Size = new System.Drawing.Size(590, 383);
            this.tbBusinessAnalyst.TabIndex = 3;
            this.tbBusinessAnalyst.Click += new System.EventHandler(this.tbBusinessAnalyst_Click);
            // 
            // BusinessAnalystForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 383);
            this.Controls.Add(this.tbBusinessAnalyst);
            this.Name = "BusinessAnalystForm1";
            this.Text = "BusinessAnalystForm1";
            this.Load += new System.EventHandler(this.BusinessAnalystForm1_Load);
            this.tbCreateTask.ResumeLayout(false);
            this.tbCreateTask.PerformLayout();
            this.tbTaskAssigment.ResumeLayout(false);
            this.tbBusinessAnalyst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbCreateTask;
        private System.Windows.Forms.Button btnAddTasks;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.ComboBox cmbProjectName;
        private System.Windows.Forms.Label lblProjeName;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBusinessStartDate;
        private System.Windows.Forms.Label lblBusinessEndDate;
        private System.Windows.Forms.Label lblBusinessProjectName;
        private System.Windows.Forms.TabPage tbTaskAssigment;
        private System.Windows.Forms.Button btnAssignment;
        private System.Windows.Forms.ComboBox cmbProjectAssignment;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.ComboBox cmbTaskAssignment;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.ComboBox cmbEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TabControl tbBusinessAnalyst;
    }
}