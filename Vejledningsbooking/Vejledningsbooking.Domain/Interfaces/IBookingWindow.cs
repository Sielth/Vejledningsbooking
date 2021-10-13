using System;
using System.Collections.Generic;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Domain.Interfaces
{
    public interface IBookingWindow
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public IEnumerable<Booking> Bookings { get; set; }
        public ICalendar Calendar { get; set; }
        byte[] Rowversion { get; set; }
    }
}
