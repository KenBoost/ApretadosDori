using Infraestructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class RepositoryApretado : IRepositoryApretado
    {
        public void Eliminar(int id)//Poner el estado del apretado en 0
        {
            using (MiContexto ctx = new MiContexto())
            {
                Apretados apretado = ctx.Apretados.FirstOrDefault(a => a.ID == id);
                if (apretado != null)
                {
                    apretado.estado = false;
                    ctx.SaveChanges();
                }
            }
        }

        public Apretados GetApretadoPorID(int id)
        {
            Apretados oApretado = null;
            using (MiContexto ctx = new MiContexto())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                oApretado = ctx.Apretados.Where(a => a.ID == id).FirstOrDefault();
            }
            return oApretado;
        }

        public IEnumerable<Apretados> GetApretados()
        {
            try
            {
                using (MiContexto ctx = new MiContexto())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;
                    return ctx.Apretados.ToList();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción aquí, puedes registrarla o hacer alguna otra acción necesaria.
                // Por ejemplo, podrías imprimir un mensaje de error:
                Console.WriteLine("Error al obtener la lista de Apretados: " + ex.Message);
                return Enumerable.Empty<Apretados>(); // Devolver una lista vacía en caso de error.
            }
        }


        public void Save(Apretados apretado)
        {
            using (MiContexto ctx = new MiContexto())
            {
                if (apretado.ID == 0) // Nuevo registro
                {
                    ctx.Apretados.Add(apretado);
                }
                else // Actualizar registro existente
                {
                    Apretados existingApretado = ctx.Apretados.FirstOrDefault(a => a.ID == apretado.ID);
                    if (existingApretado != null)
                    {
                        ctx.Apretados.Add(apretado);
                        ctx.Entry(apretado).State = (System.Data.Entity.EntityState)System.Data.EntityState.Modified;
                        ctx.SaveChanges();
                    }
                }

                ctx.SaveChanges();
            }
        }

    }
}
