using _01_Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DataAccessLayer.Mapping
{
    class StateMap : EntityTypeConfiguration<State>
    {
        public StateMap()
        {
            HasKey(s => s.StateId);

            Property(s => s.Status)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(30);
        }
    }
}
