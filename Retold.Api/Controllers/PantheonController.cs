using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Retold.Api.Dtos.Requests;
using Retold.Api.Dtos.Requests.Pantheon;
using Retold.Api.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Retold.Api.Controllers
{
	public class PantheonController : Controller
	{
		private readonly IPantheonService pantheonService;

		public PantheonController(IPantheonService pantheonService)
		{
			this.pantheonService = pantheonService;
		}

		// GET: api/<PantheonController>
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var pantheons = await pantheonService.Get();
			return Ok(pantheons);
		}

		// GET api/<PantheonController>/5
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var pantheon = await pantheonService.Get(id);
			return Ok(pantheon);
		}

		// POST api/<PantheonController>
		[HttpPost]
		public async Task<IActionResult> Store([FromBody] StorePantheonRequest request)
		{
			var pantheon = await pantheonService.Store(request);
			return Ok(pantheon);
		}

		// PUT api/<PantheonController>/5
		[HttpPut("{id}")]
		public async Task<IActionResult> Update(int id, [FromBody] UpdatePantheonRequest request)
		{
			var pantheon = await pantheonService.Update(id, request);
			return Ok(pantheon);
		}

		// DELETE api/<PantheonController>/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> Destroy(int id)
		{
			await pantheonService.Destroy(id);
			return Ok();
		}
	}
}
