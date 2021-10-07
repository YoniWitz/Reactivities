using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using Application;
using Domain;
using MediatR;
=======
using Domain;
>>>>>>> 6c8e6f1a503ae4da3c0f69d7644afb934f754803
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace API.Controllers
{
<<<<<<< HEAD
    public class ActivitiesController : BaseController
    {
        private readonly ILogger<ActivitiesController> _logger;

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await Mediator.Send(new List.Query());
=======
    [ApiController]
    [Route("[controller]")]
    public class ActivitiesController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly ILogger<ActivitiesController> _logger;

        public ActivitiesController(DataContext context, ILogger<ActivitiesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _context.Activities.ToListAsync();
>>>>>>> 6c8e6f1a503ae4da3c0f69d7644afb934f754803
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
<<<<<<< HEAD
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity(Activity activity)
        {
            return Ok(await Mediator.Send(new Create.Command { Activity = activity }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditActivity(Guid id, Activity activity)
        {
            activity.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { Activity = activity }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivitiy(Guid id)
        {
            return Ok(await Mediator.Send(new Delete.Command{ Id = id}));
=======
            return await _context.Activities.FindAsync(id);
>>>>>>> 6c8e6f1a503ae4da3c0f69d7644afb934f754803
        }
    }
}
