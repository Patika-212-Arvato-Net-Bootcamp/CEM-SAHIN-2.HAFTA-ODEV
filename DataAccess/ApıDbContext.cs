using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ApıDbContext:DbContext  //Veri Tabanını Bağladım
    {
        protected override  void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-6VUG41M;Database=ApıDb;Trusted_Connection=True; ");
        }


        //Entities katmanından gelen classlarımla veri tabanına kaydedeceğim tablo adlarını tanıttım.
        public DbSet<User>  Users  { get; set; }
        public DbSet<Bootcamp>  Bootcamps  { get; set; }

       
    }
}
