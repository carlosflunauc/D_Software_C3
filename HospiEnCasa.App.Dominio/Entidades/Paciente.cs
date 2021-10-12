using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio
{
    ///<summary>Class <c>Paciente</c>
    /// Modelando el paciente que estan atendiendo en el Hospital
    ///</summary>
    public class Paciente : Persona
    {
        public string Direccion { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public string Ciudad { get; set; }
        [Display(Name="Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        public FamiliarDesignado Familiar { get; set; }
        public Enfermera Enfermera { get; set; }
        public Medico Medico { get; set; }
        public Historia Historia { get; set; }
        ///<summary>
        ///Referencia a la lista de signos vitales de un paciente
        ///</summary>
        ///<value></value>
        public List<SignoVital> SignosVitales { get; set; }
    }
}