using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTask.Common.Entities
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del PRoducto es Obligatorio")]
        [StringLength(50, ErrorMessage = "Debe tener una longitud de 50 Caracteres.")]
        [Display(Name = "Nombre del PRoducto")]
        public string ProductName { get; set; }

        [Display(Name = "Precio $")]
        public decimal Price { get; set; }

        [Display(Name = "Categoria")]
        public string Category { get; set; }

        [Display(Name = "Presentacion Unidad")]
        public string Unidad { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha_Registro { get; set; }
    }
}
