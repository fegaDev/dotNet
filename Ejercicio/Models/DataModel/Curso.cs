using System.ComponentModel.DataAnnotations;

namespace Ejercicio.Models.DataModel
{

    public enum NivelCurso
    {
        Basico,
        Intermedio,
        Avanzado
    }
    public class Curso :  BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        
        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;

        [Required]
        public string DescripcionLarga { get; set; } = string.Empty;

        [Required]
        public string PublicoObjetivo { get; set; } = string.Empty;

        [Required]
        public string Objetivo { get; set; } = string.Empty;

        [Required]
        public string Requisitos { get; set; } = string.Empty;

        [Required]
        public NivelCurso Nivel { get; set; }
    }


}
