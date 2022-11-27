using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerhuringCandyWebsite.Core.Entities;

namespace VerhuringCandyWebsite.Core.Interfaces
{
    public interface IReservationService
    {
        void CreateReservationOrder(int amountOfPersons, DateTime arival, string email, string name, DateTime rentTime);
        void UpdateReservationOrder();
        List<ReservationOrder> GetReservations();
        void SoftDeleteReservation();
        void HardDeleteReservation();
    }
}
