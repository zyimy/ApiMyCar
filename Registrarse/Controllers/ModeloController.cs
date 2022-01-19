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
    public class ModeloController : ControllerBase
    {
        RepositoryModelo repo;

        public ModeloController(RepositoryModelo repo)
        {
            this.repo = repo;
        }

        [HttpGet]

        public ActionResult<List<Modelo>> Get()

        {

            return this.repo.GetModelos();

        }

        [HttpGet("{id}")]
        public ActionResult<Modelo> GetBuscar(int id)

        {

            return this.repo.BuscarModelos(id);

        }

        [HttpGet("marca/{marcaId}")]

        public IEnumerable<Modelo> GetModelo(int marcaId)

        {

            return this.repo.BuscarModelo(marcaId);

        }
    }
}
