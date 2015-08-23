using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sporty.Data.Models;

namespace Sporty.Services.Interfaces
{
    interface IBookingService
    {
        IEnumerable<Booking> GetAllBookings();
    }
}
