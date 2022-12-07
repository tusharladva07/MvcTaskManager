using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MvcTaskManager.Identity
{
    public class ApplicationUserManager:UserManager<ApplicationUser>
    {
        public ApplicationUserManager(ApplicationUserStore applicationUserStore,IOptions<IdentityOptions> options,IPasswordHasher<ApplicationUser> passwordHasher,
            IEnumerable<IUserValidator<ApplicationUser>> userValidator,IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidator,ILookupNormalizer lookupNormalizer,
            IdentityErrorDescriber identityErrorDescriber,IServiceProvider serviceProvider,ILogger<ApplicationUserManager> logger)
            :base(applicationUserStore,options,passwordHasher,userValidator,passwordValidator,lookupNormalizer,identityErrorDescriber,serviceProvider,logger)   
        {

        }
    }
}
