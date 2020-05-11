using Abp.AspNetCore.Mvc.ViewComponents;

namespace Ogulcan.BookStore.Web.Views
{
    public abstract class BookStoreViewComponent : AbpViewComponent
    {
        protected BookStoreViewComponent()
        {
            LocalizationSourceName = BookStoreConsts.LocalizationSourceName;
        }
    }
}
