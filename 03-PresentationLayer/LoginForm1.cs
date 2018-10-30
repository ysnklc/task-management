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
    public partial class LoginForm1 : Form
    {
        private EmployeeBusiness _employeeBusiness;
        private Employee _employee;
        private EmployeeRole _employeeRole;
        public LoginForm1()
        {
            _employeeBusiness = new EmployeeBusiness();
            _employee = new Employee();
            _employeeRole = new EmployeeRole();
            InitializeComponent();
        }

       
        private void btnLogin_Click(object sender, EventArgs e)
        {

            string mail = txtEmail.Text;
            string password = txtPassword.Text;



            _employee = _employeeBusiness.GetEmployeeLogin(mail, password);

            switch (_employee.EmployeeRoleId)
            {
                case 1: OpenForm<ProjectManagerForm1>(); break;
                case 2: OpenForm<TeamLeaderForm1>(); break;
                case 3: OpenForm<BusinessAnalystForm1>(); break;
                case 4: OpenForm<TestingSpecialistForm1>(); break;
                case 5: OpenForm<DeveloperForm1>(); break;
                default: MessageBox.Show("Bizimle Değilsin");
                    break;
            }

        }
        private void OpenForm<T>() where T : Form, new()
        {
            T frm = new T();
            frm.Show();
        }

    }
}
