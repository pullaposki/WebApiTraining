using Microsoft.AspNetCore.Mvc;

namespace WebApiTest2.Controllers
{
	public class Test1Controller : Controller
	{

		// Actions handle requests.
		// Public methods on a controller are actions.
		// Actions should map a request to business concern.

		// For example, you might have a UsersController with actions like GetUser, CreateUser, UpdateUser, and DeleteUser.
		// Each of these actions would correspond to a different HTTP method (GET, POST, PUT, DELETE) 

		// When a client makes a request to the /users endpoint of your API,
		// depending on the HTTP method of the request, different actions will be triggered.

		[Route("Test1/Action1")]
		public string ReadCookieAndHeader()
		{
			string testCookie = Request.Cookies["testCookie"];
			string testHeader = Request.Headers["testHeader"];
			return testHeader + " " + testCookie;
		}

		[Route("Test1/Action2")]
		public string WriteCookieAndHeader()
		{
			Response.Cookies.Append("NewCookie", "CookieValue",
				new CookieOptions()
				{
					Expires = DateTime.UtcNow.AddDays(30)
				});

			Response.Headers.Add("NewHeader", "HeaderValue");

			return "";
		}
	}
}
