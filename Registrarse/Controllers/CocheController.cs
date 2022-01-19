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
    public class CocheController : ControllerBase
    {

        RepositoryCoche repo;

        public CocheController(RepositoryCoche repo)
        {
            this.repo = repo;
        }

        [HttpGet]

        public ActionResult<List<Coche>> Get()

        {

            return this.repo.GetCoches();

        }

        [HttpGet("{id}")]
        public ActionResult<Coche> GetBuscar(int id)

        {

            return this.repo.BuscarCoches(id);

        }

        [HttpGet("marca/{marca_Id}")]

        public IEnumerable<Coche> GetCoche(int marca_id)

        {

            return this.repo.BuscarCoche(marca_id);

        }


        [HttpGet("modelos/{models}")]

        public IEnumerable<Coche> GetVersiones(String models)

        {

            return this.repo.BuscarVersiones(models);

        }

        [HttpGet("version/{version}")]
        public IEnumerable<Coche> Getversion(String version)

        {

            return this.repo.BuscarVersion(version);

        }


        [HttpGet("{marca_id}/{modelo}/{version}/{anio}")]
        public IEnumerable<Coche> GetversionCoches(int marca_Id, String modelo, String version, int anio)

        {

            return this.repo.BuscaCoche(marca_Id, modelo, version, anio);

        }

        /*

        [HttpPost]
        public void InsertarCoche(Coche persona)
        {
            this.repo.InsertarCoches(persona.IdCoche, persona.Modelo, persona.Modelo, persona.Combustible, persona.Puertas,
                persona.Anio, persona.Pvp, persona.Version, persona.Carroceria, persona.Acabado, persona.plazasHomologadas,persona.imagenes,
                persona.modelos,persona.combustibles);
        }

        [HttpPut]
        public void ModificarCoche(Coche persona)
        {
            this.repo.ModificarCoches(persona.IdCoche, persona.Modelo, persona.Modelo, persona.Combustible, persona.Puertas,
                persona.Anio, persona.Pvp, persona.Version, persona.Carroceria, persona.Acabado, persona.plazasHomologadas,
                persona.imagenes,
                persona.modelos, persona.combustibles);
        }

        */

        [HttpDelete("{id}")]

        public void EliminarCoche(int id)
        {
            this.repo.eliminarCoche(id);

        }

    }
 }