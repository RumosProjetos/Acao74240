using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Gandalf.Inc.Web.Views
{
    public abstract class IncRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected IncRazorPage()
        {
            LocalizationSourceName = IncConsts.LocalizationSourceName;
        }
    }
}
