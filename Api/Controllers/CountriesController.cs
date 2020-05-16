using System.Linq;
using Api.DataAccess;
using Api.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class CountriesController : ODataController
    {
        private readonly GeolocationDbContext dbContext;

        public CountriesController(GeolocationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(dbContext.Countries);
        }

        [HttpPost]
        public IActionResult CountryNameAndSymbol([FromODataUri] int key)
        {
            var country = dbContext.Countries.FirstOrDefault(x => x.Id == key);
            var result = $"Name : {country.Name} - Symbol: {country.Alpha2Code}";
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CountryNameAndSymbolWithParameter(ODataActionParameters parameters)
        {
            var id = (int) parameters["countryId"];
            var country = dbContext.Countries.FirstOrDefault(x => x.Id == id);
            var result = $"Name : {country.Name} - Symbol: {country.Alpha3Code}";
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CountrySummary(ODataActionParameters parameters)
        {
            var name = parameters["name"].ToString();
            var unCode = parameters["unCode"].ToString();
            var alpha2Code = parameters["alpha2Code"].ToString();

            return Ok($"Name : {name}, Alpha Code : {alpha2Code}, Un Code : {unCode}");
        }

        [HttpPost]
        public IActionResult UserData(ODataActionParameters parameters)
        {
            var data = parameters["user"] as User;

            return Ok($"{data.FirstName} {data.LastName}");
        }

        [HttpGet]
        public IActionResult CountryCount()
        {
            var data = dbContext.Countries.Count();
            return Ok(data);
        }

        [HttpGet]
        public IActionResult Multiple([FromODataUri] int number1, [FromODataUri] int number2, [FromODataUri] int number3)
        {
            return Ok(number1 * number2 * number3);
        }
    }
}