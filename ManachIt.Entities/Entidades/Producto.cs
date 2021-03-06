﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManachIt.Entities.Entidades
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        //Navegacion
        public List<Orden> Ordenes { get; set; }
    }
}
