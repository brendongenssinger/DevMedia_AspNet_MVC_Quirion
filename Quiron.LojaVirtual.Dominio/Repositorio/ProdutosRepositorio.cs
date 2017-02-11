using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Quiron.LojaVirtual.Dominio.Entidades;
namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfBbContext _context = new EfBbContext();

        public IEnumerable<Produto> Produtos
        {

            get { return _context.Produtos; }
        }

        
    }
}
