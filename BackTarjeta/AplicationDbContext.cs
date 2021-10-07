using BackTarjeta.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackTarjeta
{
    public class AplicationDbContext: DbContext
    {
        // debe usar el modelo de las clases que van a la db  los dbset son como las tablas de mi bd
      public  DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { 
        }
    }
}
