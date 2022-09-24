using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Gandalf.Inc.EntityFrameworkCore;
using Gandalf.Inc.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Gandalf.Inc.Web.Tests
{
    [DependsOn(
        typeof(IncWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class IncWebTestModule : AbpModule
    {
        public IncWebTestModule(IncEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IncWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(IncWebMvcModule).Assembly);
        }
    }
}