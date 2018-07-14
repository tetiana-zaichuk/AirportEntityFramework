﻿using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Models;

namespace DataAccessLayer
{
    public class DataSeends
    {
        public static List<Aircraft> Aircraft = new List<Aircraft>()
            {
                new Aircraft(){ AircraftName = "Strong", AircraftTypeId = 1, AircraftReleaseDate = new DateTime(2011, 6, 10),
                    ExploitationTimeSpan = new DateTime(2021, 6, 10)-new DateTime(2011, 6, 10)},
                new Aircraft(){ AircraftName = "Dog", AircraftTypeId = 2, AircraftReleaseDate = new DateTime(2007, 6, 10),
                    ExploitationTimeSpan = new DateTime(2020, 6, 10)-new DateTime(2011, 6, 10)},
                new Aircraft(){ AircraftName = "Sky", AircraftTypeId = 3, AircraftReleaseDate = new DateTime(2015, 6, 10),
                    ExploitationTimeSpan = new DateTime(2027, 6, 10)-new DateTime(2011, 6, 10)}
            };

        public static List<AircraftType> AircraftTypes = new List<AircraftType>()
        {
            new AircraftType(){ AircraftModel = "Tupolev Tu-134", SeatsNumber = 80, Carrying = 47000},
            new AircraftType(){ AircraftModel = "Tupolev Tu-204", SeatsNumber = 196, Carrying = 107900},
            new AircraftType(){ AircraftModel = "Ilyushin IL-62", SeatsNumber = 138, Carrying = 280300}
        };
        
        public static List<Ticket> Tickets = new List<Ticket>()
        {
            new Ticket(){ FlightId = 1, Price = 5000},
            new Ticket(){ FlightId = 2, Price = 3500},
            new Ticket(){ FlightId = 3, Price = 3500}
        };

        public static List<Flight> Flights = new List<Flight>()
        {
            new Flight(){ Departure = "Kiev", DepartureTime = new DateTime(2018,7,15,19,35,00),
                Destination = "Tbilisi", ArrivalTime = new DateTime(2018,7,15,21,52,00),
                TicketsId = new List<int>(){1}},
            new Flight(){ Departure = "Venezia", DepartureTime = new DateTime(2018,7,17,13,25,00),
                Destination = "Kiev", ArrivalTime = new DateTime(2018,7,17,16,00,00),
                TicketsId = new List<int>(){2}},
            new Flight(){ Departure = "Kiev", DepartureTime = new DateTime(2018,7,20,13,25,00),
                Destination = "Venezia", ArrivalTime = new DateTime(2018,7,20,16,00,00),
                TicketsId = new List<int>(){3}}
        };

        public static List<Departure> Departures = new List<Departure>()
        {
            new Departure(){ FlightId = 1, AircraftId = 1, CrewId = 1, DepartureDate = new DateTime(2018,7,15,19,35,00)},
            new Departure(){ FlightId = 2, AircraftId = 2, CrewId = 2, DepartureDate = new DateTime(2018,7,17,14,25,00)},
            new Departure(){ FlightId = 3, AircraftId = 3, CrewId = 3, DepartureDate = new DateTime(2018,7,20,19,35,00)}
        };

        public static List<Pilot> Pilots = new List<Pilot>()
        {
            new Pilot(){ FirstName = "Adam", LastName = "Black", Dob = new DateTime(1978,03,03), Experience = 9},
            new Pilot(){ FirstName = "John", LastName = "Smith", Dob = new DateTime(1983,07,11), Experience = 5},
            new Pilot(){ FirstName = "Jane", LastName = "Smith", Dob = new DateTime(1980,07,11), Experience = 7}
        };

        public static List<Stewardess> Stewardesses = new List<Stewardess>()
        {
            new Stewardess(){ FirstName = "Anna", LastName = "Black", Dob = new DateTime(1993,02,03)},
            new Stewardess(){ FirstName = "Anna", LastName = "Red", Dob = new DateTime(1991,01,07)},
            new Stewardess(){ FirstName = "Eva", LastName = "Green", Dob = new DateTime(1987,11,10)}
        };

        public static List<Crew> Crews = new List<Crew>()
        {
            new Crew(){ PilotId = 1, StewardessesId = new List<int>(){1,2}},
            new Crew(){ PilotId = 2, StewardessesId = new List<int>(){1,3}},
            new Crew(){ PilotId = 3, StewardessesId = new List<int>(){2,3}}
        };

        public List<TEntity> Set<TEntity>()
        {
            if (Aircraft is List<TEntity>)
            {
                return Aircraft as List<TEntity>;
            }
            else if (AircraftTypes is List<TEntity>)
            {
                return AircraftTypes as List<TEntity>;
            }
            else if (Tickets is List<TEntity>)
            {
                return Tickets as List<TEntity>;
            }
            else if (Flights is List<TEntity>)
            {
                return Flights as List<TEntity>;
            }
            else if (Departures is List<TEntity>)
            {
                return Departures as List<TEntity>;
            }
            else if (Pilots is List<TEntity>)
            {
                return Pilots as List<TEntity>;
            }
            else if (Stewardesses is List<TEntity>)
            {
                return Stewardesses as List<TEntity>;
            }
            else if (Crews is List<TEntity>)
            {
                return Crews as List<TEntity>;
            }
            else
            {
                throw new Exception("Something happened");
            }
        }
    }
}
