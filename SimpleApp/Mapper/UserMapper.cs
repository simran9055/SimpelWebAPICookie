using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApp.Entities;

namespace SimpleApp.Mapper
{
    public class UserMapper : EntityTypeConfiguration<User>
    {
        public UserMapper()
        {
            this.ToTable("User");
            this.HasKey(c => c.UserId);
            this.Property(c => c.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.UserId).IsRequired();

            this.Property(c => c.Username).IsRequired();

            this.HasRequired(c => c.Username).WithMany().Map(s => s.MapKey("NoteId"));
        }
    }
}
