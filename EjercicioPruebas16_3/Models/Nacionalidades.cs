using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioPruebas16_3.Models
{
    [Table("nacionalidades")]
    public class Nacionalidad
    {
        [Key]
        [Column("idNacionalidad")]
        public int IdNacionalidad { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
        [Column("bandera")]
        public string Bandera { get; set; }
    }
}
