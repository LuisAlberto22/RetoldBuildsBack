using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Retold.Api.Controllers
{
	public class StepController : Controller
	{
		// GET: api/<StepController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<StepController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<StepController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<StepController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<StepController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
