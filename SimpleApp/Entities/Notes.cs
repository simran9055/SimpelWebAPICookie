using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp.Entities
{
    public class Notes
    {
        public int NoteId { get; set; }
        public string NoteContent { get; set; }
        public User NoteUser { get; set; }
    }
}
