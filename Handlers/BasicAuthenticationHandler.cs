using System;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ProductsApi.Data;
using ProductsApi.Repositories;

namespace ProductsApi.Handlers
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IUserRepository _context;
        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options, 
            ILoggerFactory logger,   
            UrlEncoder encoder, 
            ISystemClock clock,
            UserRepository context
            ) : base(options, logger, encoder, clock){
                _context = context;
            }   
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if(!Request.Headers.ContainsKey("Authorization")){
                return AuthenticateResult.Fail("No Authorization header");
            }

            try
            {
                var authenticationHeaderValue = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var bytes = Convert.FromBase64String(authenticationHeaderValue.Parameter);
                string[] credentials = Encoding.UTF8.GetString(bytes).Split(":");
                string emailAddress = credentials[0];
                string password = credentials[1];
                bool isValid = await _context.Verify(emailAddress, password);
                if(isValid == !true){
                     return AuthenticateResult.Fail("Invalid Username or Password");
                } else{
                    var claims = new[] {new Claim(ClaimTypes.Name, emailAddress)};
                    var identity = new ClaimsIdentity(claims, Scheme.Name);
                    var principal = new ClaimsPrincipal(identity);
                    var ticket = new AuthenticationTicket(principal, Scheme.Name);

                    return AuthenticateResult.Success(ticket);
                }
            }
            catch (System.Exception)
            {
                return AuthenticateResult.Fail("Error has occured");
            }

        }
    }
}