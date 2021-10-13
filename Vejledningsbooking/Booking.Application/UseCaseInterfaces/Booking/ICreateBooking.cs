using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Application.UseCaseInterfaces
{
    interface ICreateBooking
    {
        void CreateBooking(CreateBookingRequest command);
    }
}
