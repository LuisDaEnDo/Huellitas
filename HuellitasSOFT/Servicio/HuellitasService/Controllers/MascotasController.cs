using Huellitas.DTO.Mascotas;
using HuellitasService.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HuellitasService.Controllers
{
    public class MascotasController : ApiController
    {
        private IMascotaBL service;
        public MascotasController(IMascotaBL service)
        {
            this.service = service;
        }
        // GET: api/Mascotas
        public List<MascotaDTO> Get()
        {
            return service.ListarMascotas();
        }

    

        // POST: api/Mascotas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Mascotas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Mascotas/5
        public void Delete(int id)
        {
        }
    }
}
