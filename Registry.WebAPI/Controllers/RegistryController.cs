using Microsoft.AspNetCore.Mvc;
using Registry.Domain;
using Registry.Services;


namespace Registry.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistryController : ControllerBase
    {
        private readonly IRegistryService _registryService;
        public RegistryController(IRegistryService registryService)
        {
            _registryService = registryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _registryService.GetAllUserAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserData userData)
        {
            await _registryService.AddUserAsync(userData);
            return CreatedAtAction(nameof(GetAll), new {id = userData.ID}, userData);
        }
       
    }
}
