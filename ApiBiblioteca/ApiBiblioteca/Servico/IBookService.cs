using ApiBiblioteca.Dto;
using ApiBiblioteca.Model;
using System.Collections.Generic;

namespace ApiBiblioteca.Servico {

    public interface IBookService {

        List<Book> BuscarLivros(FiltrosDto filtros);
    }
}
