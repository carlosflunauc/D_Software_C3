using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages.Pacientes
{
    public class Index1Model : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public IEnumerable<Paciente> pacientes {get; set;}
        public int generoActual {get; set;}
        public string bActual {get; set;}

        public Index1Model(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente=repoPaciente;
        }

        public void OnGet(int genero, string b)
        {
           if (String.IsNullOrEmpty(b))
           {
              bActual = "";
            pacientes=_repoPaciente.GetAllPacientes(); 
           }
            else
        {
            bActual =b;
            pacientes=_repoPaciente.SeachPacientes(b);
        }
        }
    }
}
