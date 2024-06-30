using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entidades
{
    public class Articulos
    {
        public int Id { get; set; }

        public int Codigo { get; set; } 

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

        public bool Estado { get; set; }

        public DateTime FechaAdicion { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
