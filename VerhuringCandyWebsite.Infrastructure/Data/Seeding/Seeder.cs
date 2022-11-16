using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerhuringCandyWebsite.Core.Entities;

namespace VerhuringCandyWebsite.Infrastructure.Data.Seeding
{
    public class Seeder
    {
        public static void SeedData(ModelBuilder modelBuilder)
        {
            var applicationUsers = new ApplicationUser[]
            {
                new ApplicationUser{ Id = Guid.NewGuid().ToString() , UserName = "test"}
            };
        }

    }
}
