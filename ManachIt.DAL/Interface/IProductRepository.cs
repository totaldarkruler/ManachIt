using ManachIt.Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManachIt.DAL.Interfaces
{
    public interface IProductRepository
    {
        Producto Get(int productId);
    }
}