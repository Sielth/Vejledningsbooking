using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vejledningsbooking.Application.Persistence;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Persistence.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly BookingContext _context;

        public BookingRepository(BookingContext context)
        {
            _context = context;
        }

        public Booking GetBooking(Guid id)
        {
            return _context.Bookings.Include(booking => booking.BookingWindow).First(booking => booking.Id == id);
        }

        public IEnumerable<Booking> GetBookings(Guid bookingWindowId)
        {
            return _context.BookingWindows.Include(bookingWindow => bookingWindow.Bookings).FirstOrDefault(bookingWindow => bookingWindow.Id == bookingWindowId)?.Bookings ??
                new List<Booking>();
        }

        public void Save(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }
    }
}
