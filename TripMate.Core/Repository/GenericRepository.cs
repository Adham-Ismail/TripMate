using TripMate.Core.Repository;
using TripMate.DAL.Interfaces;
namespace TripMate.Core.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
    }
}
