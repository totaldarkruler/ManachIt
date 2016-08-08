using ManachIt.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManachIt.Entities.Entidades;

namespace ManachIt.DAL.Concrete
{
    public class ProductRepository : IProductRepository
    {
        public Producto Get(int productId)
        {
            throw new NotImplementedException();
        }
    }
}