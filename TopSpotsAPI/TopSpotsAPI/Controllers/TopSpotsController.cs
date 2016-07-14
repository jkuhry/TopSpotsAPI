using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TopSpotsAPI.Models;

namespace TopSpotsAPI.Controllers
{
    
    public class TopSpotsController : ApiController
    {
        // GET: api/TopSpots
        public IEnumerable<TopSpot> Get()
        {
            //Read in json from file and returns array of TopSpots
            TopSpot[] TopSpots = JsonConvert.DeserializeObject<TopSpot[]>(File.ReadAllText(@"C: \Users\jkuhry\Documents\Dev\TopSpotsAPI\TopSpotsAPI\TopSpotsJson.json"));
            return TopSpots;
        }



        // GET: api/TopSpots/5
        public string Get(int id)
        {
            return "TopSpots";
        }

        // POST: api/TopSpots
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TopSpots/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TopSpots/5
        public void Delete(int id)
        {
        }
    }
}
