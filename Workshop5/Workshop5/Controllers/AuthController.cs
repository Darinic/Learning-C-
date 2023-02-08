using Microsoft.AspNetCore.Mvc;
using Workshop5.API.Core.Interfaces;
using Workshop5.API.Core.Requests.Auth;

namespace Workshop5.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : Controller
	{
		private readonly IStudentService _studentService;

		public AuthController(IStudentService studentService)
		{
			_studentService = studentService;
		}

		[HttpPost("register")]
		public async Task<IActionResult> RegisterAsync([FromBody] CreateStudentRequest request)
		{
			if (ModelState.IsValid)
			{
				var result = await _studentService.RegisterStudentAsync(request);

				if (result.IsSuccess)
				{
					return Ok(result);
				}

				return BadRequest(result);

			}

			return BadRequest("Some properties are not valid"); //status code : 400

		}
	}
}
