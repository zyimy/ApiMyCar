using Registrarse.Data;
using Registrarse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Repositories
{


    public class RepositoryRegistro
    {
        PersonasContext context;

        public RepositoryRegistro(PersonasContext context)
        {
            this.context = context;
        }

        public List<RegistroCliente> GetRegistros()
        {
            return this.context.RegistroClientes.ToList();
        }

        public RegistroCliente BuscarRegistro(int Id)

        {

            return this.context.RegistroClientes.SingleOrDefault(z => z.IdRegistro == Id);

        }

        public IEnumerable<RegistroCliente> BuscarUsuario(String correo_electronico, String contrasena)

        {

            var consulta = from datos in context.RegistroClientes

                           where datos.CorreoEletronico == correo_electronico
                           && datos.Contrasena == contrasena
                           select datos;

            return consulta.ToList();

        }

        public void InsertarRegistros(string Nombre, string Apellido, string telefono, string correo_electronico, string contrasena,
         string calle, string numero, string piso)
        {
            RegistroCliente re = new RegistroCliente();

            re.nombre = Nombre;
            re.apellido = Apellido;
            re.CorreoEletronico = correo_electronico;
            re.Contrasena = contrasena;
            re.Telefono = telefono;
            re.Calle = calle;
            re.Numero = numero;
            re.Piso = piso;
            this.context.RegistroClientes.Add(re);
            this.context.SaveChanges();

        }

        public void ModificarRegistros( int id, string Nombre, string Apellido, string telefono, string correo_electronico, string contrasena,
         string calle, string numero, string piso)
        {
            RegistroCliente re = this.BuscarRegistro(id);
            re.IdRegistro = id;
            re.nombre = Nombre;
            re.apellido = Apellido;
            re.CorreoEletronico = correo_electronico;
            re.Contrasena = contrasena;
            re.Telefono = telefono;
            re.Calle = calle;
            re.Numero = numero;
            re.Piso = piso;
            this.context.SaveChanges();

        }

        public void eliminarRegistro(int id)
        {
            RegistroCliente re = this.BuscarRegistro(id);
            this.context.RegistroClientes.Remove(re);
            this.context.SaveChanges();
        }


    }
} 

