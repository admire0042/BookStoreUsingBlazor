using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookAppBlazor.Data
{
    public class AuthorService: IAuthorService
    {
        public DateTime CreationDate { get; set; }
        public List<Author> Authors { get; set; }

        public AuthorService()
        {
            CreationDate = DateTime.Now;

            Authors = new List<Author>();

            Authors.Add(new Author(1, "Johnson", "White", "408 496 7223", "Menlo Park", "johnson.white@gmail.com", 11000));
            Authors.Add(new Author(2, "Marjorie", "Green", "415 986 7020", "Oakland", "marjoe.white@gmail.com", 12876));
            Authors.Add(new Author(3, "Cherie", "Carson", "415 548 7723", "Berkely", "cher.white@gmail.com", 13000));
            Authors.Add(new Author(4, "Michael", "0'Leary", "408 548 4828", "San jose", "mich.white@gmail.com", 20500));
            Authors.Add(new Author(5, "Dean", "Straight", "415 854 2919", "Oakland", "dean.white@gmail.com", 10200));

        }

        public List<Author> GetAuthors()
        {
            return Authors;
        }
        public Author GetAuthorById(int authorId)
        {
            return Authors.Where(auth => auth.AuthorId == authorId).FirstOrDefault();
        }

        public DateTime GetCreateDate()
        {
            return CreationDate;
        }

        public string GetVersion()
        {
            return "V1";
        }

        public bool SaveAuthor(Author author)
        {
            Authors.Add(author);
            return true;
        }
    }
}
