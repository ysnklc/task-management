using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01_Entity;
using _02_BusinessLogicLayer;

namespace _03_PresentationLayer
{
    public partial class ProjectManagerForm1 : Form
    {
        private ProjectBusiness _projectBusiness;
        private Project _project;
        private CustomerBusiness _customerBusiness;
        private Customer _customer;
        private EmployeeBusiness _employeeBusiness;
        private Employee _employee;
        private EmployeeRoleBusiness _employeeRoleBusiness;
        public ProjectManagerForm1()
        {
            InitializeComponent();
            _project = new Project();
            _projectBusiness = new ProjectBusiness();
            _customerBusiness = new CustomerBusiness();
            _customer = new Customer();
            _employeeBusiness = new EmployeeBusiness();
            _employee = new Employee();
            _employeeRoleBusiness = new EmployeeRoleBusiness();
     
        }
         private void ProjectManagerForm1_Load(object sender, EventArgs e)
        {
            cmbCustomer.DataSource = _customerBusiness.GetAll();
            cmbCustomer.ValueMember = "CustomerId";
            cmbCustomer.DisplayMember = "CustomerName";

            dgvAllProject.DataSource = _projectBusiness.GetAll();

            cmbEmployeeRole.DataSource = _employeeRoleBusiness.GetAll();
            cmbEmployeeRole.DisplayMember = "RoleName";
            cmbEmployeeRole.ValueMember = "EmployeeRoleId";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _project.ProjectName = txtProjectName.Text;
            _project.Description = txtDescription.Text;
            _project.StartingDate = dtpStartDate.Value;
            _project.FinishDate = dtpEndDate.Value;
            _project.CustomerId = (int)cmbCustomer.SelectedValue;
            if (_projectBusiness.Add(_project))
            {
                MessageBox.Show("Proje Eklendi");
            }
            else
            {
                MessageBox.Show("Proje Eklenemedi ! ");
            }

            dgvAllProject.DataSource = null;
            dgvAllProject.DataSource = _projectBusiness.GetAll();

        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            _customer.CompanyName = txtCompanyName.Text;
            _customer.CustomerName = txtCustomerName.Text;
            if (_customerBusiness.Add(_customer))
            {
                MessageBox.Show("Customer added");
            }
            else
            {
                MessageBox.Show("Custormer not added !! ");
            }
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            _employee.Address = txtEAddress.Text;
            _employee.DateOfBirth = eBirthDate.Value;
            _employee.EmployeeRoleId = (int)cmbEmployeeRole.SelectedValue;
            _employee.IdentityNumber = txtETc.Text;
            _employee.FirstName = txtEFirstName.Text;
            _employee.LastName = txtELastName.Text;
            _employee.Mail = txtEMail.Text;
            _employee.Password = txtEMail.Text;
            _employee.Phone = txtEPhone.Text;
            MessageBox.Show(_employeeBusiness.Add(_employee) ? "Calışan  Eklendi" : "Çalışan Eklenemedi ! ");
        }

        

        
    }
}
