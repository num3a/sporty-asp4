using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporty.Data.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int MaxParticipant { get; set; }
        public DateTime BeginDate { get; set; }
    }
}
