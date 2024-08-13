using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gjestebok
{
    internal class Party
    {
        public string ReservationName { get; private set; }
        private List<Guest> Guests { get; set; } = [];

        public Party(string resName)
        {
            ReservationName = resName;
        }

        public int GetPartySize()
        {
            return Guests.Count;
        }

        public void PrintNameAndGuestNum()
        {
            "".PrintStringToConsole();
            $"Name: {ReservationName} \n Number of guests: {GetPartySize()}".PrintStringToConsole();
        }

        public void AddGuest(Guest newGuest)
        {
            Guests.Add(newGuest);
        }

        public void PrintAllGuests()
        {
            "".PrintStringToConsole();
            $"Reservation name: {ReservationName}".PrintStringToConsole();
            foreach (Guest guest in Guests)
            {
                guest.GetName().PrintStringToConsole();
            }
        }
    }
}
