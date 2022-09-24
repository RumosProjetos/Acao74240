using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Gandalf.Inc.Controllers
{
    public abstract class IncControllerBase: AbpController
    {
        protected IncControllerBase()
        {
            LocalizationSourceName = IncConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
