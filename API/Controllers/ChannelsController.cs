using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [Route("api/[controller]")]
  public class ChannelsController : Controller
  {
    [HttpGet]
    public IActionResult Get()
    {
      return Ok(new string[] { ".NetCore", "React", "Angular" });
    }
  }
}