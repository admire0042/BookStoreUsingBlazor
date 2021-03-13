using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookAppBlazor.Data.APIServices
{
    public interface IAuthorApiService
    {
        [Get("/Author")]//this is from Refit, the /Authors is the name of my method in the API i.e the BookAPI
        Task<List<Author>> GetAuthors();
        [Post("/Author")]
        Task<Author> PostAuthor(Author author);

        [Delete("/Author /{id}")]
        Task<Author> DeleteAuth(int id);

        [Put("/Author/Edit/{id}")]
        Task<Author> EditAuth(Author author, int id);
    }
}
