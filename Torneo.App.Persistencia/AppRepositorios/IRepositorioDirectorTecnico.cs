using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public interface IRepositorioDirectorTecnico
    {
        public DirectorTecnico AddDirectorTecnico(DirectorTecnico directorTecnico);
        public IEnumerable<DirectorTecnico> GetAllDTs();
        public DirectorTecnico GetDT(int idDT);
    }
}