using Movie_Api.Model;

namespace Movie_Api.Repository
{
    public interface IService
    {
        Task<IEnumerable<Moveis>> GetAllMoveisAsync();
    }
}
