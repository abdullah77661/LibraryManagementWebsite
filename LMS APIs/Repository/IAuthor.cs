using YourNamespace.Models;

namespace LMS_APIs.Repository
{
    public interface IAuthor
    {
        public IEnumerable<Author> GetAuthors();
        Author GetAuthorById(int id);
        public Author PostAuthor(Author author);
        Author UpdateAuthor(int id, Author author);
        bool DeleteAuthor(int id);
    }
}
