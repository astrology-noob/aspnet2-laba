using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace webapp2.Pages
{
	public class BindedForm : PageModel
	{
		[BindProperty] public string Name { get; set; }
		[BindProperty] public string Surname { get; set; }
		[BindProperty] public string Age { get; set; }
		[BindProperty] public string City { get; set; }
		public void OnPost(string name, string surname, int age, string city) 
		{ 
			ViewData["sentence"] = $"{name} {surname}, {age} lives in {city}."; 
		}
	}
}
