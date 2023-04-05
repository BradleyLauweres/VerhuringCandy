using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerhuringCandyWebsite.Core.Entities;
using VerhuringCandyWebsite.Core.Interfaces;

namespace VerhuringCandyWebsite.Core.Services
{
    public class ReservationService : IReservationService
    {
        public void CreateReservationOrder(int amountOfPersons , DateTime arival, string email,string name , DateTime rentTime)
        {
            var reservation = new ReservationOrder
            {
                Id = Guid.NewGuid(),
                DateAdded = DateTime.Now,
                AmountOfPersons = amountOfPersons,
                DateOfArival = arival,
                ReservationUserMail = email,
                ReservationUserName = name,
                RentTime = rentTime,
            };
        }

        public List<ReservationOrder> GetReservations()
        {
            throw new NotImplementedException();
        }

        public void HardDeleteReservation()
        {
            throw new NotImplementedException();
        }

        public void SoftDeleteReservation()
        {
            throw new NotImplementedException();
        }

        public void UpdateReservationOrder()
        {
            throw new NotImplementedException();
        }
    }
}
