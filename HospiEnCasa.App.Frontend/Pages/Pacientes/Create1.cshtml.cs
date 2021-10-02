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
    public class Create1Model : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public Paciente paciente {get; set;}

        public Create1Model(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente=repoPaciente;
        }
        public void OnGet()
        {
            paciente = new Paciente();
        }
        public IActionResult OnPost(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                _repoPaciente.AddPaciente(paciente);
                return RedirectToPage("Index1");
            } else
            {
                return Page();
            }
        }
    }
}
