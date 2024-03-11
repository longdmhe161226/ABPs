using ApiDemo.Samples;
using Xunit;

namespace ApiDemo.EntityFrameworkCore.Applications;

[Collection(ApiDemoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ApiDemoEntityFrameworkCoreTestModule>
{

}
