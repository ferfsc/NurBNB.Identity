using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NurBnb.Identity.Application.Dto;
using NurBnb.Identity.Application.Services;
using System.Reflection.Metadata.Ecma335;

namespace NurBnb.Identity.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly ISecurityService _securityService;

        public SecurityController(ISecurityService securityService)
        {
            _securityService = securityService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDto model)
        {
            var result = await _securityService.Login(model.Username, model.Password);

            if (result.Success)
            {
                return Ok(new
                {
                    jwt = result.Value,
				name = result.Name
                });
            }
            else
            {
                return Unauthorized();
            }
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterAplicationUserModel model)
        {
		  //var result = await _securityService.Register(model, false, true);
		  var result = await _securityService.Register(model, false, false);

		  if (result.Success)
            {
                return Ok(new
                {
                    result
                });
            }
            else
            {
			 //return new Result(false,"sdasdsa" ); 
                return Unauthorized(result);
            }
        }

    }
}
