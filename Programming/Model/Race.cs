using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Race
    {
        private string departurePoint;
        private string destinationPoint;
        private int flightTimeInMinutes;

        public string DeparturePoint
        {
            get { return departurePoint; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Значение не может быть пустым");
                }
                departurePoint = value;
            }
        }
        public string DestinationPoint
        {
            get { return destinationPoint; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Значение не может быть пустым");
                }
                destinationPoint = value;
            }
        }
        public int FlightTimeInMinutes
        {
            get { return flightTimeInMinutes; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Время полета не может быть отрицательным");
                }
                flightTimeInMinutes = value;
            }
        }
        public Race(string departurePoint, string destinationPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeInMinutes = flightTimeInMinutes;
        }
        public Race()
        {

        }
    }
}
