using custom_service_discovery.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace custom_service_discovery.Api.Controllers
{
    [Route("api/Blog")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        [HttpGet("GetBlogs")]
        public IActionResult GetBlogs()
        {
            var lst = new List<BlogModel>()
            {
                new BlogModel()
                {
                    BlogId = 1,
                    BlogTitle = "Test",
                    BlogAuthor  = "Test",
                    BlogContent= "Test",
                    IsDeleted = false
                }
            };

            return Ok(lst);
        }
    }
}
