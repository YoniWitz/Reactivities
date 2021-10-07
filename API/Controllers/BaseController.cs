<<<<<<< HEAD
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
=======
using Microsoft.AspNetCore.Mvc;
>>>>>>> 6c8e6f1a503ae4da3c0f69d7644afb934f754803

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController : ControllerBase
    {
<<<<<<< HEAD
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
       
=======

>>>>>>> 6c8e6f1a503ae4da3c0f69d7644afb934f754803
    }
}