using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStore.Authors
{
    public class UpdateAuthorDto
    {

        [Required]
        [StringLength(AuthorConsts.MaxNameLenght)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateTime BirthDate { get; set; }
        public string? ShortBio { get; set; }
    }
}
