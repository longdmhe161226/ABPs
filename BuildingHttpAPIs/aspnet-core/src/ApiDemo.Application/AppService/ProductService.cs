using ApiDemo.IApiService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace ApiDemo.AppService
{
    [RemoteService(IsMetadataEnabled = false)]
    public class ProductService : ApiDemoAppService, IProductAppService
    {
        public string GetString(string key)
        {

            return key;
        }
    }
}
