using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using Acme.BookStore.Web.Pages.Authors;
using AutoMapper;
using static Acme.BookStore.Web.Pages.Authors.EditAuthorModalModel;

namespace Acme.BookStore.Web;

public class BookStoreWebAutoMapperProfile : Profile
{
    public BookStoreWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
    
        CreateMap<BookDTO,CreateUpdateBookDto>();
        CreateMap<CreateModalModel.CreateAuthorViewModel, CreateAuthorDto>();

        CreateMap<EditAuthorViewModel, UpdateAuthorDto>();
        CreateMap<AuthorDto, EditAuthorViewModel>();
    }
}
