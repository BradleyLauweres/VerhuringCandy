﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerhuringCandyWebsite.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public IEnumerable<ReservationOrder> Reservations { get; set; }
    }
}
