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
    public partial class DeveloperForm1 : Form
    {
        TasksBusiness _tasksBusiness;
        Tasks _tasks;
        StateBusiness _stateBusiness;
        State _state;
        ProjectBusiness _projectBusiness;
        Employee _employee;
        EmployeeBusiness _employeeBusiness;
        EmployeeTasksBusiness _employeeTasksBusiness;
        public DeveloperForm1(Employee employee)
        {
            InitializeComponent();
            _tasksBusiness = new TasksBusiness();
            _projectBusiness = new ProjectBusiness();
            _stateBusiness = new StateBusiness();
            _employee = new Employee();
            _employee = employee;
            _tasks = new Tasks();
            _state = new State();
            _employeeBusiness = new EmployeeBusiness();
            _employeeTasksBusiness = new EmployeeTasksBusiness();
        }

        public DeveloperForm1()
        {
            InitializeComponent();
            _tasksBusiness = new TasksBusiness();
            _projectBusiness = new ProjectBusiness();
            _stateBusiness = new StateBusiness();
            _employee = new Employee();
            _tasks = new Tasks();
            _state = new State();
            _employeeBusiness = new EmployeeBusiness();
            _employeeTasksBusiness = new EmployeeTasksBusiness();

        }


        private void DeveloperForm1_Load(object sender, EventArgs e)
        {
            txtStatus.Text = "Tamamlandı";

            FillDgw();
        }

        public void FillDgw()
        {

            dgwList.DataSource = null;

            var source = (from t in _tasksBusiness.GetAll()
                          join et in _employeeTasksBusiness.GetAll() on t.TaskId equals et.TaskId into tet
                          from te in tet.DefaultIfEmpty()
                          join p in _projectBusiness.GetAll() on t.ProjetId equals p.ProjectId

                          where t.StateId == 3
                          select new
                          {
                              p.ProjectName,
                              t.TaskId,
                              t.TaskName,
                              t.StartingDate,
                              t.FinishDate,
                              p.ProjectId,
                              DeveloperID = te == null ? 0 : te.EmployeeId

                          }).ToList();


            dgwList.DataSource = source;
        }

        int taskId;

        private void dgwList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            taskId = (int)dgwList.CurrentRow.Cells["TaskId"].Value;
            txtProjectName.Text = dgwList.CurrentRow.Cells["ProjectName"].Value.ToString();
            txtTaskName.Text = dgwList.CurrentRow.Cells["TaskName"].Value.ToString();

        }


        private void btnSend_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtProjectName.Text == "" || txtTaskName.Text == "")
                {
                    MessageBox.Show("Lütfen listeden seçim yapınız!");

                }
                else
                {
                    _tasks = _tasksBusiness.Get(taskId);
                    _tasks.StateId = 4;

                    bool result = _tasksBusiness.Update(_tasks);

                    if (result)
                    {
                        MessageBox.Show("Tamamlanan iş test uzmanına başarıyla gönderildi.");
                    }
                    else
                    {
                        MessageBox.Show("Gönderme işlemi başarısız!");
                    }

                    FillDgw();

                    txtProjectName.Text = null;
                    txtTaskName.Text = null;
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden seçim yapınız!");

            }


        }
    }
}
