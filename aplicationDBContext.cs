using backendTarjeta.modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendTarjeta
{
    public class aplicationDBContext: DbContext
    {
       public DbSet<TarjetaCredito> tarjetaCredito { get; set; } //mapeamos nuestro modelo con la tabla de la db
        public aplicationDBContext(DbContextOptions<aplicationDBContext> options): base(options)
        {
        }
    }
}
