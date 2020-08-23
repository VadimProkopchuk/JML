﻿using System.Threading.Tasks;
using JML.Presentation.WebClient.Infrastructure.Managers.Uploader;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JML.Presentation.WebClient.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImagesController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> Upload([FromForm] IFormFile file)
        {
            if (file.Length > 0)
            {
                var image = await FileUploader.UploadToBase64(file);
                return Ok(new { image });
            }

            return BadRequest();
        }
    }
}