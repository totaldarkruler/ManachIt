using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManachIt.Entities.Entidades
{
    public class Orden
    {
        public int OrdenId { get; set; }
        public string FechaCreacion { get; set; }
        public string Descripcion { get; set; }

        //Nevegacion
    
        //public List<Producto> Productos { get; set; }

    }
}
