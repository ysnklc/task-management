using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DataAccessLayer
{
    public class UnitOfWork
    {

        private TaskManagerContext _context;

        public UnitOfWork()
        {
            _context = new TaskManagerContext();
        }



        CustomerDemandRepository _customerDemandRepository;
        public CustomerDemandRepository CustomerDemandRepository
        {
            get
            {
                if (_customerDemandRepository == null)
                {
                    _customerDemandRepository = new CustomerDemandRepository(_context);
                }
                return _customerDemandRepository;
            }

        }

        CustomerRepository _customerRepository;
        public CustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(_context);
                }
                return _customerRepository;
            }

        }

        EmployeeRepository _employeeRepository;
        public EmployeeRepository EmployeeRepository
        {
            get
            {
                if (_employeeRepository == null)
                {
                    _employeeRepository = new EmployeeRepository(_context);
                }
                return _employeeRepository;
            }

        }

        EmployeeRoleRepository _employeeRoleRepository;
        public EmployeeRoleRepository EmployeeRoleRepository
        {
            get
            {
                if (_employeeRoleRepository == null)
                {
                    _employeeRoleRepository = new EmployeeRoleRepository(_context);
                }
                return _employeeRoleRepository;
            }

        }

        ProjectRepository _projectRepository;
        public ProjectRepository ProjectRepository
        {
            get
            {
                if (_projectRepository == null)
                {
                    _projectRepository = new ProjectRepository(_context);
                }
                return _projectRepository;
            }

        }

        StateRepository _stateRepository;
        public StateRepository StateRepository
        {
            get
            {
                if (_stateRepository == null)
                {
                    _stateRepository = new StateRepository(_context);
                }
                return _stateRepository;
            }

        }

        TasksRepository _tasksRepository;
        public TasksRepository TasksRepository
        {
            get
            {
                if (_tasksRepository == null)
                {
                    _tasksRepository = new TasksRepository(_context);
                }
                return _tasksRepository;
            }

        }

        EmployeeTasksRepository _employeeTasksRepository;
        public EmployeeTasksRepository EmployeeTasksRepository
        {
            get
            {
                if (_employeeTasksRepository == null)
                {
                    _employeeTasksRepository = new EmployeeTasksRepository(_context);
                }
                return _employeeTasksRepository;
            }

        }


        ProjectEmployeeRepository _projectEmployeeRepository;
        public ProjectEmployeeRepository ProjectEmployeeRepository
        {
            get
            {
                if (_projectEmployeeRepository == null)
                {
                    _projectEmployeeRepository = new ProjectEmployeeRepository(_context);
                }
                return _projectEmployeeRepository;
            }

        }

        public bool ApplyChange()
        {

            bool isSuccess = false;
            DbContextTransaction _tran;
            _tran = _context.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            try
            {
                _context.SaveChanges();
                _tran.Commit();     // Commit => Başarılı bir şeklide işlem gerçekleşti.
                isSuccess = true;
            }
            catch (Exception)
            {
                _tran.Rollback();
                isSuccess = false;
            }
            finally
            {
                _tran.Dispose();
            }

            return isSuccess;
        }
    }
}
