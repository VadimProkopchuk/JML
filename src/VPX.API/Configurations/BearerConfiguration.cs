﻿using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using VPX.Models.Settings;

namespace VPX.API.Configurations
{
    internal static class BearerConfiguration
    {
        public static void ConfigureBearerAuth(this IServiceCollection services, AppSettings settings)
        {
            var key = Encoding.ASCII.GetBytes(settings.Jwt.Secret);

            services
                .AddAuthentication(x =>
                {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = true,
                        ValidIssuer = settings.Jwt.Issuer,
                        ValidateAudience = true,
                        ValidAudience = settings.Jwt.Audience,
                        ValidateLifetime = true,
                    };
                });
        }
    }
}