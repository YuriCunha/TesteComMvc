using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PadraoMvc.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PadraoMvc
{
    class DataService : IDataService
    {
        private readonly ApplicationContext contexto;
        private readonly IProdutoRepository produtoRepository;

        public DataService(ApplicationContext contexto,
                    IProdutoRepository produtoRepository)
        {
            this.contexto = contexto;
            this.produtoRepository = produtoRepository;
        }

        public void InicializaDB()
        {
            contexto.Database.Migrate();

            List<Movie> livros = GetFilmes();

            produtoRepository.SaveProdutos(livros);
        }

        private static List<Movie> GetFilmes()
        {
            var json = File.ReadAllText("movies.json");
            var livros = JsonConvert.DeserializeObject<List<Movie>>(json);
            return livros;
        }
    }
}
