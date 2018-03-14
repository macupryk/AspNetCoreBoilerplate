using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspNetCoreBoilerplate.Configuration;

namespace AspNetCoreBoilerplate.Web.Host.Startup
{
    [DependsOn(
       typeof(AspNetCoreBoilerplateWebCoreModule))]
    public class AspNetCoreBoilerplateWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AspNetCoreBoilerplateWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspNetCoreBoilerplateWebHostModule).GetAssembly());
        }
    }
}
