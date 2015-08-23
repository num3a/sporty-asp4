using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sporty.Data.Models;
using Sporty.Data.Repository.Interfaces;
namespace Sporty.Data.Repository
{
    public class BookingRepository : IBookingRepository
    {
        public IEnumerable<Booking> GetAllBookings()
        {
            return new List<Booking>();
        }
    }
}
