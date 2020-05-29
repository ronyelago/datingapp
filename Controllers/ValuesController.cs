using datingapp.api.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext dataContext;

        public ValuesController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var values = dataContext.Values.ToList();

            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var value = await dataContext.Values.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(value);
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
