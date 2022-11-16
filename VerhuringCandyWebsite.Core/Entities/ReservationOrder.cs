using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerhuringCandyWebsite.Core.Entities
{
    public class ReservationOrder : BaseEntity
    {
        public int AmountOfPersons { get; set; }
        public DateTime DateOfArival { get; set; }
        public DateTime RentTime { get; set; }
        public string ReservationUserMail { get; set; }
        public string ReservationUserName { get; set; }

        //Nav Prop
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
