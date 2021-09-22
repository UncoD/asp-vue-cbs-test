using Microsoft.AspNetCore.Mvc;
using ProtectedAreas.Data;
using ProtectedAreas.Models;

namespace ProtectedAreas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProtectedAreaController : ControllerBase
    {
        [HttpGet]
        public ProtectedArea Get()
        {
            return new AppDbSeedData().LoadProtectedArea();
        }
    }
}
