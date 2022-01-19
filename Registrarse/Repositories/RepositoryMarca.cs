using Registrarse.Data;
using Registrarse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Repositories
{
    public class RepositoryMarca
    {
        PersonasContext context;

        public RepositoryMarca(PersonasContext context)
        {
            this.context = context;

        }

        public List<Marca> GetMarcas()
        {

            return this.context.Marcas.ToList();
        }

        public Marca BuscarMarcas(int id)

        {

            return this.context.Marcas.SingleOrDefault(z => z.Idmarca == id);

        }
    }
}
