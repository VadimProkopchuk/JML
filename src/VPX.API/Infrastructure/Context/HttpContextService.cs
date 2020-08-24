using System;
using Microsoft.AspNetCore.Http;
using VPX.BusinessLogic.Core.Contracts.Systems;

namespace VPX.API.Infrastructure.Context
{
    public class HttpContextService : IContextService
    {
        private readonly IHttpContextAccessor contextAccessor;

        public HttpContextService(IHttpContextAccessor contextAccessor)
        {
            this.contextAccessor = contextAccessor;
        }

        public Guid? GetCurrentUserId()
        {
            var userId = contextAccessor.HttpContext.User.Identity.Name;

            if (Guid.TryParse(userId, out var id))
            {
                return id;
            }

            return null;
        }
    }
}
