using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.OAuth;
using PropertyManager.Api.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManager.Api.Infrastructure
{
    public class PropertyManagerAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            using (var authRepository = new AuthorizationRepository())
            {
                var user = await authRepository.FindUser(context.UserName, context.Password);
                if (user == null)
                {
                    context.SetError("invalid_grant", "The user name or password is incorrect.");
                    return;
                }
            }

            var token = new ClaimsIdentity(context.Options.AuthenticationType);
            token.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
            token.AddClaim(new Claim("role", "user"));


            context.Validated(token);
        }
    }
}