using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VPX.ApiModels;
using VPX.BusinessLogic.Core.Contracts.Lectures;

namespace VPX.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class LiteratureController : ControllerBase
    {
        private readonly ILiteratureService literatureService;

        public LiteratureController(ILiteratureService literatureService)
        {
            this.literatureService = literatureService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var literature = await literatureService.Get();
            return Ok(literature);
        }

        [HttpPost]
        public async Task<ActionResult> Post(LiteratureModel model)
        {
            await literatureService.Update(model.Content);
            return Ok();
        }
    }
}