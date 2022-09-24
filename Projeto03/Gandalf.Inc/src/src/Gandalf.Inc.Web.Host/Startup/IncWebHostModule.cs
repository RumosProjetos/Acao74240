using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Gandalf.Inc.Configuration;

namespace Gandalf.Inc.Web.Host.Startup
{
    [DependsOn(
       typeof(IncWebCoreModule))]
    public class IncWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public IncWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IncWebHostModule).GetAssembly());
        }
    }
}
