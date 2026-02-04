using Shoping.Models.Domain;

namespace Shoping.Repositories
{
    public class InMemoryRegionRepository : IRegionRepository
    {
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
    }
}
