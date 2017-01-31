using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManachIt.Entities.Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Rfc { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Activo { get; set; }

        //Navegacion
        public List<Orden> Ordenes { get; set; }


    }
}
