using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApp.Context;
using SimpleApp.Entities;

namespace SimpleApp.Respository
{
    public class NoteRepo : INotesRepo
    {
        private NotesContext ctx;

        public NoteRepo(NotesContext context)
        {
            ctx = context;
        }

        public IQueryable<Notes> GetAllNotes(int userId)
        {
            return ctx.Notes.AsQueryable().Where(c => c.NoteUser.UserId == userId);
        }

    }
}
