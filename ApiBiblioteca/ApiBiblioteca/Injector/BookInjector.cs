using ApiBiblioteca.Repository;
using ApiBiblioteca.Servico;
using Microsoft.Extensions.DependencyInjection;

namespace ApiBiblioteca.Injector {

    public class BookInjector {

        public static void RegistrarServicos(IServiceCollection services)
        {
            services.AddScoped<IBookRepository, BookRepository>();

            services.AddScoped<IBookService, BookService>();
        }
    }
}