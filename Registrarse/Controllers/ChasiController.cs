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
    public class ChasiController : ControllerBase
    {
        RepositoryChasi repo;

        public ChasiController(RepositoryChasi repo)
        {
            this.repo = repo;
        }

        [HttpGet]

        public ActionResult<List<Chasi>> Get()

        {

            return this.repo.GetChasis();

        }

        [HttpGet("{id}")]
        public ActionResult<Chasi> GetBuscar(int id)

        {

            return this.repo.BuscarChasi(id);

        }

        [HttpGet("coche/{id_coche}")]

        public IEnumerable<Chasi> GetChasi(int id_coche)

        {

            return this.repo.BuscarCoche(id_coche);

        }
    }
}
