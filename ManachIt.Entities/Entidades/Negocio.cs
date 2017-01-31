using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManachIt.Entities.Entidades
{
    public class Negocio
    {
        public int NegocioId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Rfc { get; set; }

        //Navegacion
        public List<Producto> Productos { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public List<Orden> Ordenes { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}
