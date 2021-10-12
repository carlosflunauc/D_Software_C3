using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>Persona</c>
     /// Modela una Persona en general en el sistema 
     /// </summary> 
    public class Persona
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        [Required(ErrorMessage="Campo Obligatorio")]
        [StringLength(50, ErrorMessage="Longitud Maxima 50")]
        public string Nombre { get; set; }
        [Required(ErrorMessage="Campo Obligatorio")]
        [StringLength(50, ErrorMessage="Longitud Maxima 50")] 
        public string Apellidos { get; set; }
        [Required(ErrorMessage="Campo Obligatorio")]
        [StringLength(20, ErrorMessage="Longitud Maxima 20")]
        public string NumeroTelefono { get; set; }
        // Genero de la persona
        public Genero Genero { set; get; }

    }
}