using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WalksAPI.Data;
using WalksAPI.Models.Domain;

namespace WalksAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {

        private readonly NZWalksDbContext dbContext;
        
        public RegionsController(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //GET ALL REGIONS
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = dbContext.Regions.ToList();

            return Ok(regions);


            //var regions = new List<Region>
            //{
            //    new Region
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "Western Region",
            //        Code = "WST",
            //        RegionImageUrl = "https://pin.it/4It3hTjtc"
            //    },

            //    new Region
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "Coastal Region",
            //        Code = "CSTL",
            //        RegionImageUrl = "https://pin.it/3fjiWQKnX"
            //    },

            //    new Region
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "Nairobi Region",
            //        Code = "NRB",
            //        RegionImageUrl = "https://pin.it/29ZBRwXz2"
            //    },

            //};



        }

        //GET REGION BY ID

        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            //var region = dbContext.Regions.FirstOrDefault(x => x.Id ==id); 
            //OR

            var region = dbContext.Regions.Find(id);
            if (region == null)
            {
                return NotFound();
            }
             return Ok(region);
        }
    }
}
