using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class RacingModel
    {
        public int RacingID { get; set; }
        public string City { get; set; }
        public string TrackName { get; set; }
        public int TrackLength { get; set; }
        public string Category { get; set; }
        public string CarName { get; set; }
        public string DriverName { get; set; }
        public string TopSpeedDriven { get; set; }
        public string CompletionTime { get; set; }
    }
}