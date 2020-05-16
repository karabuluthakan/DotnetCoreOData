using Api.DataAccess;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class RegionsController : ODataController
    {
        private readonly GeolocationDbContext dbContext;

        public RegionsController(GeolocationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        [EnableQuery]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(dbContext.Regions);
        }
    }
}