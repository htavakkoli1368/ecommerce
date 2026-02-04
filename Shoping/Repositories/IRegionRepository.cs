using Shoping.Models.Domain;

namespace Shoping.Repositories
{
    public interface IRegionRepository
    {
        Task<List<RegionModel>> GetAllAsync();
    }
}
