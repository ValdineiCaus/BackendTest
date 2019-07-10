using ApiBiblioteca.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ApiBiblioteca.Repository {
    public class BookRepository : IBookRepository {

        public List<Book> Query()
        {
            var json = File.ReadAllText(@"../ApiBiblioteca/Json/books.json");

            var books = JsonConvert.DeserializeObject<List<Book>>(json);

            return books;
        }
    }
}
