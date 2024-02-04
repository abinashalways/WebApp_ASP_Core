using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography;

namespace WebApp_Core.Pages
{
    public class Sample7Model : PageModel
    {

        public string? Message; public List<EmpDetails> EmpList = new List<EmpDetails>();
        public void OnGet()
        {
        }
        public void OnPost(EmpDetails E,string B1)
        {
            
            EmpOperations EOP= new EmpOperations();
            int i = 0;
            if (B1.Equals("Insert"))
            {
                i = EOP.AddEmployee(E);
                Message = i + " Row(s) Added";
            }
            else if (B1.Equals("Update"))
            {
                i = EOP.UpdateEmployee(E);
                Message = i + " Row(s) Updated";

            }
            else if (B1.Equals("Delete"))
            {
                i = EOP.DeleteEmployee(E.EmpId);
                Message = i + " Row(s) Deleted";

            }
                  

            else if(B1.Equals("Find"))
            {

                //EOP.FindEmployee(E.EmpId);

                Message = "Record found successfully";
                EmpList =  EOP.FindEmployee(E.EmpId);
                //if (Emp != null)
                //{
                    
                //    Message = "Record found successfully";

                //    E.EmpId = Emp.EmpId;
                //    E.EName = Emp.EName;
                //    E.Designation = Emp.Designation;
                //    E.DOJ = Emp.DOJ;
                //    E.Salary = Emp.Salary;
                //    E.Deptno= Emp.Deptno;
                    
                //  EmpList.Add(E);
                //}
                //else
                //{
                //    Message = "Record not found";
                //}

            }

        }
        
       
    }
}
