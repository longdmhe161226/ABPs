using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace ApiDemo.IApiService
{
    public interface IProductAppService : IApplicationService
    {
        string GetString(string key);
    }
}
