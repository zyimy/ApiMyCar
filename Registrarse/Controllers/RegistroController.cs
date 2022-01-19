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

    
    public class RegistroController : ControllerBase
    {

        RepositoryRegistro repo;

      public RegistroController(RepositoryRegistro repo)
        {
            this.repo = repo;
        }

        [HttpGet]

        public ActionResult<List<RegistroCliente>> Get()

        {

            return this.repo.GetRegistros();

        }

        [HttpGet("{id}")]

        public ActionResult<RegistroCliente> Get(int id)

        {

            return this.repo.BuscarRegistro(id);

        }

        [HttpGet("{correo_electronico}/{contrasena}")]
        public IEnumerable<RegistroCliente> GetContrasena(String correo_electronico, String contrasena)

        {

            return this.repo.BuscarUsuario(correo_electronico, contrasena);

        }

        [HttpPost]
        public void InsertarUsuarios(RegistroCliente registro)
        {
            this.repo.InsertarRegistros(registro.nombre, registro.apellido,registro.Telefono,
                registro.CorreoEletronico, registro.Contrasena,registro.Calle,registro.Numero,registro.Piso);
        }

        [HttpPut]
        public void ModificarUsuarios(RegistroCliente registro)
        {
            this.repo.ModificarRegistros(registro.IdRegistro, registro.nombre, registro.apellido, registro.Telefono,
                registro.CorreoEletronico, registro.Contrasena, registro.Calle, registro.Numero, registro.Piso);
        }

        [HttpDelete("{id}")]

        public void EliminarRegistros(int id)
        {
            this.repo.eliminarRegistro(id);
        }
    }
}
