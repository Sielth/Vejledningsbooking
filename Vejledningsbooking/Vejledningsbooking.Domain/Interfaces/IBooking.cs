using System;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Domain.Interfaces
{
    public interface IBooking
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public IBookingWindow BookingWindow { get; set; }
        public IStudent Student { get; set; }
        byte[] Rowversion { get; set; }

        public bool IsOverlapping(IBooking booking);
        public bool IsInsideBookingWindow(IBookingWindow bookingWindow);
    }
}
