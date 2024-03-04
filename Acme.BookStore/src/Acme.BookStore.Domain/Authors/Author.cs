using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Authors
{
    public class Author : FullAuditedAggregateRoot<Guid>
    {

        public string Name { get; private set; }
        public DateTime BirthDate { get; set; }
        public string ShortBio {  get; set; }

        private Author()
        {

        }

        internal Author(Guid id, string name,DateTime birthDate, string? shortBio = null) : base(id)
        {
            SetName(name);
            BirthDate = birthDate;
            ShortBio = shortBio;
        }

        internal Author ChangeName(string name)
        {
            SetName(name);  
            return this;
        }

        private void SetName (string name)
        {
            Name = Check.NotNullOrWhiteSpace(name, nameof(name), maxLength: AuthorConsts.MaxNameLenght);
        }

    }
}
