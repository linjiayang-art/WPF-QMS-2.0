using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QMS.Api.Models;
using QMS.Api.Models.QmsContext;
using QMS.Api.Models.QmsContext.QmsSystem;
namespace QMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {

        private readonly QMSContext _context;

        public UserInfoController(QMSContext context)
        {
            _context = context;
        }

        [HttpGet]
        public  IActionResult Get()
        {
            return Ok(new
            {
                Name = "John Doe",
                Email = ""
            });
        }
        [HttpPost]
        public async Task<ActionResult<User>> PostTodoItem(User user)
        {
            _context.UserInfo.Add(user);
            await _context.SaveChangesAsync();

            //    return CreatedAtAction("PostTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(PostTodoItem), new { id = user.Id }, user);
        }
    }
}
