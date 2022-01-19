using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Registrarse.Models;
using Registrarse.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registrarse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackController : ControllerBase
    {

        RepositoryPack repo;

        public PackController(RepositoryPack repo)
        {
            this.repo = repo;
        }

        [HttpGet]

        public ActionResult<List<Pack>> Get()

        {

            return this.repo.GetPacks();

        }


        [HttpGet("{id}")]

        public ActionResult<Pack> Get(int id)

        {

            return this.repo.BuscarPack(id);

        }

        [HttpPost]
        public void InsertarPacks(Pack pack)
        {
            this.repo.InsertarPack(pack.Descripcion, pack.Imagen, pack.Precio);
        }

        [HttpPut]
        public void ModificarPacks(Pack pack)
        {
            this.repo.ModificarPack(pack.IdPack,pack.Descripcion, pack.Imagen, pack.Precio);
        }

        [HttpDelete("{id}")]

        public void EliminarPack(int id)
        {
            this.repo.eliminarPack(id);
        }
    }
}
