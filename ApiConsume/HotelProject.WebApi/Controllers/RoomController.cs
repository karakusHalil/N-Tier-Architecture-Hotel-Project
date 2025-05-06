using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        [HttpGet]
        public IActionResult RoomList()
        {
            return Ok("Room List");
        }
        [HttpPost]
        public IActionResult AddRoom()
        {
            return Ok("Add Room");
        }
        [HttpDelete]
        public IActionResult DeleteRoom()
        {
            return Ok("Delete Room");
        }
        [HttpPut]
        public IActionResult UpdateRoom()
        {
            return Ok("Update Room");
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom()
        {
            return Ok("Get Room By Id");
        }
    }
}
