using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace Acme.BookStore.Authors
{
    public class AuthorManager : DomainService
    {
        private readonly IAuthorRepository authorRepository;

        public AuthorManager(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public async Task<Author> CreateAsync(string name, DateTime birthDate, string? shortBio = null)
        {
            Check.NotNullOrWhiteSpace(name, nameof(name));

            var existingAuthor = await authorRepository.FindByNameAsync(name);
            if (existingAuthor != null)
            {
                throw new AuthorAlreadyExistsException(name);
            }

            return new Author(
                GuidGenerator.Create(),
                name,
                birthDate,
                shortBio);
        }

        public async Task ChangeNameAsync(Author author, string newName)
        {
            Check.NotNull(author, nameof(author));
            Check.NotNullOrWhiteSpace(newName, nameof(newName));

            var existingAuthor = await authorRepository.FindByNameAsync(newName);
            if (existingAuthor != null && author.Id != existingAuthor.Id) throw new AuthorAlreadyExistsException(newName);

            author.ChangeName(newName);
        }
    }
}
