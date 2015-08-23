using Sporty.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporty.Data.Repository.Interfaces
{
    interface IBookingRepository
    {
        IEnumerable<Booking> GetAllBookings();
    }
}
