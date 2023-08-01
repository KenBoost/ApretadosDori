using Infraestructure.Model;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationCore.Services
{
    public class ServiceApretado : IServiceApretado
    {
        public void Eliminar(int id)
        {
            IRepositoryApretado repository = new RepositoryApretado();
            repository.Eliminar(id);
        }

        public Apretados GetApretadoPorID(int id)
        {
            IRepositoryApretado repository = new RepositoryApretado();
            return repository.GetApretadoPorID(id);
        }

        public IEnumerable<Apretados> GetApretados()
        {
            IRepositoryApretado repository = new RepositoryApretado();
            return repository.GetApretados();
        }

        public void Save(Apretados apretado)
        {
            IRepositoryApretado repository = new RepositoryApretado();
            repository.Save(apretado);
        }
    }
}
