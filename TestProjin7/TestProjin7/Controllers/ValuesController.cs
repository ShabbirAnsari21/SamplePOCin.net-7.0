using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestProjin7.Domain;

namespace TestProjin7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public ValuesController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<ActionResult> GetUserByEmail(string email)
        {
            var user = await _userRepository.GetUserByEmailId(email);
            return Ok(user);
        }
    }
}
