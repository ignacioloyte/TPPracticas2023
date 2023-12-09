﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
       
            public int IdCompra { get; set; }
            public int IdUsuario { get; set; }
            public int IdProveedor { get; set; }
            public Usuario oUsuario { get; set; }
            public Proveedor oProveedor { get; set; }
            public string TipoDocumento { get; set; }
            public string NumeroDocumento { get; set; }
            public decimal MontoTotal { get; set; }
            public DateTime FechaCreacion { get; set; }

    }
    
}
