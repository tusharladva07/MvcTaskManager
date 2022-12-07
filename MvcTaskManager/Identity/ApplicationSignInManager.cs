﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace MvcTaskManager.Identity
{
    public class ApplicationSignInManager : SignInManager<ApplicationUser>
    {
        public ApplicationSignInManager(ApplicationUserManager applicationUserManager, IHttpContextAccessor httpContextAccessor,
            IUserClaimsPrincipalFactory<ApplicationUser> userClaimsPrincipalFactory, IOptions<IdentityOptions> options, ILogger<ApplicationSignInManager> logger,
            IAuthenticationSchemeProvider authenticationSchemeProvider) : base(applicationUserManager, httpContextAccessor, userClaimsPrincipalFactory,
                options, logger, authenticationSchemeProvider)
        {

        }
    }
}
