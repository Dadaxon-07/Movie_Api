using LinqToDB;
using Movie_Api.DataLayer;
using Movie_Api.Model;
using System.Runtime.CompilerServices;

namespace Movie_Api.Repository
{
    public class Service : IService
    {

        private readonly MovieDbContext _movieDb;


        public Service(MovieDbContext movieDb)
        {
            _movieDb = movieDb;
        }
        public async Task<IEnumerable<Moveis>> GetAllMoveisAsync()
        {
            var res = await _movieDb.Moveiss.ToListAsync();
            if (res == null)
            {
                return null;
            }
            return res;

        }
    }
}
