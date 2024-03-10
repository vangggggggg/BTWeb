using CrudBook.Models;

namespace CrudBook.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
        Book GetbyId(int id);
        void Add(Book book);
        void Update(Book book);
        void Delete(int Id);
    }
}
