namespace _03_PresentationLayer
{
    partial class TestingSpecialistForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestingSpecialistForm1));
            this.dgwTest = new System.Windows.Forms.DataGridView();
            this.btnSucces = new System.Windows.Forms.Button();
            this.cmbEmployeeName = new System.Windows.Forms.ComboBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnError = new System.Windows.Forms.Button();
            this.btnAasignment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTest)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwTest
            // 
            this.dgwTest.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTest.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgwTest.Location = new System.Drawing.Point(173, 0);
            this.dgwTest.Name = "dgwTest";
            this.dgwTest.Size = new System.Drawing.Size(581, 451);
            this.dgwTest.TabIndex = 1;
            // 
            // btnSucces
            // 
            this.btnSucces.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSucces.BackgroundImage")));
            this.btnSucces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSucces.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSucces.Location = new System.Drawing.Point(12, 27);
            this.btnSucces.Name = "btnSucces";
            this.btnSucces.Size = new System.Drawing.Size(138, 36);
            this.btnSucces.TabIndex = 2;
            this.btnSucces.Text = "Success";
            this.btnSucces.UseVisualStyleBackColor = true;
            this.btnSucces.Click += new System.EventHandler(this.btnSucces_Click);
            // 
            // cmbEmployeeName
            // 
            this.cmbEmployeeName.FormattingEnabled = true;
            this.cmbEmployeeName.Location = new System.Drawing.Point(21, 114);
            this.cmbEmployeeName.Name = "cmbEmployeeName";
            this.cmbEmployeeName.Size = new System.Drawing.Size(138, 21);
            this.cmbEmployeeName.TabIndex = 44;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmployeeName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEmployeeName.Location = new System.Drawing.Point(52, 93);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(86, 18);
            this.lblEmployeeName.TabIndex = 45;
            this.lblEmployeeName.Text = "Developer";
       //   this.lblEmployeeName.Click += new System.EventHandler(this.lblEmployeeName_Click);
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(18, 54);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(141, 20);
            this.txtTaskName.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "Task Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAasignment);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbEmployeeName);
            this.groupBox1.Controls.Add(this.txtTaskName);
            this.groupBox1.Controls.Add(this.lblEmployeeName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 237);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // btnError
            // 
            this.btnError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnError.BackgroundImage")));
            this.btnError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnError.ForeColor = System.Drawing.SystemColors.Window;
            this.btnError.Location = new System.Drawing.Point(21, 140);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(138, 32);
            this.btnError.TabIndex = 3;
            this.btnError.Text = "Error";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnAasignment
            // 
            this.btnAasignment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAasignment.BackgroundImage")));
            this.btnAasignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAasignment.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAasignment.Location = new System.Drawing.Point(21, 160);
            this.btnAasignment.Name = "btnAasignment";
            this.btnAasignment.Size = new System.Drawing.Size(138, 32);
            this.btnAasignment.TabIndex = 49;
            this.btnAasignment.Text = "Asignment";
            this.btnAasignment.UseVisualStyleBackColor = true;
            this.btnAasignment.Click += new System.EventHandler(this.btnAasignment_Click);
            // 
            // TestingSpecialistForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_03_PresentationLayer.Properties.Resources.formarkası_ıcın;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnSucces);
            this.Controls.Add(this.dgwTest);
            this.Name = "TestingSpecialistForm1";
            this.Text = "TestingSpecialistForm1";
            this.Load += new System.EventHandler(this.TestingSpecialistForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTest;
        private System.Windows.Forms.Button btnSucces;
        private System.Windows.Forms.ComboBox cmbEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAasignment;
        private System.Windows.Forms.Button btnError;

    }
}