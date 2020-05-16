using System.Linq;
using Api.DataAccess;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    // [ODataRoutePrefix("cities")]
    public class CitiesController : ODataController
    {
        private readonly GeolocationDbContext dbContext;

        public CitiesController(GeolocationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [EnableQuery(PageSize = 10)]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(dbContext.Cities);
        }

        // [EnableQuery]
        // [ODataRoute]
        // public IActionResult GetCity([FromODataUri] int key)
        // {
        //     return Ok(dbContext.Cities.Where(x => x.Id == key));
        // }

        // [EnableQuery]
        // [ODataRoute("cities({itemId})")]
        // public IActionResult GetSehir(int itemId)
        // {
        //     return Ok(dbContext.Cities.Where(x => x.Id == itemId));
        // }

       
        
    }
}