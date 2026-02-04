using Shoping.Models.Domain;

namespace Shoping.Repositories
{
    public class InMemoryRegionRepository : IRegionRepository
    {
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
           return  new List<RegionModel>(){
               new RegionModel()
                    {
                        Id=Guid.NewGuid(),
                        Name="hossein",
                        Code="akl",
                        RegionImageUrl="http://test.com"
                    },
                new RegionModel()
                {
                    Id=Guid.NewGuid(),
                    Name="hossein",
                    Code="akl",
                    RegionImageUrl="http://test.com"
                }
           };
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
