using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PadraoMvc.Models;
using PadraoMvc.Repositories;

namespace PadraoMvc.Controllers
{
    public class FilmeController : Controller
    {
        private readonly IProdutoRepository produtoRepository;
        

        public FilmeController(IProdutoRepository produtoRepository)
        {
            this.produtoRepository = produtoRepository;
        }

        public IActionResult Index()
        {
            
            return View(produtoRepository.GetProdutos());
        }

        public IActionResult Novo()
        {
            
            return View();
        }

        public IActionResult Incluir(Produto filme)
        {

            produtoRepository.Incluir(filme);
            return View();
        }

        
    }
}