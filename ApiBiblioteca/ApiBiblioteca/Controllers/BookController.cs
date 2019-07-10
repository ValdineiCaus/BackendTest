using ApiBiblioteca.Dto;
using ApiBiblioteca.Model;
using ApiBiblioteca.Servico;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiBiblioteca.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase {
     
        private readonly IBookService _service;

        public BookController(IBookService service)
        {
            _service = service;
        }

        public IEnumerable<Book> Get([FromQuery]string autor, [FromQuery]string nomelivro,
           [FromQuery]double? precoinicial, [FromQuery]double? precofinal,
           [FromQuery]string genero, [FromQuery]string ilustrador,
           [FromQuery]int? quantidadepaginasinicial, [FromQuery]int? quantidadepaginasfinal,
           [FromQuery]string ordenacaoascendente, [FromQuery]string ordenacaodescendente)
      {

            var filtros = new FiltrosDto
            {
                Autor = autor,
                NomeLivro = nomelivro,
                Genero = genero,
                Ilustrador = ilustrador,
                PrecoInicial = precoinicial,
                PrecoFinal = precofinal,
                QuantidadePaginasInicial = quantidadepaginasinicial,
                QuantidadePaginasFinal = quantidadepaginasfinal,
                OrdenacaoAscendente = ordenacaoascendente,
                OrdenacaoDescendente = ordenacaodescendente
            };

            return _service.BuscarLivros(filtros);
        }        
    }
}

