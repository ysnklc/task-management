using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Entity;

namespace _02_DataAccessLayer.Mapping
{
    class ProjectEmployeeMap : EntityTypeConfiguration<ProjectEmployee>
    {
        public ProjectEmployeeMap()
        {

            HasRequired(od => od.Employee)
                .WithMany()
                .HasForeignKey(od => od.EmployeeId);

            HasRequired(od => od.Project)
                .WithMany()
                .HasForeignKey(od => od.ProjectId);

            HasKey(od => new { od.EmployeeId, od.ProjectId });
        }
    }
}
