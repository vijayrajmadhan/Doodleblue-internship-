using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using worldapi.Data;
using worldapi.Models;

namespace worldapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        public CountryController(ApplicationDBContext dbContext) => _dbContext = dbContext;

        [HttpPost]
        public ActionResult<Country> Create([FromBody]Country country)
        {
            _dbContext.Countries.Add(country);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
