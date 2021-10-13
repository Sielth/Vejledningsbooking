using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vejledningsbooking.Mvc.Infrastructure.BookingApi
{
    public class BookingServiceConfiguration
    {
        public string BaseUrl { get; set; } //localhost + port number
        public string ServiceUrl { get; set; }//Controller
    }
}
