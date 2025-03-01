using Volo.Abp.Modularity;

namespace TeduEcommerce.Admin;

[DependsOn(
    typeof(TeduEcommerceApplicationModule),
    typeof(TeduEcommerceDomainTestModule)
    )]
public class TeduEcommerceApplicationTestModule : AbpModule
{

}
