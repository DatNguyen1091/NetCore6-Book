using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore6_Book.Models;
using NetCore6_Book.Reponsitory;

namespace NetCore6_Book.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountRepository AccountRepository;

        public AccountsController(IAccountRepository repo)
        {
            AccountRepository = repo;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignUpModel signUpModel)
        {
            var resutl = await AccountRepository.SignUpAsync(signUpModel);
            if(resutl.Succeeded)
            {
                return Ok(resutl.Succeeded);
            }
            return Unauthorized();
        }

        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(SignInModel signInModel)
        {
            var resutl = await AccountRepository.SignInAsync(signInModel);
            if(string.IsNullOrEmpty(resutl))
            {
                return Unauthorized();
            }
            return Ok(resutl);
        }
    }
}
