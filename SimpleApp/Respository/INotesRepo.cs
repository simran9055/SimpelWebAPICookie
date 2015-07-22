using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApp.Entities;

namespace SimpleApp.Respository
{
    interface INotesRepo
    {
        IQueryable<Notes> GetAllNotes(int userId);
    }
}
