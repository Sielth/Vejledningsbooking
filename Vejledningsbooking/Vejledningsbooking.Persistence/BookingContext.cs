using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vejledningsbooking.Domain.Entities;

namespace Vejledningsbooking.Persistence
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options) : base(options) { }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingWindow> BookingWindows { get; set; }
    }
}
