using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp2.Pages
{
	public class FormModel : PageModel 
	{
		public const string NameFieldName = "Name";

		private string Name { get; set; } = string.Empty;
		private string Surname { get; set; } = string.Empty;

		public void OnPost()
		{
			Name = Request.Form[NameFieldName];
			Surname = Request.Form["Surname"]; 
			ViewData["sentence"] = $"Hi, my name is {Name} {Surname}!"; 
		} 
	}
}
