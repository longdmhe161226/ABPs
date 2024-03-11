using ApiDemo.Samples;
using Xunit;

namespace ApiDemo.EntityFrameworkCore.Domains;

[Collection(ApiDemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ApiDemoEntityFrameworkCoreTestModule>
{

}
