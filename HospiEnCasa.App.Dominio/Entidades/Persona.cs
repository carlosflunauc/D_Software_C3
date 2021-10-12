using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio
{
    ///<summary>Class <c>Persona</c>
    /// Modelando una persona en el sistema
    ///</summary>
    public class Persona
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        [Required(ErrorMessage="Campo Obligatorio")]
        [StringLength(50, ErrorMessage="Longitud maxima 50")]
        public string Nombre { get; set; }
        [Required(ErrorMessage="Campo Obligatorio")]
        [StringLength(50, ErrorMessage="Longitud maxima 50")]
        public string Apellidos { get; set; }
        [Display(Name="Numero Telefonico")]
        public string NumeroTelefono { get; set; }
        // Genero de la persona
        public Genero Genero { set; get; }

    }
}