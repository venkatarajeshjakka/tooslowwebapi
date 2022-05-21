using System;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebApi.Controllers
{
	[ApiVersion("2.0")]
	[Route("api/[controller]")]
	[ApiController]
	public class NewProductController : ControllerBase
	{
		[HttpGet]
		public ActionResult GetProduct()
        {
			return Ok("Version2 response");
        }
	}
}

