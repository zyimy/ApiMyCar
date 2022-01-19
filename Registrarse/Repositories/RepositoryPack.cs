using Registrarse.Data;
using Registrarse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Repositories
{
   
    public class RepositoryPack
    {
        PersonasContext context;
        public RepositoryPack(PersonasContext context)
        {
            this.context = context;
        }

        public List<Pack> GetPacks()
        {
            return this.context.Packs.ToList();
        }

        public Pack BuscarPack(int Id)
        { 
            return this.context.Packs.SingleOrDefault(z => z.IdPack == Id);

        }

        public void InsertarPack(string descripcion, string imagen, int precio)
        {
            Pack pk = new Pack();
            pk.Descripcion = descripcion;
            pk.Imagen = imagen;
            pk.Precio = precio;


            this.context.Packs.Add(pk);
            this.context.SaveChanges();

        }

        public void ModificarPack(int id, string descripcion, string imagen, int precio)
        {
            Pack pk = BuscarPack(id);
            pk.Descripcion = descripcion;
            pk.Imagen = imagen;
            pk.Precio = precio;
            this.context.SaveChanges();

        }

        public void eliminarPack(int id)
        {
            Pack pk = this.BuscarPack(id);
            this.context.Packs.Remove(pk);
            this.context.SaveChanges();
        }






    }
}

