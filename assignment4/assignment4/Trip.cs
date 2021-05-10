using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    public enum TripType
    {
        Vacation = 1, Bicycle, Family, Seniors, WineryAndWine, JeepTour, Cruises, SafariAndDiving
    }
    class Trip
    {
        const string DefaultDestination = "Israel";
        static uint counter;

        readonly uint tripNumber;
        string destination;
        DateTime date;//מחלקה קיימת בסי

        public Trip() : this(TripType.Vacation, DateTime.Today, DefaultDestination)
        {
        }

        public Trip(TripType tripType, DateTime date, string destination)
        {
            counter++;
            tripNumber = counter;
            Destination = destination;
            Date = date;
            TripType = tripType;
        }

        public uint TripNumber => tripNumber;
        public TripType TripType { get; set; }
        public string Destination
        {
            get => destination;
            set
            {
                bool valid = IsValidDestination(value);
                if (valid)
                    destination = value;
                else
                    destination = DefaultDestination;
            }
        }

        private bool IsValidDestination(string destination)
        {
            if (destination != null)
            {
                for (int i = 0; i < destination.Length; i++)
                {
                    if ((destination[i] < 'a' || destination[i] > 'z') && (destination[i] < 'A' || destination[i] > 'Z') && destination[i] != ' ')
                        return false;
                }
            }
            return true;
        }

        public DateTime Date
        {
            get => date;
            set
            {
                if (value >= DateTime.Today)
                    date = value;
                else
                    date = DateTime.Today;
            }
        }

        public int CompareDate(Trip trip)
        {
            int num_of_day = CalcDateTime.DateDif(trip.Date, this.Date);
            if (num_of_day > 0)
                return 1;
            if (num_of_day == 0)
                return 0;
            return -1;
        }

        public void PrintTrip()
        {
            Console.WriteLine("The number of trip: " + tripNumber);
            Console.WriteLine("The destination is " + destination);
            Console.WriteLine("The date: " + date.ToString("dd-MM-yyyy"));
            Console.WriteLine("The trip type: " + TripType);
        }

        public DateTime GetEndDate(uint numberOfDays)
        {
            return CalcDateTime.AddDayToDate(this.Date, numberOfDays);
        }

        ~Trip()
        {
            Console.WriteLine("The number of trip has been destroyed: " + tripNumber);
            counter--;
        }

        public string PrintTripForGUI()
        {
          
            return "Trip number: " + tripNumber + ". Destination: " + destination + ". Date: " + date.ToString("dd-MM-yyyy") + ". Trip's type: " + TripType + ".";
        }
    }
}
