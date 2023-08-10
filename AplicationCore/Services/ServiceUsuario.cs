using Infraestructure.Model;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationCore.Services
{
    public class ServiceUsuario : IServiceUsuario
    {
        public Usuario LogIn(int id, string clave)
        {
            IRepositoryUsuario repository = new RepositoryUsuario();
            return repository.logIn(id, clave);
        }
    }
}
