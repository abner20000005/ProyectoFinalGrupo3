using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalGrupo3.Models
{
    public class Clientes
    {
        public string Nombre { get; set; } = string.Empty;
        public int registro { get; set; }
        public int identidad { get; set; }
        public string correo { get; set; } = string.Empty;
        public int telefono { get; set; }
        public int estado { get; set; }

    }
}
