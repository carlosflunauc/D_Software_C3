using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Frontend.Pages.Medicos
{
    public class Index1Model : PageModel
    {
        private readonly IRepositorioMedico _repoMedico;
        public IEnumerable<Medico> medicos {get; set;}

        public Index1Model(IRepositorioMedico repoMedico)
        {
            _repoMedico=repoMedico;
        }
        public void OnGet()
        {
            medicos= _repoMedico.GetAllMedicos();
        }
    }
}
