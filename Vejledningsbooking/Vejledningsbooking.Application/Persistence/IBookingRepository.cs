using System;
using System.Collections.Generic;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Application.Persistence
{
    public interface IBookingRepository
    {
        public void Save(Booking booking);
        public Booking GetBooking(Guid id);
        public IEnumerable<Booking> GetBookings(Guid bookingWindowId);

    }
}
