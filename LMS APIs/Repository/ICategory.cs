using LMS_APIs.Models;

namespace LMS_APIs.Repository
{
    public interface ICategory
    {
        public IEnumerable<BookCategory> GetCategory();
        BookCategory GetCategoryById(int id);
        public BookCategory PostCategory(BookCategory category);
        BookCategory UpdateCategory(int id, BookCategory category);
        bool DeleteCategory(int id);
    }
}
