using Registrarse.Data;
using Registrarse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Repositories
{
    public class RepositoryModelo
    {
        PersonasContext context;

        public RepositoryModelo(PersonasContext context)
        {
            this.context = context;

        }

        public List<Modelo> GetModelos()
        {

            return this.context.Modelos.ToList();
        }

        public Modelo BuscarModelos(int idModelo)

        {

            return this.context.Modelos.SingleOrDefault(z => z.IdModelo == idModelo);

        }



        public IEnumerable<Modelo> BuscarModelo(int marcaId)

        {

            return context.Modelos.Where(z => z.marca == marcaId).ToList();

        }
    }
}
