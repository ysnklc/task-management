namespace _03_PresentationLayer
{
    partial class TeamLeaderForm1
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
            this.dgwList = new System.Windows.Forms.DataGridView();
            this.lblTeamProjectName = new System.Windows.Forms.Label();
            this.cmbProjectGetTask = new System.Windows.Forms.ComboBox();
            this.tbGetProjectAllTask = new System.Windows.Forms.TabPage();
            this.lblProjectName1 = new System.Windows.Forms.Label();
            this.dgwUpdate = new System.Windows.Forms.DataGridView();
            this.cmbState2 = new System.Windows.Forms.ComboBox();
            this.tbUpdateTask = new System.Windows.Forms.TabPage();
            this.lblState1 = new System.Windows.Forms.Label();
            this.lblFinishDate1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpFinishDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpStartingDate2 = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtTaskName2 = new System.Windows.Forms.TextBox();
            this.lblTasksName = new System.Windows.Forms.Label();
            this.tbTeamLeader = new System.Windows.Forms.TabControl();
            this.tbCreateTask = new System.Windows.Forms.TabPage();
            this.cmbProjectName = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.dtpFinishDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartingDate = new System.Windows.Forms.DateTimePicker();
            this.lblFinishDate = new System.Windows.Forms.Label();
            this.lblStartingDate = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.teamLeaderManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getProjectAllTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).BeginInit();
            this.tbGetProjectAllTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUpdate)).BeginInit();
            this.tbUpdateTask.SuspendLayout();
            this.tbTeamLeader.SuspendLayout();
            this.tbCreateTask.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwList
            // 
            this.dgwList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwList.Location = new System.Drawing.Point(6, 33);
            this.dgwList.Name = "dgwList";
            this.dgwList.Size = new System.Drawing.Size(625, 330);
            this.dgwList.TabIndex = 31;
            // 
            // lblTeamProjectName
            // 
            this.lblTeamProjectName.AutoSize = true;
            this.lblTeamProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeamProjectName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTeamProjectName.Location = new System.Drawing.Point(150, 32);
            this.lblTeamProjectName.Name = "lblTeamProjectName";
            this.lblTeamProjectName.Size = new System.Drawing.Size(114, 16);
            this.lblTeamProjectName.TabIndex = 30;
            this.lblTeamProjectName.Text = "Project  Name: ";
            // 
            // cmbProjectGetTask
            // 
            this.cmbProjectGetTask.FormattingEnabled = true;
            this.cmbProjectGetTask.Location = new System.Drawing.Point(233, 8);
            this.cmbProjectGetTask.Name = "cmbProjectGetTask";
            this.cmbProjectGetTask.Size = new System.Drawing.Size(150, 21);
            this.cmbProjectGetTask.TabIndex = 29;
            this.cmbProjectGetTask.SelectedIndexChanged += new System.EventHandler(this.cmbProjectGetTask_SelectedIndexChanged);
            // 
            // tbGetProjectAllTask
            // 
            this.tbGetProjectAllTask.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.tbGetProjectAllTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbGetProjectAllTask.Controls.Add(this.lblProjectName1);
            this.tbGetProjectAllTask.Controls.Add(this.dgwList);
            this.tbGetProjectAllTask.Controls.Add(this.lblTeamProjectName);
            this.tbGetProjectAllTask.Controls.Add(this.cmbProjectGetTask);
            this.tbGetProjectAllTask.Location = new System.Drawing.Point(4, 22);
            this.tbGetProjectAllTask.Name = "tbGetProjectAllTask";
            this.tbGetProjectAllTask.Padding = new System.Windows.Forms.Padding(3);
            this.tbGetProjectAllTask.Size = new System.Drawing.Size(765, 411);
            this.tbGetProjectAllTask.TabIndex = 2;
            this.tbGetProjectAllTask.Text = "GetProjectAllTask";
            this.tbGetProjectAllTask.UseVisualStyleBackColor = true;
            // 
            // lblProjectName1
            // 
            this.lblProjectName1.AutoSize = true;
            this.lblProjectName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectName1.ForeColor = System.Drawing.SystemColors.Window;
            this.lblProjectName1.Location = new System.Drawing.Point(121, 9);
            this.lblProjectName1.Name = "lblProjectName1";
            this.lblProjectName1.Size = new System.Drawing.Size(106, 16);
            this.lblProjectName1.TabIndex = 32;
            this.lblProjectName1.Text = "Project Name:";
            // 
            // dgwUpdate
            // 
            this.dgwUpdate.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUpdate.Location = new System.Drawing.Point(272, 20);
            this.dgwUpdate.Name = "dgwUpdate";
            this.dgwUpdate.Size = new System.Drawing.Size(480, 347);
            this.dgwUpdate.TabIndex = 35;
            this.dgwUpdate.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwUpdate_RowHeaderMouseDoubleClick);
            // 
            // cmbState2
            // 
            this.cmbState2.FormattingEnabled = true;
            this.cmbState2.Location = new System.Drawing.Point(122, 135);
            this.cmbState2.Name = "cmbState2";
            this.cmbState2.Size = new System.Drawing.Size(142, 24);
            this.cmbState2.TabIndex = 34;
            // 
            // tbUpdateTask
            // 
            this.tbUpdateTask.BackColor = System.Drawing.Color.Transparent;
            this.tbUpdateTask.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.tbUpdateTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbUpdateTask.Controls.Add(this.lblState1);
            this.tbUpdateTask.Controls.Add(this.lblFinishDate1);
            this.tbUpdateTask.Controls.Add(this.dgwUpdate);
            this.tbUpdateTask.Controls.Add(this.cmbState2);
            this.tbUpdateTask.Controls.Add(this.btnUpdate);
            this.tbUpdateTask.Controls.Add(this.dtpFinishDate2);
            this.tbUpdateTask.Controls.Add(this.dtpStartingDate2);
            this.tbUpdateTask.Controls.Add(this.lblStartDate);
            this.tbUpdateTask.Controls.Add(this.txtTaskName2);
            this.tbUpdateTask.Controls.Add(this.lblTasksName);
            this.tbUpdateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUpdateTask.Location = new System.Drawing.Point(4, 22);
            this.tbUpdateTask.Name = "tbUpdateTask";
            this.tbUpdateTask.Padding = new System.Windows.Forms.Padding(3);
            this.tbUpdateTask.Size = new System.Drawing.Size(765, 411);
            this.tbUpdateTask.TabIndex = 1;
            this.tbUpdateTask.Text = "Update Task";
            // 
            // lblState1
            // 
            this.lblState1.AutoSize = true;
            this.lblState1.ForeColor = System.Drawing.SystemColors.Window;
            this.lblState1.Location = new System.Drawing.Point(52, 143);
            this.lblState1.Name = "lblState1";
            this.lblState1.Size = new System.Drawing.Size(48, 16);
            this.lblState1.TabIndex = 41;
            this.lblState1.Text = "State:";
            // 
            // lblFinishDate1
            // 
            this.lblFinishDate1.AutoSize = true;
            this.lblFinishDate1.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFinishDate1.Location = new System.Drawing.Point(10, 108);
            this.lblFinishDate1.Name = "lblFinishDate1";
            this.lblFinishDate1.Size = new System.Drawing.Size(90, 16);
            this.lblFinishDate1.TabIndex = 40;
            this.lblFinishDate1.Text = "Finish Date:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.Location = new System.Drawing.Point(178, 172);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 31);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpFinishDate2
            // 
            this.dtpFinishDate2.Location = new System.Drawing.Point(122, 102);
            this.dtpFinishDate2.Name = "dtpFinishDate2";
            this.dtpFinishDate2.Size = new System.Drawing.Size(142, 22);
            this.dtpFinishDate2.TabIndex = 31;
            // 
            // dtpStartingDate2
            // 
            this.dtpStartingDate2.Location = new System.Drawing.Point(122, 69);
            this.dtpStartingDate2.Name = "dtpStartingDate2";
            this.dtpStartingDate2.Size = new System.Drawing.Size(142, 22);
            this.dtpStartingDate2.TabIndex = 30;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStartDate.Location = new System.Drawing.Point(3, 73);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(106, 16);
            this.lblStartDate.TabIndex = 28;
            this.lblStartDate.Text = " Starting Date:";
            // 
            // txtTaskName2
            // 
            this.txtTaskName2.Location = new System.Drawing.Point(124, 40);
            this.txtTaskName2.Name = "txtTaskName2";
            this.txtTaskName2.ReadOnly = true;
            this.txtTaskName2.Size = new System.Drawing.Size(142, 22);
            this.txtTaskName2.TabIndex = 27;
            // 
            // lblTasksName
            // 
            this.lblTasksName.AutoSize = true;
            this.lblTasksName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTasksName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTasksName.Location = new System.Drawing.Point(8, 44);
            this.lblTasksName.Name = "lblTasksName";
            this.lblTasksName.Size = new System.Drawing.Size(92, 16);
            this.lblTasksName.TabIndex = 26;
            this.lblTasksName.Text = "Task Name:";
            // 
            // tbTeamLeader
            // 
            this.tbTeamLeader.Controls.Add(this.tbCreateTask);
            this.tbTeamLeader.Controls.Add(this.tbUpdateTask);
            this.tbTeamLeader.Controls.Add(this.tbGetProjectAllTask);
            this.tbTeamLeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTeamLeader.Location = new System.Drawing.Point(0, 24);
            this.tbTeamLeader.Name = "tbTeamLeader";
            this.tbTeamLeader.SelectedIndex = 0;
            this.tbTeamLeader.Size = new System.Drawing.Size(773, 437);
            this.tbTeamLeader.TabIndex = 2;
            this.tbTeamLeader.Click += new System.EventHandler(this.tbTeamLeader_Click);
            // 
            // tbCreateTask
            // 
            this.tbCreateTask.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.tbCreateTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbCreateTask.Controls.Add(this.cmbProjectName);
            this.tbCreateTask.Controls.Add(this.btnAdd);
            this.tbCreateTask.Controls.Add(this.txtState);
            this.tbCreateTask.Controls.Add(this.lblProjectName);
            this.tbCreateTask.Controls.Add(this.lblState);
            this.tbCreateTask.Controls.Add(this.dtpFinishDate);
            this.tbCreateTask.Controls.Add(this.dtpStartingDate);
            this.tbCreateTask.Controls.Add(this.lblFinishDate);
            this.tbCreateTask.Controls.Add(this.lblStartingDate);
            this.tbCreateTask.Controls.Add(this.txtTaskName);
            this.tbCreateTask.Controls.Add(this.lblTaskName);
            this.tbCreateTask.Location = new System.Drawing.Point(4, 22);
            this.tbCreateTask.Name = "tbCreateTask";
            this.tbCreateTask.Padding = new System.Windows.Forms.Padding(3);
            this.tbCreateTask.Size = new System.Drawing.Size(676, 411);
            this.tbCreateTask.TabIndex = 0;
            this.tbCreateTask.Text = "CreateTask";
            this.tbCreateTask.UseVisualStyleBackColor = true;
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.FormattingEnabled = true;
            this.cmbProjectName.Location = new System.Drawing.Point(258, 79);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(200, 21);
            this.cmbProjectName.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(343, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 44);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(258, 212);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(200, 20);
            this.txtState.TabIndex = 20;
            this.txtState.Text = "Başlanmadı";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjectName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblProjectName.Location = new System.Drawing.Point(131, 82);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(106, 16);
            this.lblProjectName.TabIndex = 19;
            this.lblProjectName.Text = "Project Name:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblState.ForeColor = System.Drawing.SystemColors.Window;
            this.lblState.Location = new System.Drawing.Point(131, 215);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(48, 16);
            this.lblState.TabIndex = 18;
            this.lblState.Text = "State:";
            // 
            // dtpFinishDate
            // 
            this.dtpFinishDate.Location = new System.Drawing.Point(258, 179);
            this.dtpFinishDate.Name = "dtpFinishDate";
            this.dtpFinishDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFinishDate.TabIndex = 17;
            // 
            // dtpStartingDate
            // 
            this.dtpStartingDate.Location = new System.Drawing.Point(258, 146);
            this.dtpStartingDate.Name = "dtpStartingDate";
            this.dtpStartingDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartingDate.TabIndex = 16;
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.AutoSize = true;
            this.lblFinishDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinishDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFinishDate.Location = new System.Drawing.Point(131, 184);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(90, 16);
            this.lblFinishDate.TabIndex = 15;
            this.lblFinishDate.Text = "Finish Date:";
            // 
            // lblStartingDate
            // 
            this.lblStartingDate.AutoSize = true;
            this.lblStartingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStartingDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblStartingDate.Location = new System.Drawing.Point(131, 149);
            this.lblStartingDate.Name = "lblStartingDate";
            this.lblStartingDate.Size = new System.Drawing.Size(102, 16);
            this.lblStartingDate.TabIndex = 14;
            this.lblStartingDate.Text = "Starting Date:";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(258, 111);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(200, 20);
            this.txtTaskName.TabIndex = 13;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTaskName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTaskName.Location = new System.Drawing.Point(131, 114);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(92, 16);
            this.lblTaskName.TabIndex = 12;
            this.lblTaskName.Text = "Task Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamLeaderManagmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // teamLeaderManagmentToolStripMenuItem
            // 
            this.teamLeaderManagmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTaskToolStripMenuItem,
            this.updateTaskToolStripMenuItem,
            this.getProjectAllTaskToolStripMenuItem});
            this.teamLeaderManagmentToolStripMenuItem.Name = "teamLeaderManagmentToolStripMenuItem";
            this.teamLeaderManagmentToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.teamLeaderManagmentToolStripMenuItem.Text = "Team Leader Managment";
            // 
            // createTaskToolStripMenuItem
            // 
            this.createTaskToolStripMenuItem.Name = "createTaskToolStripMenuItem";
            this.createTaskToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.createTaskToolStripMenuItem.Text = "Create Task";
            // 
            // updateTaskToolStripMenuItem
            // 
            this.updateTaskToolStripMenuItem.Name = "updateTaskToolStripMenuItem";
            this.updateTaskToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.updateTaskToolStripMenuItem.Text = "Update Task";
            // 
            // getProjectAllTaskToolStripMenuItem
            // 
            this.getProjectAllTaskToolStripMenuItem.Name = "getProjectAllTaskToolStripMenuItem";
            this.getProjectAllTaskToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.getProjectAllTaskToolStripMenuItem.Text = "Get Project All Task";
            // 
            // TeamLeaderForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 461);
            this.Controls.Add(this.tbTeamLeader);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeamLeaderForm1";
            this.Text = "TeamLeaderForm1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).EndInit();
            this.tbGetProjectAllTask.ResumeLayout(false);
            this.tbGetProjectAllTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUpdate)).EndInit();
            this.tbUpdateTask.ResumeLayout(false);
            this.tbUpdateTask.PerformLayout();
            this.tbTeamLeader.ResumeLayout(false);
            this.tbCreateTask.ResumeLayout(false);
            this.tbCreateTask.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwList;
        private System.Windows.Forms.Label lblTeamProjectName;
        private System.Windows.Forms.ComboBox cmbProjectGetTask;
        private System.Windows.Forms.TabPage tbGetProjectAllTask;
        private System.Windows.Forms.DataGridView dgwUpdate;
        private System.Windows.Forms.ComboBox cmbState2;
        private System.Windows.Forms.TabPage tbUpdateTask;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpFinishDate2;
        private System.Windows.Forms.DateTimePicker dtpStartingDate2;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtTaskName2;
        private System.Windows.Forms.Label lblTasksName;
        private System.Windows.Forms.TabControl tbTeamLeader;
        private System.Windows.Forms.TabPage tbCreateTask;
        private System.Windows.Forms.ComboBox cmbProjectName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.DateTimePicker dtpFinishDate;
        private System.Windows.Forms.DateTimePicker dtpStartingDate;
        private System.Windows.Forms.Label lblFinishDate;
        private System.Windows.Forms.Label lblStartingDate;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblState1;
        private System.Windows.Forms.Label lblFinishDate1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teamLeaderManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getProjectAllTaskToolStripMenuItem;
        private System.Windows.Forms.Label lblProjectName1;
    }
}