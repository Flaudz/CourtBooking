using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CourtBooking
{
    public class Service
    {
        public List<Entities> getInfo()
        {
            var json = new WebClient().DownloadString("https://api.aspitcloud.dk/bookings");
            List<Entities> objUser = JsonConvert.DeserializeObject<List<Entities>>(json);
            
            return objUser;
        }
    }
}
