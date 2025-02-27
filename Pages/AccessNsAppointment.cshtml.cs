using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azurewebapp.Pages
{
    public class AccessNsAppointmentModel : PageModel
    {
        public void OnGet()
        {
            Response.Redirect("https://www.cnsdev.ca/book-appointment-access-nova-scotia");
        }
    }
}
