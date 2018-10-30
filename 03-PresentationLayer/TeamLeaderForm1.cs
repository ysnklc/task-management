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
    public partial class TeamLeaderForm1 : Form
    {
        TasksBusiness _tasksBusiness;
        Tasks _tasks;
        ProjectBusiness _projectBusiness;
        StateBusiness _stateBusiness;
        public TeamLeaderForm1()
        {
            InitializeComponent();
            _tasksBusiness = new TasksBusiness();
            _tasks = new Tasks();
            _projectBusiness = new ProjectBusiness();
            _stateBusiness = new StateBusiness();
        }

     

      
        public void FiilDgw()
        {
            dgwList.DataSource = null;
            var source = (
                          from pro in _projectBusiness.GetAll()
                          from task in _tasksBusiness.GetAll()
                          from sta in _stateBusiness.GetAll()
                          where task.ProjetId == pro.ProjectId && task.StateId == sta.StateId && sta.Status == "Başlanmadı"
                          select new
                          {
                              task.TaskId,
                              task.TaskName,
                              pro.ProjectName,
                              task.StartingDate,
                              task.FinishDate,
                              sta.Status,

                          }).ToList();

            dgwList.DataSource = source;
        }
        public void FiilDgwUpdate()
        {
            dgwUpdate.DataSource = null;
            var source = (
                          from pro in _projectBusiness.GetAll()
                          from task in _tasksBusiness.GetAll()
                          from sta in _stateBusiness.GetAll()
                          where task.ProjetId == pro.ProjectId && task.StateId == sta.StateId && sta.Status != "Tamamlandı"
                          select new
                          {
                              task.TaskId,
                              task.TaskName,
                              pro.ProjectName,
                              task.StartingDate,
                              task.FinishDate,
                              sta.Status,

                          }).ToList();

            dgwUpdate.DataSource = source;
        }

        private void cmbProjectGetTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            int projectId;
            try
            {
                projectId = (int)cmbProjectGetTask.SelectedValue;
            }
            catch (Exception)
            {
                projectId = 1;

            }
            dgwList.DataSource = null;
            dgwList.DataSource = _tasksBusiness.GetAllByProject(projectId);
        }

     
        private int taskid;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _tasks = _tasksBusiness.Get(taskid);


            _tasks.TaskName = txtTaskName2.Text;
            _tasks.StartingDate = dtpStartingDate2.Value;
            _tasks.FinishDate = dtpFinishDate2.Value;

            if ((int)cmbState2.SelectedValue != 3 && (int)cmbState2.SelectedValue != 4)
            {
                MessageBox.Show("Yetkiniz dışında iş yapamazsınız.");
            }
            else
            {

                _tasks.StateId = (int)cmbState2.SelectedValue;
                bool result2 = _tasksBusiness.Update(_tasks);
                MessageBox.Show(result2 ? "Güncelleme başarılı" : "Güncelleme başarısız!");
            }

        }

   

        private void btnAdd_Click(object sender, EventArgs e)
        {

            _tasks.TaskName = txtTaskName.Text;
            _tasks.ProjetId = (int)cmbProjectName.SelectedValue;
            _tasks.StartingDate = dtpStartingDate.Value;
            _tasks.FinishDate = dtpFinishDate.Value;
            _tasks.StateId = 1;

            bool result = _tasksBusiness.Add(_tasks);
            MessageBox.Show(result ? "Ekleme başarılı" : "Ekleme başarısız!");
            FiilDgw();
        }



        private void tbTeamLeader_Click(object sender, EventArgs e)
        {
            FiilDgwUpdate();

            cmbProjectGetTask.ValueMember = "ProjectId";
            cmbProjectGetTask.DisplayMember = "ProjectName";
            cmbProjectGetTask.DataSource = _projectBusiness.GetAll();
            
            cmbState2.ValueMember = "StateId";
            cmbState2.DisplayMember = "Status";
            cmbState2.DataSource = _stateBusiness.GetAll();

            cmbProjectName.DisplayMember = "ProjectName";
            cmbProjectName.ValueMember = "ProjectId";
            cmbProjectName.DataSource = _projectBusiness.GetAll();

            FiilDgw();
        }

        private void dgwUpdate_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            taskid = (int)dgwUpdate.CurrentRow.Cells["TaskId"].Value;
            txtTaskName2.Text = dgwUpdate.CurrentRow.Cells["Taskname"].Value.ToString();
            dtpStartingDate2.Text = dgwUpdate.CurrentRow.Cells["StartingDate"].Value.ToString();
            dtpFinishDate2.Text = dgwUpdate.CurrentRow.Cells["FinishDate"].Value.ToString();

            FiilDgwUpdate();
        }


    }
}
