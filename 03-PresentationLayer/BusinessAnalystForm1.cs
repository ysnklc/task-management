using _01_Entity;
using _02_BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_PresentationLayer
{
    public partial class BusinessAnalystForm1 : Form
    {
        TasksBusiness _taskBusiness;
        ProjectBusiness _projectBusiness;
        Tasks _tasks;
        EmployeeBusiness _employeeBusiness;
        EmployeeTasks _employeeTasks;
        EmployeeTasksBusiness _employeeTaskBusiness;
        StateBusiness _stateBusiness;
        public BusinessAnalystForm1()
        {
            _taskBusiness = new TasksBusiness();
            _projectBusiness = new ProjectBusiness();
            _tasks = new Tasks();
            _employeeBusiness = new EmployeeBusiness();
            _employeeTasks = new EmployeeTasks();
            _employeeTaskBusiness = new EmployeeTasksBusiness();
            _stateBusiness = new StateBusiness();
            InitializeComponent();
        }

        private void tbTaskAssigment_Click(object sender, EventArgs e)
        {
            
            //cmbEmployeeName.DisplayMember = "FirstName";
            //cmbEmployeeName.ValueMember = "EmployeeId";
            //cmbEmployeeName.DataSource = _employeeBusiness.GetAll();
            //cmbProjectAssignment.DataSource = _projectBusiness.GetAll();
            //cmbProjectAssignment.DisplayMember = "ProjectName";
            //cmbProjectAssignment.ValueMember = "ProjectId";
        }

        private void tbCreateTask_Click(object sender, EventArgs e)
        {
            //cmbState.DisplayMember = "Status";
            //cmbState.ValueMember = "StateId";
            //cmbState.DataSource = _stateBusiness.GetAll();
            
            //cmbProjectName.DisplayMember = "ProjectName";
            //cmbProjectName.ValueMember = "ProjectId";
            //cmbProjectName.DataSource = _projectBusiness.GetAll();
            
        }

        private void btnAddTasks_Click(object sender, EventArgs e)
        {
            _tasks.TaskName = txtTaskName.Text;
            _tasks.StartingDate = dtpStartDate.Value;
            _tasks.FinishDate = dtpEndDate.Value;
            _tasks.ProjetId = (int)cmbProjectName.SelectedValue;
            _tasks.StateId = (int)cmbState.SelectedValue;
            bool result = _taskBusiness.Add(_tasks);
            MessageBox.Show(result ? "Başarıyla eklendi" : "Ekleme başarısız!");
        }
   
        private void btnAssignment_Click(object sender, EventArgs e)
        {
            _employeeTasks.EmployeeId = (int)cmbEmployeeName.SelectedValue;

            int taskid = (int)cmbTaskAssignment.SelectedValue;
            _employeeTasks.TaskId = taskid;
            _tasks = _taskBusiness.Get(taskid);
            _tasks.StateId = 3;
            bool updateIsSuccess = _taskBusiness.Update(_tasks);
            bool addIsSuccess = _employeeTaskBusiness.Add(_employeeTasks);
            MessageBox.Show(addIsSuccess ? "Atama işlemi başarılı" : "Atama işlemi gerçekleştirilemedi!");
            _tasks = _taskBusiness.Get(taskid);
            _tasks.StateId = 3;
        }

      

        private void tbBusinessAnalyst_Click(object sender, EventArgs e)
        {
            cmbEmployeeName.DisplayMember = "FirstName";
            cmbEmployeeName.ValueMember = "EmployeeId";
            cmbEmployeeName.DataSource = _employeeBusiness.GetAll();

            cmbProjectAssignment.DisplayMember = "ProjectName";
            cmbProjectAssignment.ValueMember = "ProjectId";
            cmbProjectAssignment.DataSource = _projectBusiness.GetAll();
            
            cmbState.DisplayMember = "Status";
            cmbState.ValueMember = "StateId";
            cmbState.DataSource = _stateBusiness.GetAll();

            cmbProjectName.DisplayMember = "ProjectName";
            cmbProjectName.ValueMember = "ProjectId";
            cmbProjectName.DataSource = _projectBusiness.GetAll();

            cmbTaskAssignment.DisplayMember = "TaskName";
            cmbTaskAssignment.ValueMember = "TaskId";
            cmbTaskAssignment.DataSource = _taskBusiness.GetAll();
        }

        private void cmbProjectAssignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int projectId;
            try
            {
                projectId = (int)cmbProjectAssignment.SelectedValue;
            }
            catch (Exception)
            {
                projectId = 1;

            }
            cmbTaskAssignment.DataSource = _taskBusiness.GetTaskState(projectId, 1);
            cmbTaskAssignment.DisplayMember = "TaskName";
            cmbTaskAssignment.ValueMember = "TaskId";
        }

        private void BusinessAnalystForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
