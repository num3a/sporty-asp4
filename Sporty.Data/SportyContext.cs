﻿using Sporty.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporty.Data
{
    public class SportyContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
    }
}
