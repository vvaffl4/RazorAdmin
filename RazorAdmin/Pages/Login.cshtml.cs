using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorAdmin.Data;
using System.ComponentModel.DataAnnotations;


namespace RazorAdmin.Pages
{
	public class LoginModel : PageModel
	{
		private User defaultUser = new User { UserName = "Admin", Password = "Admin" };

		[BindProperty]
		public Login login { get; set; }

		public void OnGet()
		{
		}

		public IActionResult OnPost()
		{
			if (ModelState.IsValid)
			{
				if(defaultUser.UserName == login.UserName && defaultUser.Password == login.Password)
				{
					return RedirectToPage("Accounts");
				}
			}

			return RedirectToPage("Error");
		}

		public class Login : User { }

	}

}
