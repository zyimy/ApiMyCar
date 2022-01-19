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
    public class RestauranteController : ControllerBase
    {
        RepositoryRestaurante repo;

        public RestauranteController(RepositoryRestaurante repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Restaurante>> Get()
        {
            return this.repo.GetRestaurantes();
        }

        [HttpGet("{id}")]
        public ActionResult<Restaurante> Get(int id)
        {
            return this.repo.BuscarRestaurante(id);
        }

        [HttpPost]
        public void InsertarRestaurante(Restaurante restaurante)
        {
            this.repo.InsertarRestaurantes(restaurante.nombre,  restaurante.Telefono,
                restaurante.NombreCalle,restaurante.NumeroCalle, restaurante.Horario,restaurante.Imagen,restaurante.Descripcion);
        }

        [HttpPut]
        public void ModificarUsuarios(Restaurante restaurante)
        {
            this.repo.ModificarRestaurantes(restaurante.IdRestaurante, restaurante.nombre, restaurante.NombreCalle,
                restaurante.NumeroCalle, restaurante.Telefono, restaurante.Descripcion, restaurante.Horario, restaurante.Imagen);
        }

        [HttpDelete("{id}")]
        public void EliminarRestaurante(int id)
        {
            this.repo.eliminarRestaurante(id);
        }
    }
}
