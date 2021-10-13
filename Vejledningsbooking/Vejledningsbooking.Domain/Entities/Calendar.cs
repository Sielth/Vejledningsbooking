using System;
using System.Collections.Generic;
using Vejledningsbooking.Domain.Interfaces;

namespace Vejledningsbooking.Domain.Entities
{
    public class Calendar : ICalendar
    {
        public Guid Id { get; set; }
        public IEnumerable<IBookingWindow> BookingWindows { get; set; }
        public ITeacher Teacher { get; set; }
        public IClass Class { get; set; }
        public byte[] Rowversion { get; set; }

        public Calendar() { }
    }
}
