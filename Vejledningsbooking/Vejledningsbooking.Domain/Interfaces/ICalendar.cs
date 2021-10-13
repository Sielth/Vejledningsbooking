using System;
using System.Collections.Generic;

namespace Vejledningsbooking.Domain.Interfaces
{
    public interface ICalendar
    {
        public Guid Id { get; set; }
        public IEnumerable<IBookingWindow> BookingWindows { get; set; }
        public ITeacher Teacher { get; set; }
        public IClass Class { get; set; }
        byte[] Rowversion { get; set; }
    }
}
