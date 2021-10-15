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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            //BuscarPaciente(1);
            //EliminarPaciente(6);
            MostrarPacientes();
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
                Nombre = "Pedro",
                Apellidos = "Perez",
                NumeroTelefono = "315657",
                Genero = Genero.Masculino,
                Direccion = "Carrera 6 No 7-4",
                Longitud = 5.07062F,
                Latitud = -75.52290F,
                Ciudad = "Pereira",
                FechaNacimiento = new DateTime(2000, 04, 12)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Medico.Nombre);
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
                Nombre = "Juliana",
                Apellidos = "Lopez",
                NumeroTelefono = "3001645",
                Genero = Genero.Femenino,
                Especialidad = "Internista",
                Codigo = "2535",
                RegistroRethus = "34567"
            };
            _repoMedico.AddMedico(medico);
        }

        private static void AsignarMedico()
        {
            var medico = _repoPaciente.AsignarMedico(3, 2);
            Console.WriteLine(medico.Nombre + " " + medico.Apellidos);
        }
/*
        private static void AddSignoVital()
        {
            var signoVital = new SignoVital
            {
                FechaHora = new DateTime(2021, 10, 02),
                Valor = 89,
                Signo = TipoSigno.SaturacionOxigeno
            };
            _repoSignoVital.AddSignoVital(signoVital);
        }

        private static void AsignarSignoVital()
        {
            var signoVital = _repoPaciente.AsignarSignoVital(1, 2);
            Console.WriteLine(signoVital.Signo + " " + signoVital.Valor);
        }

        private static void AsignarPaciente()
        {
            var paciente = _repoSignoVital.AsignarPaciente(1, 1);
            Console.WriteLine(paciente.Nombre + " " + paciente.Apellidos);
        }
*/

    }

}
