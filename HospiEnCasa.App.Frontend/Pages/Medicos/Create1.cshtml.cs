using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Persistencia;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Frontend.Pages.Medicos
{
    public class Create1Model : PageModel
    {
        private readonly IRepositorioMedico _repoMedico;
        public Medico medico {get; set;}
        public Create1Model(IRepositorioMedico repoMedico)
        {
            _repoMedico =repoMedico;
        }
        public void OnGet()
        {
            medico = new Medico();
        }
        public IActionResult OnPost(Medico medico)
        {
            _repoMedico.AddMedico(medico);
            return RedirectToPage("Index1");
        }
    }
}
