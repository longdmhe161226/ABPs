using System;
using Acme.BookStore.Authors;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Acme.BookStore.Web.Pages.Authors
{
    public class CreateModalModel : BookStorePageModel
    {
        [BindProperty]
        public CreateAuthorViewModel Author {  get; set; }

        private readonly IAuthorAppService authorAppService;

        public CreateModalModel(IAuthorAppService authorAppService)
        {
            this.authorAppService = authorAppService;
        }
        public void OnGet()
        {
            Author = new CreateAuthorViewModel();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var dto =  ObjectMapper.Map<CreateAuthorViewModel, CreateAuthorDto>(Author);
            await authorAppService.CreateAsync(dto);
            return NoContent();
        }

        public class CreateAuthorViewModel
        {
            [Required]
            [StringLength(AuthorConsts.MaxNameLenght)]
            public string Name { get; set; } = string.Empty;

            [Required]
            [DataType(DataType.Date)]
            public DateTime BirthDate { get; set; }

            [TextArea]
            public string? ShortBio { get; set; }
        }
    }


}
