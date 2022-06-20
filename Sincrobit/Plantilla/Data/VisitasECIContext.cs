using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SincroBit.Data
{
    public class SincroBitContext :DbContext
    {


        public SincroBitContext(DbContextOptions<SincroBitContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }




    }
}
