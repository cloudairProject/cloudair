using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudAirBD.Models
{

    public class CloudAirCompanyContext : IdentityDbContext
    {
        private DbSet<IdentityUser> user;

        public CloudAirCompanyContext(DbContextOptions<CloudAirCompanyContext> options, DbSet<User> users)
            : base(options)
        {
            Users = user;
        }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<CloudAirCompany> CloudAirCompanies { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Ticket> Tickets { get; set; }
    }
}

