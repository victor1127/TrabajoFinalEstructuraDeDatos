using System.ComponentModel.DataAnnotations;
using TrabajoFinalEstructuraDeDatos.Enums;

namespace TrabajoFinalEstructuraDeDatos.Models
{
    public class Tarea
    {
        public Tarea() 
        {
            Actualizacion = new Stack<EntidadCambios>();
        }
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public Priority Prioridad { get; set; }
        public Status Status { get; set; }
        public Category Categoria { get; set; }
        public Stack<EntidadCambios>? Actualizacion { get; set; }


        [Display(Name = "Fecha de inicio: ")]
        [DisplayFormat(DataFormatString = "{0:MMMM dd yyyy}")]
        public DateTime FechaInicio { get; set; }


        [Display(Name = "Vence: ")]
        [DisplayFormat(DataFormatString = "{0:MMMM dd yyyy}")]
        public DateTime FechaFinal { get; set; }
 
    }


    public class EntidadCambios
    {
        public DateOnly FechaCambio { get; set; }
        public EstadoEntidad EstadoEntidad { get; set; }
    }
}
