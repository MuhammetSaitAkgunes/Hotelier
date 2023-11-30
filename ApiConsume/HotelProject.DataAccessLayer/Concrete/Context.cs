using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-EAQ14N5;initial catalog=ApiDb;integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().HasKey(r => r.RoomId);
            modelBuilder.Entity<Service>().HasKey(s => s.ServiceId);
            modelBuilder.Entity<Staff>().HasKey(st => st.StaffId);
            modelBuilder.Entity<Subscribe>().HasKey(sb => sb.SubscribeId);
            modelBuilder.Entity<Testimonial>().HasKey(t => t.TestimonialId);

            // User login için user id alıyor.
            modelBuilder.Entity<IdentityUserLogin<int>>().HasKey(t => t.UserId);

            // Rol belirlemek için role id alıyor.
            modelBuilder.Entity<IdentityUserRole<int>>().HasKey(r => r.RoleId);


            modelBuilder.Entity<IdentityUserToken<int>>().HasKey(tkn => tkn.UserId);

        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set;}
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
