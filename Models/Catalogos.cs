using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalGrupo3.Models
{
    public class Catalogos
    {
        public int id {  get; set; }
        public string nombre { get; set; } = string.Empty;
        public string categoria { get; set; } = string.Empty;
        public float tarifa { get; set; }
        public int unidades { get; set; }
        public int estado { get; set; }
        public int categoria_id { get; set; }


    }
}
