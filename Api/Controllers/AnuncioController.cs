using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Services;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnuncioController : ControllerBase
    {
        private readonly IAnuncioWebMotorsService _anuncioWebMotorsService;

        public AnuncioController(IAnuncioWebMotorsService anuncioWebMotorsService)
        {
            _anuncioWebMotorsService = anuncioWebMotorsService;
        }

		// GET: api/Anuncio
		[HttpGet]
		[Route("GetAnuncios")]
		public IActionResult GetMarujos()
		{
			return Ok(
				_anuncioWebMotorsService.GetAll()
				);
		}

		// GET: api/Anuncio/5
		[HttpGet("{id}")]
		[Route("GetAnuncio/{id}")]
		public IActionResult GetMarujo(int id)
		{
			return Ok(
				_anuncioWebMotorsService.Get(id)
				);
		}

		// POST: api/Anuncio
		[HttpPost]
		[Route("AddAnuncio")]
		public IActionResult Create([FromBody] AnuncioWebMotors model)
		{
			return Ok(
				_anuncioWebMotorsService.Create(model)
				);
		}

		[HttpPost]
		[Route("UpdateAnuncio")]
		public IActionResult Update([FromBody] AnuncioWebMotors model)
		{
			return Ok(
				_anuncioWebMotorsService.Update(model)
				);
		}

		// DELETE: api/ApiWithActions/5
		[HttpDelete("{id}")]
		[Route("DeleteAnuncio/{id}")]
		public IActionResult Delete(int id)
		{
			return Ok(
				_anuncioWebMotorsService.Delete(id)
				);
		}
	}
}