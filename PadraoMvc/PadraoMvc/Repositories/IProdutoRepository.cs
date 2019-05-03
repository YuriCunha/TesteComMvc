using System.Collections.Generic;
using PadraoMvc.Models;

namespace PadraoMvc.Repositories
{
    public interface IProdutoRepository
    {
        IList<Produto> GetProdutos();
        void SaveProdutos(IList<Movie> filmes);
        
        void Incluir(Produto filme);
        
    }
}