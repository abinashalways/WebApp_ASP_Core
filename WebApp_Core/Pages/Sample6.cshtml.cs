using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp_Core.Pages
{
    public class Sample6Model : PageModel
    {
        public string? Message;
        public void OnGet()
        {

          

        }
        public void OnPost(string T1, string T2, string B1) 
        { 
           int a=Convert.ToInt32(T1);
            int b=Convert.ToInt32(T2);
            
            
            if (B1.Equals("Add"))
            {
                Message = $"The Addition of {a} and {b} is "+(a + b);
            }
            else if (B1.Equals("Subtract"))
            {
                Message = $"The Subtraction of {a} and {b} is " + (a - b);
            }
            if (B1.Equals("Multiply"))
            {
                Message = $"The Multiplication of {a} and {b} is " + (a * b);
            }
            if (B1.Equals("Division"))
            {
                Message = $"The Division of {a} and {b} is " + (a / b);
            }
        }
    }
}
