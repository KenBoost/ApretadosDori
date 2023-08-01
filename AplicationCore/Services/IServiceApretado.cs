using Infraestructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationCore.Services
{
    public  interface IServiceApretado
    {
        IEnumerable<Apretados> GetApretados();

        Apretados GetApretadoPorID(int id);

        void Save(Apretados apretado);

        void Eliminar(int id);
    }
}
