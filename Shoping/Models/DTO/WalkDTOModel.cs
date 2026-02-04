using Shoping.Models.Domain;

namespace Shoping.Models.DTOs
{
    public class WalkDTOModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string WalkImageUrl { get; set; }
        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }
        //Navigation property
        public DifficultyModel Difficulty { get; set; }
        public RegionModel Region { get; set; }
    }
}
