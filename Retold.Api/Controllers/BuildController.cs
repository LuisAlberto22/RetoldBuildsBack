using Microsoft.AspNetCore.Mvc;
using Retold.Api.Data;
using Retold.Api.Dtos;
using Retold.Api.Dtos.Requests;
using Retold.Api.Dtos.Responses;
using Retold.Api.Entities;
using Retold.Api.Services.Interfaces;

namespace Retold.Api.Controllers
{
	public class BuildController : Controller
    {
		private readonly IBuildService buildService;

		public BuildController(IBuildService buildService)
        {
			this.buildService = buildService;
		}

        // GET: api/Build
        [HttpGet]
        public async Task<IActionResult> Get()
        {
			return Ok();
		}

        // GET: api/Build/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok();
		}

        // PUT: api/Build/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, Build build)
        {
            return Ok(build);
        }

        // POST: api/Build
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> Store(StoreBuildRequest request)
        {
			var buildCreated = await buildService.Store(request);

            return StatusCode(StatusCodes.Status201Created, new ApiResponse<BuildResponse>()
            {
                Code = StatusCodes.Status201Created,
                IsSuccess = true,
                data = buildCreated
            });
		}

        // DELETE: api/Build/5
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Destroy(int id)
        {
			return Ok();
		}
    }
}
