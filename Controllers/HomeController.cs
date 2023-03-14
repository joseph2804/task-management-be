using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly TaskManagementContext _db;
        public HomeController(TaskManagementContext db)
        {
            _db = db;
        }
        [HttpGet("list")]
        public async Task<ActionResult<IEnumerable<Mission>>> getAll()
        {
            return await _db.Mission.AsNoTracking()
                                       .OrderBy(x => x.TaskName)
                                       .ToListAsync();
        }

        [HttpPost("addNew")]
        public async Task<ActionResult<Mission>> AddNew(Mission mission)
        {
            _db.Mission.Add(mission);
            await _db.SaveChangesAsync();
            return CreatedAtAction("get", new { id = mission.TaskID }, mission);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Mission>> Get(long id)
        {
            var todoItem = await _db.Mission.AsNoTracking()
                                              .FirstOrDefaultAsync(x => x.TaskID == id);

            if (todoItem == null)
            {
                return NoContent();
            }

            return todoItem;
        }
    }
}
