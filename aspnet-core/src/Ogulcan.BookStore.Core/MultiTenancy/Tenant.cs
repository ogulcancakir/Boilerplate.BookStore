using Abp.MultiTenancy;
using Ogulcan.BookStore.Authorization.Users;

namespace Ogulcan.BookStore.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
