using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookAppBlazor.Data
{
    public interface IAuthorService
    {
        List<Author> GetAuthors();
        Author GetAuthorById(int authorId);
        DateTime GetCreateDate();
        string GetVersion();
        bool SaveAuthor(Author author);
    }
}
