using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Race
    {
        private string _departurePoint;
        private string _destinationPoint;
        private int _flightTimeInMinutes;

        public string DeparturePoint
        {
            get { return _departurePoint; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Value can not be empty");
                }
                _departurePoint = value;
            }
        }
        public string DestinationPoint
        {
            get { return _destinationPoint; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Value can not be empty");
                }
                _destinationPoint = value;
            }
        }
        public int FlightTimeInMinutes
        {
            get { return _flightTimeInMinutes; }
            set
            {
                if (Validator.AssertOnPositiveValue(value))
                {
                    _flightTimeInMinutes = value;
                }
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
