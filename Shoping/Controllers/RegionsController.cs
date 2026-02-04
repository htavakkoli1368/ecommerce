using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shoping.Data;
using Shoping.Models.Domain;
using Shoping.Models.DTO;
using Shoping.Models.DTOs;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Shoping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly ShopingContext Shcontext;

        public RegionsController(ShopingContext shcontext)
        {
            Shcontext = shcontext;
        }

 
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
         var regions =await Shcontext.Region.ToListAsync();
            return Ok(regions);           
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var regions = await Shcontext.Region.FirstOrDefaultAsync(c=>c.Id==id);
           // var regions = Shcontext.Region.Find(id);
            if (regions == null)
            {
                return NotFound();   
            }
            return Ok(regions);
        }


        [HttpPost]
         public async Task<IActionResult> Create([FromBody] AddRegionDtoModel addRegionDto)
        {
             
            var regionmodel = new RegionModel()
            {
                Code = addRegionDto.Code,
                Name = addRegionDto.Name,
                RegionImageUrl = addRegionDto.RegionImageUrl
            };

            // var regions = Shcontext.Region.Find(id);
            if (addRegionDto == null)
            {
                return NotFound();
            }
           await Shcontext.Region.AddAsync(regionmodel);
           await Shcontext.SaveChangesAsync();
            
            return CreatedAtAction(nameof(GetById),new {id = regionmodel.Id},regionmodel);
        }


        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id,[FromBody] UpdateRegionDtoModel updateRegionDto)
        {
            var olddata = await Shcontext.Region.FindAsync(id);

            olddata.Code = updateRegionDto.Code;
            olddata.Name = updateRegionDto.Name;
            olddata.RegionImageUrl = updateRegionDto.RegionImageUrl;

            // var regions = Shcontext.Region.Find(id);
            if (updateRegionDto == null)
            {
                return NotFound();
            }
            //اینجا نیاز نداریم که اپدیت رو فراخوانی کنیم چون اولددیتا ما با دبی کانتکست ترک می شود 
            await Shcontext.SaveChangesAsync();
            var regionDto = new RegionsDTOModel()
            {
                Id = olddata.Id,
                Code = updateRegionDto.Code,
                Name = updateRegionDto.Name,
                RegionImageUrl = updateRegionDto.RegionImageUrl
            };
            return Ok(regionDto);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var olddata =await Shcontext.Region.FindAsync(id);

        

            // var regions = Shcontext.Region.Find(id);
            if (olddata == null)
            {
                return NotFound();
            }
            //اینجا نیاز نداریم که اپدیت رو فراخوانی کنیم چون اولددیتا ما با دبی کانتکست ترک می شود 
             Shcontext.Region.Remove(olddata);
            await Shcontext.SaveChangesAsync();
            var regionDto = new RegionsDTOModel()
            {
                Id = olddata.Id,
                Code = olddata.Code,
                Name = olddata.Name,
                RegionImageUrl = olddata.RegionImageUrl
            };
            return Ok(regionDto);
        }

    }
}
