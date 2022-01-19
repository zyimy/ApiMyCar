using Registrarse.Data;
using Registrarse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Repositories
{
    public class RepositoryCoche
    {
        PersonasContext context;

        public RepositoryCoche(PersonasContext context)
        {
            this.context = context;

        }

        public List<Coche> GetCoches()
        {
            /*
            var categorias_productos = (from Imagen in context.Imagenes
                                        join Coche in context.Coches
                                           on Imagen.Idimagen equals Coche.IdCoche
                                        select new
                                        {
                                            Imagen.Idimagen,
                                            Imagen.imagen,
                                            IdCoche = Coche.IdCoche,
                                            Version = Coche.Version


                                        }).ToList();

            */
            return this.context.Coches.ToList();
        }

        public Coche BuscarCoches(int idcoche)

        {

            return this.context.Coches.SingleOrDefault(z => z.IdCoche == idcoche);

        }



        public IEnumerable<Coche> BuscarCoche(int marca_Id)

        {

            return context.Coches.Where(z => z.Marca == marca_Id).ToList();

        }

        public IEnumerable<Coche> BuscarVersiones(String models)

        {

            return context.Coches.Where(z => z.modelos == models).ToList();

        }

        public IEnumerable<Coche> BuscaCoche(int marca_Id, String modelo, String version, int anio)

        {

            var consulta = from datos in context.Coches

                           where datos.Marca == marca_Id

                           && datos.modelos == modelo

                           && datos.Version == version

                           && datos.Anio == anio

                           select datos;

            return consulta.ToList();

        }

        public IEnumerable<Coche> BuscarVersion(String version)

        {

            return this.context.Coches.Where(z => z.Version == version).ToList();

        }

        public void InsertarCoches(int id, int modelo_Id, int marca_Id, int combustible_Id, int puertas, int anio, int pvp, String version,
            String carroceria, String acabado, int plazashomologadas, String image, String models, String combustible)
        {
            Coche per = new Coche();
            per.IdCoche = id;
            per.Modelo = modelo_Id;
            per.Marca = marca_Id;
            per.Combustible = combustible_Id;
            per.Puertas = puertas;
            per.Anio = anio;
            per.Pvp = pvp;
            per.Version = version;
            per.Carroceria = carroceria;
            per.Acabado = acabado;
            per.plazasHomologadas = plazashomologadas;
            per.imagenes = image;
            per.modelos = models;
            per.combustibles = combustible;

            this.context.Coches.Add(per);
            this.context.SaveChanges();

        }

        public void ModificarCoches(int id, int modelo_Id, int marca_Id, int combustible_Id, int puertas, int anio, int pvp, String version,
          String carroceria, String acabado, int plazashomologadas, String image, String models, String combustible)
        {
            Coche per = this.BuscarCoches(id);
            per.IdCoche = id;
            per.Modelo = modelo_Id;
            per.Marca = marca_Id;
            per.Combustible = combustible_Id;
            per.Puertas = puertas;
            per.Anio = anio;
            per.Pvp = pvp;
            per.Version = version;
            per.Carroceria = carroceria;
            per.Acabado = acabado;
            per.plazasHomologadas = plazashomologadas;
            per.imagenes = image;
            per.modelos = models;
            per.combustibles = combustible;

            this.context.Coches.Add(per);
            this.context.SaveChanges();

        }

        public void eliminarCoche(int id)
        {
            Coche per = this.BuscarCoches(id);
            this.context.Coches
                .Remove(per);
            this.context.SaveChanges();
        }

    }
}
