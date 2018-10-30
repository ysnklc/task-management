using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity;

namespace _02_DataAccessLayer.Mapping
{
    class EmployeeTasksMap : EntityTypeConfiguration<EmployeeTasks>
    {
        public EmployeeTasksMap()
        {

            HasRequired(od => od.Employee)
                .WithMany()
                .HasForeignKey(od => od.EmployeeId);

            HasRequired(od => od.Tasks)
                .WithMany()
                .HasForeignKey(od => od.TaskId);

            HasKey(od => new { od.EmployeeId, od.TaskId });
        }
    }
}
