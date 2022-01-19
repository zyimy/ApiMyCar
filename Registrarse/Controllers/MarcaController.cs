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
    public class MarcaController : ControllerBase
    {
        RepositoryMarca repo;

        public MarcaController(RepositoryMarca repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Marca>> Get()

        {

            return this.repo.GetMarcas();

        }

        [HttpGet("{id}")]
        public ActionResult<Marca> GetBuscar(int id)

        {

            return this.repo.BuscarMarcas(id);

        }
    }
}
