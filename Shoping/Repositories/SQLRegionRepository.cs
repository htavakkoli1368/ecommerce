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

        public async Task<List<RegionModel>> GetAllAsync()
        {
            return await ShopingContext.Region.ToListAsync();
        }

    }   
}
