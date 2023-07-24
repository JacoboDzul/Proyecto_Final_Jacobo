using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_23AM.Entities
{
    public class inventario
    {
        [Key]
        public int PkAlimento { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Proveedor { get; set; }
    }
}
