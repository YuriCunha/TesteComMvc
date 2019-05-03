using PadraoMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadraoMvc.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationContext contexto;

        public ProdutoRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public IList<Produto> GetProdutos()
        {

            return contexto.Set<Produto>().ToList();
        }

        public void SaveProdutos(IList<Movie> filmes)
        {
            foreach (var filme in filmes)
            {

                if (!contexto.Set<Produto>().Where(p => filme.movieId == p.MovieId).Any())
                {
                    contexto.Set<Produto>().Add(new Produto(filme.movieId, filme.title, filme.genres));
                }



                contexto.SaveChanges();
            }


        }

        public void Incluir(Produto filme)
        {
            var ultimo = contexto.Set<Produto>().Last();
            filme.MovieId = (ultimo.MovieId)+1 ;
            contexto.Set<Produto>().Add(filme);
            contexto.SaveChanges();
        }

        
    }
    public class Movie
    {
        // (INICIAL MINUSCULA POR CAUSA DO JSON)
        public int movieId { get; set; }
        public string title { get; set; }
        public string genres { get; set; }
    }
}
