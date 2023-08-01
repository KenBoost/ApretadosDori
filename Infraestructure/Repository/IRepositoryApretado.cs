using Infraestructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public interface IRepositoryApretado
    {
        IEnumerable<Apretados> GetApretados();

        Apretados GetApretadoPorID(int id);

        void Save(Apretados apretado);

        void Eliminar(int id);

    }
}
