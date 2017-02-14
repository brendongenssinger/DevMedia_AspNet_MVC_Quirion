using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;
namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {

        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 3;
        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina=1)
        {
            ///Skip 
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos
                .OrderBy(p => p.Descricao).Skip((pagina -1 )*ProdutosPorPagina).Take(ProdutosPorPagina);
            return View(produtos);
        }

        //Metodos Take - Seleciona n primeiros do objetos.
        //Exemplo {2,3,4,5,6,7,8,9} no metodo Take passo apenas 3, ele vai retorna 2 3 4 .

        //Metodos Skip - Ignora os primeiros n do objetos.
        


    }
}