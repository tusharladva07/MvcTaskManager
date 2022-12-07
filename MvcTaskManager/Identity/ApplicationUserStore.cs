﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MvcTaskManager.Identity
{
    public class ApplicationUserStore:UserStore<ApplicationUser>
    {
        public ApplicationUserStore(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {

        }
    }
}
