using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plantilla.Data
{
    public class PlantillaContext :DbContext
    {


        public PlantillaContext(DbContextOptions<PlantillaContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }




    }
}
