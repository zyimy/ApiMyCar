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
    public class PersonaController : ControllerBase
    {
        RepositoryPersona repo;

        public PersonaController(RepositoryPersona repo)
        {
            this.repo = repo;
        }

        [HttpGet]

        public ActionResult<List<Persona>> Get()

        {

            return this.repo.GetPersonas();

        }

        [HttpGet("{id}")]

        public ActionResult<Persona> Get(int id)

        {

            return this.repo.BuscarPersona(id);

        }

        [HttpGet("{correo_electronico}/{contrasena}")]
        public IEnumerable<Persona> GetContrasena(String correo_electronico,String contrasena)

        {

            return this.repo.BuscarContrasena(correo_electronico,contrasena);

        }

        [HttpPost]
        public void InsertarPersonas(Persona persona)
        {
            this.repo.InsertarPersonas(persona.Nombre, persona.CorreoEletronico, persona.Contrasena);
        }

        [HttpPut]
        public void ModificarPersonas(Persona persona)
        {
            this.repo.ModificarPersonas(persona.IdPersona, persona.Nombre, persona.CorreoEletronico, persona.Contrasena);
        }

        [HttpDelete("{id}")]

        public void EliminarPersonas(int id)
        {
            this.repo.eliminarPersona(id);
        }

    }

}
