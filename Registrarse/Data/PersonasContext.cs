using Microsoft.EntityFrameworkCore;
using Registrarse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Data
{
    public class PersonasContext:DbContext
    {
        public PersonasContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Persona>Personas { get; set; }
        public DbSet<Coche> Coches { get; set; }

        public DbSet<Chasi> Chasis { get; set; }
        public DbSet<Modelo> Modelos { get; set; }

        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Imagen> Imagenes { get; set; }

        public DbSet<RegistroCliente> RegistroClientes { get; set; }

        public DbSet<Restaurante> Restaurantes { get; set; }

        public DbSet<Pack> Packs { get; set; }
    }



}
