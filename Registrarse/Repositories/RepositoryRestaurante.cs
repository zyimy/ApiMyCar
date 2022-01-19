using Registrarse.Data;
using Registrarse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Repositories
{
    public class RepositoryRestaurante
    {
        PersonasContext context;

      public  RepositoryRestaurante(PersonasContext context)
        {
            this.context = context;
        }

      

        public List<Restaurante> GetRestaurantes()
        {
            return this.context.Restaurantes.ToList();
        }

        public Restaurante BuscarRestaurante(int Id)

        {
            return this.context.Restaurantes.SingleOrDefault(z => z.IdRestaurante == Id);
        }

        public void InsertarRestaurantes(string Nombre, string Nombrecalle, string telefono, string horario,
        string numeroCalle, string descripcion,string imagen)
        {
            Restaurante res = new Restaurante();

            res.nombre = Nombre;
            res.Telefono = telefono;
            res.NombreCalle = Nombrecalle;
            res.NumeroCalle = numeroCalle;
            res.Horario = horario;
            res.Descripcion = descripcion;
            res.Imagen = imagen;
            this.context.Restaurantes.Add(res);
            this.context.SaveChanges();

        }

        public void ModificarRestaurantes(int id, string Nombre, string Nombrecalle, string telefono, string horario,
     string numeroCalle, string descripcion, string imagen)
        {
            Restaurante res = this.BuscarRestaurante(id);

            res.nombre = Nombre;
            res.Telefono = telefono;
            res.NombreCalle = Nombrecalle;
            res.NumeroCalle = numeroCalle;
            res.Horario = horario;
            res.Descripcion = descripcion;
            res.Imagen = imagen;
            this.context.SaveChanges();

        }

        public void eliminarRestaurante(int id)
        {
            Restaurante res = this.BuscarRestaurante(id);
            this.context.Restaurantes.Remove(res);
            this.context.SaveChanges();
        }



    }
}
