using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProtectedAreas.Data.Repositories.Interfaces;

namespace ProtectedAreas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProtectedAreaController : ControllerBase
    {
        private readonly IProtectedAreaRepository _protectedAreaRepository;

        public ProtectedAreaController(IProtectedAreaRepository protectedAreaRepository)
        {
            _protectedAreaRepository = protectedAreaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            var protectedArea = await _protectedAreaRepository.GetAsync(id);
            return protectedArea != null ? Ok(protectedArea) : NotFound();
        }
    }
}
