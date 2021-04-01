using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTask.Common.Entities
{
    public class Proveedor
    {
        public int Id { get; set; }
        public int Descripcion { get; set; }
        public string Direc { get; set; }
        public string Itbs { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
