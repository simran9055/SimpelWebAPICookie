using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleApp.Entities
{
    public class User
    {
        public User()
        {
            Notes = new List<Notes>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public List<Notes> Notes { get; set; }
    }
}
