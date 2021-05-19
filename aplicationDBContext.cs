using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backendTarjeta
{
    public class aplicationDBContext: DbContext
    {
        public aplicationDBContext(DbContextOptions<aplicationDBContext> options): base(options)
        {
        }
    }
}
