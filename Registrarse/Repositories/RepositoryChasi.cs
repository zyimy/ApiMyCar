using Registrarse.Data;
using Registrarse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Repositories
{
    public class RepositoryChasi
    {
        PersonasContext context;

        public RepositoryChasi(PersonasContext context)
        {
            this.context = context;

        }

        public List<Chasi> GetChasis()
        {

            return this.context.Chasis.ToList();
        }

        public Chasi BuscarChasi(int idchasi)

        {

            return this.context.Chasis.SingleOrDefault(z => z.IdChasis == idchasi);

        }



        public IEnumerable<Chasi> BuscarCoche(int coche_Id)

        {

            return context.Chasis.Where(z => z.Id_coche == coche_Id).ToList();

        }
    }
}
