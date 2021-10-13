using System;
using System.Collections.Generic;
using Vejledningsbooking.Domain.Interfaces;

namespace Vejledningsbooking.Domain.Entities
{
    public class BookingWindow : IBookingWindow
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public IEnumerable<Booking> Bookings { get; set; }
        public ICalendar Calendar { get; set; }
        public byte[] Rowversion { get; set; }

        public BookingWindow() { }
        public BookingWindow(DateTime startTime, DateTime endTime)
        {
            Id = Guid.NewGuid();
            if (startTime == default) throw new ArgumentException("Please insert a start time."); else StartTime = startTime;
            if (endTime == default) throw new ArgumentException("Please insert an end time."); else StartTime = startTime;
        }
    }
}
