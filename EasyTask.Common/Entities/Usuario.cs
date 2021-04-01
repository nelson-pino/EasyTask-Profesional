using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTask.Common.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Logging { get; set; }
        public string NameUser { get; set; }
        public string PassWord { get; set; }
        public string TypeUser { get; set; }
    }
}
