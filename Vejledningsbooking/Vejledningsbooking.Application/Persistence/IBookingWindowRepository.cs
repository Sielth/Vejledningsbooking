using System;
using System.Collections.Generic;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Persistence
{
    public interface IBookingWindowRepository
    {
        public BookingWindow GetBookingWindow(Guid id);
        public IEnumerable<BookingWindow> GetBookingWindows();
    }
}
