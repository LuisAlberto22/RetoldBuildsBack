﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Retold.Api.Controllers
{
	public class TagController : Controller
	{
		// GET: api/<TagController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		// GET api/<TagController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<TagController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<TagController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<TagController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
