using System.ComponentModel.DataAnnotations;
namespace practica._01.Models
{
    public class estados_equipo
    {
        [Key]
        public int? id_estados_equipo { get; set; }
        public string? descripcion { get; set; }
        public int? estado { get; set; }
    }
}
