using Acme.BookStore.Authors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Acme.BookStore.Web.Pages.Authors
{
    public class EditAuthorModalModel : BookStorePageModel
    {

        [BindProperty]
        public EditAuthorViewModel Author { get; set; }
        private readonly IAuthorAppService authorAppService;

        public EditAuthorModalModel(IAuthorAppService authorAppService)
        {
            this.authorAppService = authorAppService;
        }

        public async Task OnGetAsync(Guid id)
        {
            var authorDto = await authorAppService.GetAsync(id);
            Author = ObjectMapper.Map<AuthorDto, EditAuthorViewModel>(authorDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await authorAppService.UpdateAsync(Author.Id,
                ObjectMapper.Map<EditAuthorViewModel,UpdateAuthorDto>(Author));

            return NoContent();
        }

        public class EditAuthorViewModel
        {
            [HiddenInput]
            public Guid Id { get; set; }
            [Required]
            [StringLength(AuthorConsts.MaxNameLenght)]
            public string Name { get; set; }
            [Required]
            [DataType(DataType.Date)]
            public DateTime BirthDate { get; set; }
            [TextArea]
            public string ShortBio { get; set; }

        }
    }
}
