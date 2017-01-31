using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManachIt.Entities.Entidades
{
    public class Inventario
    {
        public int InventarioId { get; set; }
        public int Cantidad { get; set; }
        public string Almacen { get; set; }

        //Navegacion
        public int ProductoId { get; set; }
    }
}
