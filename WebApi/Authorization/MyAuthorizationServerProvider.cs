using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Claims;
using Microsoft.Owin.Security.OAuth;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Entity;

namespace WebApi.Authorization
{
    public class MyAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            ComplaintContext Con = new ComplaintContext();
            string Role="";

            bool User = Con.Profile.Any(a => a.UserName == context.UserName && a.Password == context.Password);
                       
            if(User)
            {
                var UserRole = Con.Profile.Where(a => a.UserName == context.UserName).Select(a => new
                {
                    RoleName = a.PTRef.Name
                });

                foreach (var r in UserRole)
                {
                    Role = r.RoleName;
                }

                identity.AddClaim(new Claim(ClaimTypes.Role, Role));
                identity.AddClaim(new Claim("username", context.UserName));
                identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
                context.Validated(identity);
            }
            else
            {
                context.SetError("invalid_grant", "provided username and password is incorrect");
            }
        }
    }
}