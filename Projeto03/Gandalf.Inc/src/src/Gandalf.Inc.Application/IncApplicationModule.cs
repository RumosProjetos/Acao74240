using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Gandalf.Inc.Authorization;

namespace Gandalf.Inc
{
    [DependsOn(
        typeof(IncCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class IncApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<IncAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(IncApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
