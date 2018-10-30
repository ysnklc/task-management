using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using _01_Entity;
using _02_DataAccessLayer.Mapping;

namespace _02_DataAccessLayer
{
   public class TaskManagerContext:DbContext
    {

        internal TaskManagerContext():base("TaskDbContext")

        {
            
        }
  
        internal DbSet<Customer> Customers { set; get; }
        internal DbSet<CustomerDemand> CustomerDemands { set; get; }
        internal DbSet<Employee> Employees { set; get; }
        internal DbSet<EmployeeRole> EmployeeRoles { set; get; }
        internal DbSet<Project> Projects { set; get; }
        internal DbSet<State> States { set; get; }
        internal DbSet<Tasks> Taskes { set; get; }
        internal DbSet<EmployeeTasks> EmployeeTaskses { set; get; }
        internal DbSet<ProjectEmployee> ProjectEmployees { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         //   Database.SetInitializer<TaskManagerContext>(null);
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new CustomerDemandMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeRoleMap());
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new TasksMap());
            modelBuilder.Configurations.Add(new ProjectEmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeTasksMap());
          //  modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
