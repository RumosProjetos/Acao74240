using Abp.AspNetCore.Mvc.ViewComponents;

namespace Gandalf.Inc.Web.Views
{
    public abstract class IncViewComponent : AbpViewComponent
    {
        protected IncViewComponent()
        {
            LocalizationSourceName = IncConsts.LocalizationSourceName;
        }
    }
}
