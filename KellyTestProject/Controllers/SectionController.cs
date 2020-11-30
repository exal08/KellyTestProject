using Microsoft.AspNetCore.Mvc;
using KellyTestProject.DBContext;
using System.Threading.Tasks;
using System.Collections.Generic;
using KellyTestProject.Model;
using Microsoft.EntityFrameworkCore;

namespace KellyTestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly MsSqlContext dbContext;
        public SectionController(MsSqlContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        public async Task<List<Section>> Get()
        {
            return await dbContext.Sections.ToListAsync();
        }
    }
}
