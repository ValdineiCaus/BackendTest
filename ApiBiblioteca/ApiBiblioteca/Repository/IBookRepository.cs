using ApiBiblioteca.Model;
using System.Collections.Generic;

namespace ApiBiblioteca.Repository {
    public interface IBookRepository {

        List<Book> Query();
    }
}
