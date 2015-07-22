using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using SimpleAPI.Models;

namespace SimpleAPI.Controllers
{
    public class NotesController : ApiController
    {
        List<Notes> NotesList = new List<Notes> { Note1, Note2, Note3, Note4, Note5, Note6 };

        public List<Notes> Get()
        {
            return NotesList;
        }

        public IHttpActionResult Get(int id)
        {
            string sessionId = "";

            CookieHeaderValue cookie = Request.Headers.GetCookies("session-id").FirstOrDefault();
            if (cookie != null)
            {
                sessionId = cookie["session-id"].Value;
            }

            return Ok(NotesList[id-1]);
        }

        [Authorize]
        public string Post([FromBody]User user)
        {
            var resp = new HttpResponseMessage();

            var cookie = new CookieHeaderValue("session-id", "2342354235");
            cookie.Expires = DateTimeOffset.Now.AddDays(1);
            cookie.Domain = Request.RequestUri.Host;
            cookie.Path = "/dfdsgfsfsd";

            resp.Headers.AddCookies(new CookieHeaderValue[] { cookie });
            return user.Username;
        }
        

        // ==============================================================
        private static User Simran = new User
        {
            UserId = 1,
            Username = "Simran"
        };
        private static User Jassi = new User
        {
            UserId = 2,
            Username = "Jassi"
        };

        private static Notes Note1 = new Notes
        {
            NoteId = 1,
            NoteUser = Simran,
            NoteContent = "This is my note1"
        };

        private static Notes Note2 = new Notes
        {
            NoteId = 2,
            NoteUser = Jassi,
            NoteContent = "This is my note2"
        };

        private static Notes Note3 = new Notes
        {
            NoteId = 3,
            NoteUser = Jassi,
            NoteContent = "This is my note3"
        };

        private static Notes Note4 = new Notes
        {
            NoteId = 4,
            NoteUser = Jassi,
            NoteContent = "This is my note4"
        };

        private static Notes Note5 = new Notes
        {
            NoteId = 5,
            NoteUser = Simran,
            NoteContent = "This is my note5"
        };

        private static Notes Note6 = new Notes
        {
            NoteId = 6,
            NoteUser = Simran,
            NoteContent = "This is my note6"
        };
    }
}
