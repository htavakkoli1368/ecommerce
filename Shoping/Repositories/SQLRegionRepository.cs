using Microsoft.EntityFrameworkCore;
using Shoping.Data;
using Shoping.Models.Domain;

namespace Shoping.Repositories
{
    public class SQLRegionRepository : IRegionRepository
    {
        private ShopingContext ShopingContext;
        public SQLRegionRepository(ShopingContext shopingContext)
        {
            this.ShopingContext = shopingContext;
        }

        public Task<RegionModel> CreateAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RegionModel> Delete()
        {
            throw new NotImplementedException();
        }

        public async Task<List<RegionModel>> GetAllAsync()
        {
            return await ShopingContext.Region.ToListAsync();
        }

        public Task<RegionModel> GetByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RegionModel> Update()
        {
            throw new NotImplementedException();
        }
    }   
}
