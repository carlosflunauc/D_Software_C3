using System;

namespace HospiEnCasa.App.Dominio
{
    /// <summary>Class <c>SignoVital</c>
    /// Modela los signos vitales del Paciente
    /// </summary>   
    public class SignoVital 
    {
        public int Id { get; set; }
        public DateTime FechaHora  { get; set; }
        public float Valor {get;set;}
        public TipoSigno Signo { get; set; }
        //public Paciente Paciente {get; set;}
    }
}