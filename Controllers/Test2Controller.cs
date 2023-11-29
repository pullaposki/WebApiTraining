using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Controllers
{
	public class Test2Controller : Controller
	{
		[Route("Test2/action1")]
		public string StringAction([FromQuery] string stringParam, [FromQuery] int intParam)
		{
			return "test response1: " + stringParam + ", " + intParam.ToString();
		}

		[Route("Test2/action2")]
		public string StringAction2([FromForm] string stringParam, [FromForm] int intParam)
		{
			return "test response2: " + stringParam + ", " + intParam.ToString();
		}

		[Route("Test2/action3")]
		public string StringAction3([FromBody] TestObject testObject)
		{
			return "test response3: " + testObject.Name;
		}
	}

	public class TestObject
	{
		public string Name { get; set; }
		public int Id { get; set; }
	}
}
