﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VPX.ApiModels;
using VPX.BusinessLogic.Core.Contracts.Accounts;

namespace VPX.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService accountService;

        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var jwt = await accountService.AuthAsync(model.Email, model.Password);
            var tokenPair = new TokenPair
            {
                Token = jwt.Token,
                ExpiredAt = jwt.ExpiredAt
            };

            return Ok(tokenPair);
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("verify")]
        public async Task<ActionResult> Verify(VerificationUserModel user)
        {
            await accountService.VerifyAsync(user);
            return Ok();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("restore")]
        public async Task<ActionResult> Restore(RestoreAccessModel restoreAccessModel)
        {
            await accountService.RestoreAccess(restoreAccessModel);
            return Ok();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("register")]
        public async Task<ActionResult<UserModel>> Register(RegisterUserModel user)
        {
            var createdUser = await accountService.RegisterAsync(user);
            return Ok(createdUser);
        }
    }
}
