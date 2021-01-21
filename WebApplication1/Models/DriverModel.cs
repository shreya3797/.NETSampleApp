using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DriverModel
    {
        public int DriverID { get; set; }
        public string DriverName { get; set; }
        public Nullable<int> RacesParticipated { get; set; }
        public Nullable<int> RacesWon { get; set; }
        public Nullable<int> RacesLost { get; set; }
    }
}