using System.Collections.Generic;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class RepositorioSignoVital : IRepositorioSignoVital
    {
        private readonly AppContext _appContext = new AppContext();

        SignoVital IRepositorioSignoVital.AddSignoVital(SignoVital signoVital)
        {
            var signoVitalAdicionado = _appContext.SignosVitales.Add(signoVital);
            _appContext.SaveChanges();
            return signoVitalAdicionado.Entity;
        }

        IEnumerable<SignoVital> IRepositorioSignoVital.GetAllSignosVitales()
        {
            return _appContext.SignosVitales;
        }

        SignoVital IRepositorioSignoVital.GetSignoVital(int idSignoVital)
        {
            return _appContext.SignosVitales.Find(idSignoVital);
        }

        Paciente IRepositorioSignoVital.AsignarPaciente(int idSignoVital, int idPaciente){
        {
            var signoVitalEncontrado = _appContext.SignosVitales.Find(idSignoVital);
            if (signoVitalEncontrado != null)
            {
                var pacienteEncontrado = _appContext.Pacientes.Find(idPaciente);
                if (pacienteEncontrado != null)
                {
                    signoVitalEncontrado.Paciente = pacienteEncontrado;
                    _appContext.SaveChanges();
                }
                return pacienteEncontrado;
            }
            return null;
        }

        }

    }
}
