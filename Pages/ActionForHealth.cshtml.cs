using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azurewebapp.Pages
{
    public class ActionForHealthModel : PageModel
    {
        public void OnGet()
        {
            Response.Redirect("https://actionforhealth.novascotia.ca");
        }
    }
}
