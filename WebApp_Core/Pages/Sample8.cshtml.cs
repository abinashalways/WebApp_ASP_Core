using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_Core.Pages
{
    public class Sample8Model : PageModel
    {
          public string? Message;
        public List<EmpDetails> EmpList = new List<EmpDetails>();
        EmpOperations EOP = new EmpOperations();
        public void OnGet()
        {
            Message = "This Is 1st Request";
            EmpList = EOP.GetEmpData();

        }
    }
   
}
