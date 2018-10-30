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
    public partial class TestingSpecialistForm1 : Form
    {
        ProjectBusiness _projectBusiness;
        TasksBusiness _tasksBusiness;
        StateBusiness _stateBusiness;
        EmployeeTasksBusiness _employeeTaskBusiness;
        Tasks _tasks;
        EmployeeTasks _employeeTask;
        private EmployeeBusiness _employeeBusiness;

        public TestingSpecialistForm1()
        {
            InitializeComponent();
            _projectBusiness = new ProjectBusiness();
            _tasksBusiness = new TasksBusiness();
            _stateBusiness = new StateBusiness();
            _tasks = new Tasks();
            _employeeTaskBusiness = new EmployeeTasksBusiness();
            _employeeTask = new EmployeeTasks();
            _employeeBusiness = new EmployeeBusiness();
        }

        private void TestingSpecialistForm1_Load(object sender, EventArgs e)
        {



            var source = (from t in _tasksBusiness.GetAll()
                join et in _employeeTaskBusiness.GetAll() on t.TaskId equals et.TaskId into tet
                from te in tet.DefaultIfEmpty()
                join p in _projectBusiness.GetAll() on t.ProjetId equals p.ProjectId

                where t.StateId == 4
                select new
                {
                    p.ProjectName,
                    t.TaskName,
                    t.StartingDate,
                    t.FinishDate,
                    p.ProjectId,
                    DeveloperID = te == null ? 0 : te.EmployeeId,


                }).ToList();
            dgwTest.DataSource = source;
        }


        //   

        private void btnError_Click(object sender, EventArgs e)
        {
            try
            {
                _tasks.TaskName = dgwTest.CurrentRow.Cells["TaskName"].Value.ToString();
                _tasks.ProjetId = (int) dgwTest.CurrentRow.Cells["ProjectId"].Value;
                _tasks.StartingDate = (DateTime) dgwTest.CurrentRow.Cells["StartingDate"].Value;
                _tasks.FinishDate = (DateTime) dgwTest.CurrentRow.Cells["FinishDate"].Value;
                _tasks.StateId = 3;
            }
            catch (Exception)
            {

                MessageBox.Show("Tablodan iş şeçiniz");
            }
            var developer = (from dev in _employeeBusiness.GetAll()
                where dev.EmployeeRoleId == 5
                select new
                {
                    dev.FirstName,
                    dev.EmployeeId

                }).ToList();
            cmbEmployeeName.DataSource = developer;
            cmbEmployeeName.DisplayMember = "FirstName";
            cmbEmployeeName.ValueMember = "EmployeeId";

            _tasksBusiness.Add(_tasks);

            

        


        }

        private void btnSucces_Click(object sender, EventArgs e)
        {
            try
            {
               
                int taskid = (int) dgwTest.CurrentRow.Cells["TaskId"].Value;
                _tasks = _tasksBusiness.Get(taskid);
                _tasks.StateId = 2;
                _tasksBusiness.Update(_tasks);
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem başarısız");
            }


        }



        private void btnAasignment_Click(object sender, EventArgs e)
        {
            int empId = (int)dgwTest.CurrentRow.Cells["DeveloperID"].Value;
             _employeeTask.TaskId= (int) dgwTest.CurrentRow.Cells["Taskid"].Value;
             if (empId == 0)
             {
                 try
                 {
                     _employeeTask.EmployeeId = (int)cmbEmployeeName.SelectedValue;

                 }
                 catch (Exception)
                 {

                     MessageBox.Show("Geliştirici seçiniz");
                 }
                 MessageBox.Show(_employeeTaskBusiness.Add(_employeeTask) ? "Atama başarılı" : "Atama başarısız ! ");
             }
             else
             {
                 _employeeTask.EmployeeId = empId;
                 MessageBox.Show(_employeeTaskBusiness.Add(_employeeTask) ? "Atama başarılı" : "Atama başarısız ! ");
             }
           

        }


    }
}
