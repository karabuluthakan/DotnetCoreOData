using Api.DataAccess;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class ContinentalsController : ODataController
    {
        private readonly GeolocationDbContext dbContext;

        public ContinentalsController(GeolocationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        [EnableQuery]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(dbContext.Continentals);
        }
    }
}