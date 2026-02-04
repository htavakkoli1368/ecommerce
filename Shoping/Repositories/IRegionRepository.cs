using Shoping.Models.Domain;

namespace Shoping.Repositories
{
    public interface IRegionRepository
    {
        Task<List<RegionModel>> GetAllAsync();
        Task<RegionModel> GetByIdAsync();
        Task<RegionModel> CreateAsync();
        Task<RegionModel> Update();
        Task<RegionModel> Delete();
    }
}
