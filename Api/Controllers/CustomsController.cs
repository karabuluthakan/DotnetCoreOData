using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class CustomsController : ODataController
    {
        [ODataRoute("getUser")]
        public IActionResult GetUser()
        {
            return Ok("Hakan Karabulut");
        }
    }
}