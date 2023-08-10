using Infraestructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class RepositoryUsuario : IRepositoryUsuario
    {

        public Usuario logIn(int id, string clave)
        {
            Usuario user = null;
            using (MiContexto ctx = new MiContexto())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                user = ctx.Usuario.Where(u => u.ID == id && u.clave == clave && u.estado == true).FirstOrDefault<Usuario>();
            }
            return user;
        }
    }
}
