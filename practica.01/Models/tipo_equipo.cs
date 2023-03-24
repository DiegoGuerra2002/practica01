using System.ComponentModel.DataAnnotations;
namespace practica._01.Models
{
    public class tipo_equipo
    {
        [Key]
        public int? id_tipo_equipo { get; set; }
        public string? descripcion { get; set; }
        public int? estado { get; set; }
    }
}
