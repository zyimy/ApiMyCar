using Microsoft.AspNetCore.Mvc;
using Registrarse.Data;
using Registrarse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Repositories
{
    public class RepositoryImagen
    {
        PersonasContext context;

        public RepositoryImagen(PersonasContext context)
        {
            this.context = context;

        }

        public List<Imagen> GetImagenes()
        {

            return this.context.Imagenes.ToList();
        }

        public Imagen BuscarImagenes(int id)

        {

            return this.context.Imagenes.SingleOrDefault(z => z.Idimagen == id);

        }

        public IEnumerable<Imagen> BuscarImagen(String version)

        {

            return context.Imagenes.Where(z => z.version == version).ToList();

        }


    }
}
