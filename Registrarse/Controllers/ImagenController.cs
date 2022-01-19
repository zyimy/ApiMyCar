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
    public class ImagenController : ControllerBase
    {

        RepositoryImagen repo;

        public ImagenController(RepositoryImagen repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Imagen>> Get()

        {

            return this.repo.GetImagenes();

        }

        [HttpGet("version/{version}")]

        public IEnumerable<Imagen> GetImagen(String version)

        {

            return this.repo.BuscarImagen(version);

        }
    }
}
