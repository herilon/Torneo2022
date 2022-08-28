using System;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipio _repoMunicipio = new RepositorioMunicipio();
        private static IRepositorioEquipo _repoEquipo = new RepositorioEquipo();
        private static IRepositorioDirectorTecnico _repoDirectorTecnico = new RepositorioDirectorTecnico();
        static void Main(string[] args)
        {
            //AddMunicipio();
            //AddEquipo();
            //AddDirectorTecnico();
            GetAllMunicipios();
            GetAllDTs();
            GetAllEquipos();
        }

        private static void AddMunicipio()
        {
            var municipio = new Municipio
            {
                Nombre = "Manizales",
            };
            _repoMunicipio.AddMunicipio(municipio);
        }

        private static void AddEquipo()
        {
            var equipo = new Equipo
            {
                Nombre = "Once Caldas",
            };
            _repoEquipo.AddEquipo(equipo, 1, 1);
        }

        private static void AddDirectorTecnico()
        {
            var directorTecnico = new DirectorTecnico
            {
                Nombre = "Francisco",
                Documento = "1234",
                Telefono = "9876",
            };
            _repoDirectorTecnico.AddDirectorTecnico(directorTecnico);
        }


        private static void GetAllMunicipios()
        {
            foreach (var municipio in _repoMunicipio.GetAllMunicipios())
            {
                Console.WriteLine(municipio.Id + " " + municipio.Nombre);
            }
        }


        private static void GetAllDTs()
        {
            foreach (var directorTecnico in _repoDirectorTecnico.GetAllDTs())
            {
                Console.WriteLine(directorTecnico.Id + " " + directorTecnico.Nombre);
            }
        }

private static void GetAllEquipos()
{
    foreach (var equipo in _repoEquipo.GetAllEquipos())
    {
        Console.WriteLine(equipo.Nombre + " " 
            + equipo.Municipio.Nombre + " " + equipo.DirectorTecnico.Nombre);
    }
}


/*
        private static void DeletePaciente()
        {
            _repoPaciente.DeletePaciente(2);
        }


        private static void AddMedico()
        {
            var medico = new Medico
            {
                Nombre = "Juanita",
                Apellidos = "Gomez",
                NumeroTelefono = "3001645",
                Genero = Genero.Femenino,
                Especialidad = "Internista",
                Codigo = "123456",
                RegistroRethus = "ABC123",
            };
            _repoMedico.AddMedico(medico);
        }

        private static void AsignarMedico()
        {
            var medico = _repoPaciente.AsignarMedico(1, 3);
            Console.WriteLine(medico.Nombre + " " + medico.Apellidos);
        }
*/
    }
}