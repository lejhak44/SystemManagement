using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Security.Claims;
using IAMS.Utility;
using System.Data.SqlClient;

namespace IAMS
{
    public class AuthorizationServerProvider : OAuthAuthorizationServerProvider
    {

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context) {
            context.Validated();
        }
        
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context) {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            try {
                dynamic CurrentUser = Utils.getUser(context.UserName, context.Password);
                identity.AddClaim(new Claim("Username", context.UserName));
                identity.AddClaim(new Claim("Password", context.Password));
                identity.AddClaim(new Claim(ClaimTypes.Role, "Admin"));
                identity.AddClaim(new Claim(ClaimTypes.Name, "Admin"));
                context.Validated(identity);
            } catch (SqlException sqlEx) {
                context.SetError("invalid_grant", sqlEx.Message);
                return;
            }
        }
        //
        //
        //
    }
}