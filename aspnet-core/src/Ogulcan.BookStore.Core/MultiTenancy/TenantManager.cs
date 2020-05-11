using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Ogulcan.BookStore.Authorization.Users;
using Ogulcan.BookStore.Editions;

namespace Ogulcan.BookStore.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
