using System;
using Vejledningsbooking.Domain.Interfaces;

namespace Vejledningsbooking.Domain.Entities
{
    public class Booking : IBooking
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public IBookingWindow BookingWindow { get; set; }
        public IStudent Student { get; set; }
        public byte[] Rowversion { get; set; }

        public Booking() { }
        public Booking(DateTime startTime, DateTime endTime)
        {
            Id = Guid.NewGuid();
            if (startTime == default) throw new ArgumentException("When do you plan to arrive?"); else StartTime = startTime;
            if (endTime == default) EndTime = StartTime.AddMinutes(30); else EndTime = endTime;
        }

        public bool IsOverlapping(IBooking booking)
        {
            return !(EndTime <= booking.StartTime || StartTime >= booking.EndTime);
        }

        public bool IsInsideBookingWindow(IBookingWindow bookingWindow)
        {
            return !(StartTime < bookingWindow.StartTime || EndTime > bookingWindow.EndTime);
        }
    }
}
