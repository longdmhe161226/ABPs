using Xunit;

namespace ApiDemo.EntityFrameworkCore;

[CollectionDefinition(ApiDemoTestConsts.CollectionDefinitionName)]
public class ApiDemoEntityFrameworkCoreCollection : ICollectionFixture<ApiDemoEntityFrameworkCoreFixture>
{

}
