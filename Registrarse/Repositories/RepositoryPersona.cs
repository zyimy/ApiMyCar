using Registrarse.Data;
using Registrarse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Repositories
{
    public class RepositoryPersona
    {
        PersonasContext context;

        public RepositoryPersona(PersonasContext context)
        {
            this.context = context;
                
        }

        public List<Persona> GetPersonas()
        {
            return this.context.Personas.ToList();
        }

       

        public Persona BuscarPersona(int idpersona)

        {

            return this.context.Personas.SingleOrDefault(z => z.IdPersona == idpersona);

        }

        public IEnumerable<Persona> BuscarContrasena(String correo_electronico,String contrasena)

        {

            var consulta = from datos in context.Personas

                           where datos.CorreoEletronico == correo_electronico
                           && datos.Contrasena == contrasena

                        

                           select datos;

            return consulta.ToList();

        }

        public void InsertarPersonas(string nombre,string correo_electronico,string contrasena)
        {
            Persona per = new Persona();
            
            per.Nombre = nombre;
            per.CorreoEletronico = correo_electronico;
            per.Contrasena = contrasena;
            this.context.Personas.Add(per);
            this.context.SaveChanges();
                
        }

        public void ModificarPersonas(int id, string nombre, string correo_electronico, string contrasena)
        {
            Persona per = this.BuscarPersona(id);
            per.IdPersona = id;
            per.Nombre = nombre;
            per.CorreoEletronico = correo_electronico;
            per.Contrasena = contrasena;
            this.context.SaveChanges();

        }

        public void eliminarPersona(int id)
        {
            Persona per = this.BuscarPersona(id);
            this.context.Personas.Remove(per);
            this.context.SaveChanges();
        }




    }
}
