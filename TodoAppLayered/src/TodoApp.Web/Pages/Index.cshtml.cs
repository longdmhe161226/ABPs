using System.Collections.Generic;
using System.Threading.Tasks;

namespace TodoApp.Web.Pages;

public class IndexModel : TodoAppPageModel
{

    public List<TodoItemDto> Items { get; set; }
    private readonly ITodoAppService _service;

    public IndexModel(ITodoAppService service) { _service = service; }

    public async Task OnGetAsync()
    {
        Items = await _service.GetListAsync();
    }
}
