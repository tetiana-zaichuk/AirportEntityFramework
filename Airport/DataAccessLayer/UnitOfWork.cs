using System.Threading.Tasks;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using DataAccessLayer.Repository;

namespace DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly AirportContext Context;
        private CrewRepository _crewRepository;
        private FlightRepository _flightRepository;
        private AircraftRepository _aircraftRepository;
        private DepartureRepository _departureRepository;

        public UnitOfWork(AirportContext context)
        {
            this.Context = context;
        }

        public CrewRepository CrewRepository => _crewRepository ?? (_crewRepository = new CrewRepository(Context));

        public FlightRepository FlightRepository => _flightRepository ?? (_flightRepository = new FlightRepository(Context));

        public AircraftRepository AircraftRepository => _aircraftRepository ?? (_aircraftRepository = new AircraftRepository(Context));

        public DepartureRepository DepartureRepository => _departureRepository ?? (_departureRepository = new DepartureRepository(Context));

        public IRepository<TEntity> Set<TEntity>() where TEntity : Entity
        {
            return new Repository<TEntity>(Context);
        }

        public int SaveChages()
        {
            return Context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return Context.SaveChangesAsync();
        }

    }
}
