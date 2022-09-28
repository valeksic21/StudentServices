using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentDataAccess;

namespace StudentServices.Controllers
{
    public class MusicController : ApiController
    {
        // GET: api/Music
                public IEnumerable<v_track_list_extended> Get()
                {
                    using (Entities entities = new Entities())
                    {
                        return entities.v_track_list_extended.ToList();
                    }
                }
        


        // GET: api/Music/5
        public v_track_list_extended Get(string p_Track, string p_Artist)
        {
            using (Entities entities = new Entities())
            {
                return entities.v_track_list_extended.FirstOrDefault(e => e.Track.Contains(p_Track) && e.Artist.Contains(p_Artist) );
            }
        }




        // POST: api/Music
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Music/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Music/5
        public void Delete(int id)
        {
        }
    }
}
