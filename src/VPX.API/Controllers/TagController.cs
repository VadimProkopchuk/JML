using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VPX.ApiModels;
using VPX.BusinessLogic.Core.Contracts.Tags;

namespace VPX.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class TagController : ControllerBase
    {
        private readonly ITagService tagService;

        public TagController(ITagService tagService)
        {
            this.tagService = tagService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TagModel>>> GetAll()
        {
            var tags = await tagService.GetAsync();
            return Ok(tags);
        }
    }
}
