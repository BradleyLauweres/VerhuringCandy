using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerhuringCandyWebsite.Core.Entities
{
    public class RentableItem : BaseEntity
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
    }
}
