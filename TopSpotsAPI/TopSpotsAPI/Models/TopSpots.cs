using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using TopSpotsAPI.Models;


namespace TopSpotsAPI.Models
{
    public class TopSpot
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal[] Location { get; set; }
    }
}