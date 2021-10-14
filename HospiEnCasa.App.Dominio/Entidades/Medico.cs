using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>Medico</c>
    /// Modela un Medico del equipo medico de apoyo 
    /// </summary>   
    public class Medico : Persona
    {
        /// Nombre de la especialidad medica del Médico  
        [Required(ErrorMessage="Este es un campo obligatorio")]
        [StringLength(50, ErrorMessage="Longitud Maxima 50")]
        public string Especialidad { get; set; }
        /// Código único del médico
        public string Codigo { get; set; }
         /// Registro Unico Nacional del Talento Humano 
        public string RegistroRethus { get; set; }
    }
}