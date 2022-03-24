using Microsoft.EntityFrameworkCore;
using RentCar.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Logo> Logos { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<PartnerInfoCard> PartnerInfoCards { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
