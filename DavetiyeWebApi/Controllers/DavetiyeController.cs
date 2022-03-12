using DavetiyeBusiness.Abstract;
using DavetiyeEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavetiyeWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DavetiyeController : ControllerBase
    {
        private IDavetiyeService davetiyeService;
        public DavetiyeController(IDavetiyeService _davetiyeService)
        {
            davetiyeService = _davetiyeService;
        }

        [HttpGet]
        public IActionResult GetAllDavetiyes()
        {
            var davetiye = davetiyeService.GetDavetiyes();
            return Ok(davetiye);
        }

        [HttpPost]
        public IActionResult CreateDavetiye(Davetiye davetiye)
        {
            if (ModelState.IsValid)
            {
                var createdavetiye = davetiyeService.CreateDavetiye(davetiye);
                return Ok();
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult Listeleme(bool durum)
        {
            var gelen = davetiyeService.Katilmadurumu(durum);
            return Ok(gelen);
        }
    }
}
