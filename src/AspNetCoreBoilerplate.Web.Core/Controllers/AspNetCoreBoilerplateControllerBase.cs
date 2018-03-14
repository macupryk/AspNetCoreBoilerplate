using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AspNetCoreBoilerplate.Controllers
{
    public abstract class AspNetCoreBoilerplateControllerBase: AbpController
    {
        protected AspNetCoreBoilerplateControllerBase()
        {
            LocalizationSourceName = AspNetCoreBoilerplateConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
