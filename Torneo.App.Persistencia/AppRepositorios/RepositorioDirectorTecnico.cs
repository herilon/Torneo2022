using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public class RepositorioDirectorTecnico : IRepositorioDirectorTecnico
    {
        private readonly DataContext _dataContext = new DataContext();

        public DirectorTecnico AddDirectorTecnico(DirectorTecnico directorTecnico)
        {
            var directorTecnicoInsertado = _dataContext.DirectoresTecnicos.Add(directorTecnico);
            _dataContext.SaveChanges();
            return directorTecnicoInsertado.Entity;
        }

        public IEnumerable<DirectorTecnico> GetAllDTs()
        {
            return _dataContext.DirectoresTecnicos;
        }

        public DirectorTecnico GetDT(int idDT)
        {
            return _dataContext.DirectoresTecnicos.Find(idDT);
        }
    }
}

