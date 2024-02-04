using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_Core.Pages
{
    public class Sample5Model : PageModel
    {
        public string? Message ;
        public void OnGet()
        {
            Message = "this is 1st request";
        }
        public void OnPost()
        {
            Message = "this is post back request";
        }
    }
}
