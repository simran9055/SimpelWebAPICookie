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
    public class NotesMapper : EntityTypeConfiguration<Notes>
    {
        public NotesMapper()
        {
            this.ToTable("Notes");
            this.HasKey(c => c.NoteId);
            this.Property(c => c.NoteId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.NoteId).IsRequired();

            this.Property(c => c.NoteContent).IsRequired();

            this.HasRequired(c => c.NoteUser).WithMany().Map(s => s.MapKey("UserId"));
            
        }
    }
}
