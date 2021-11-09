using System;
using System.Collections.Generic;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        private static IRepositorioMedico _repoMedico = new RepositorioMedico();
        private static IRepositorioSignoVital _repoSignoVital = new RepositorioSignoVital();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            BuscarPaciente(8);
            //EliminarPaciente(7);
            //MostrarPacientes();
            //AddMedico();
            //AsignarMedico();
            //AddSignoVital();
            //AsignarSignoVital();
            //AsignarPaciente();
        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Juan",
                Apellidos = "Londoño",
                NumeroTelefono = "3001645",
                Genero = Genero.Masculino,
                Direccion = "Calle 4 No 7-4",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1990, 04, 12)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
        }
        private static void EliminarPaciente(int idPaciente)
        {
            _repoPaciente.DeletePaciente(idPaciente);
            Console.WriteLine("paciente Eliminado");
        }
        private static void MostrarPacientes()
        {
            IEnumerable<Paciente> pacientes = _repoPaciente.GetAllPacientes();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine(paciente.Nombre + " " + paciente.Apellidos);
            }
        }
        private static void AddMedico()
        {
            var medico = new Medico
            {
                Nombre = "Gerardo",
                Apellidos = "Lopez",
                NumeroTelefono = "3001645",
                Genero = Genero.Pansexual,
                Especialidad = "Gastroenterologo",
                Codigo = "253523",
                RegistroRethus = "34567234"
            };
            _repoMedico.AddMedico(medico);
        }

        private static void AsignarMedico()
        {
            var medico = _repoPaciente.AsignarMedico(12, 10);
            Console.WriteLine(medico.Nombre + " " + medico.Apellidos);
        }

        private static void AddSignoVital()
        {
            var signoVital = new SignoVital
            {
                FechaHora = new DateTime(2021, 10, 02),
                Valor = 80,
                Signo = TipoSigno.SaturacionOxigeno
            };
            _repoSignoVital.AddSignoVital(signoVital);
        }

        private static void AsignarSignoVital()
        {
            var signoVital = _repoPaciente.AsignarSignoVital(11, 4);
            Console.WriteLine(signoVital.Signo + " " + signoVital.Valor);
        }

        private static void AsignarPaciente()
        {
            var paciente = _repoSignoVital.AsignarPaciente(2, 3);
            Console.WriteLine(paciente.Nombre + " " + paciente.Apellidos);
        }


    }

}
