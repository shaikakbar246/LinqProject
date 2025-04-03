using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.DesignPatterns.BehaviouralDesignPattern.MediatorDesignPattern.MediatorExample1
{
    public class MediatorExample1
    {
        public static void Main(string[] args)
        {

        }
    }
    public class Airplane
    {
        public string FlightNumber { get; set; }
        public Airplane(string flightNumber)
        {
            FlightNumber = flightNumber;
        }
        public void RequestLanding()
        {

        }
        public void AssignRunway(Runway runway)
        {
            Console.WriteLine($"Airplane {FlightNumber} assigned to runway {runway.Id}.");
        }
    }
    public class Runway
    {
        public string Id { get; set; }
        public Runway(string id)
        {
            Id = id;
        }
    }
}
