using Microsoft.AspNetCore.Mvc;
using KellyTestProject.DBContext;
using System.Threading.Tasks;
using System.Collections.Generic;
using KellyTestProject.Model;
using Microsoft.EntityFrameworkCore;

namespace KellyTestProject.Controllers
{
    
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly MsSqlContext dbContext;
        public SectionController(MsSqlContext context)
        {
            dbContext = context;
        }

        [Route("api/[controller]")]
        [HttpGet]
        public async Task<List<Section>> Get()
        {
            return await dbContext.Sections.ToListAsync();
        }

        [Route("api/GetTopSection")]
        [HttpGet]
        public async Task<List<Section>> GetTopSection()
        {
            return await dbContext.Sections.FromSqlRaw("GetTopThreeSections").ToListAsync();
        }
    }
}
