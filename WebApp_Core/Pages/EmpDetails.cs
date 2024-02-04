using System.Data.SqlClient;
using System.Data;

namespace WebApp_Core.Pages
{
    public class EmpDetails
    {
        public int EmpId {  get; set; }
        public string? EName { get; set; }
        public string? Designation { get; set; }
        public DateTime DOJ {  get; set; }
        public double Salary {  get; set; } 
        public int Deptno { get; set; }
    }
    public class EmpOperations
    {
        SqlConnection Con = new SqlConnection(@"server=DELL\SQLEXPRESS;user id=abinash;password=123;database=BATCH13");

        SqlCommand? Cmd; string? Query; public List<EmpDetails> EmpList = new List<EmpDetails>();

        public int AddEmployee(EmpDetails Emp)
        {
            Query = "insert into empdetails values(@P1,@P2,@P3,@P4,@P5,@P6)";
            Cmd = new SqlCommand(Query, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@P1", Emp.EmpId);
            Cmd.Parameters.AddWithValue("@P2", Emp.EName);
            Cmd.Parameters.AddWithValue("@P3", Emp.Designation);
            Cmd.Parameters.AddWithValue("@P4", Emp.DOJ);
            Cmd.Parameters.AddWithValue("@P5", Emp.Salary);
            Cmd.Parameters.AddWithValue("@P6", Emp.Deptno);
            Con.Open();
            int i = Cmd.ExecuteNonQuery();
            Con.Close();
            return i;
        }
        public int UpdateEmployee(EmpDetails Emp)
        {
            Query = "update empdetails set EName=@P1,Designation=@P2,DOJ=@P3,Salary=@P4,Deptno=@P5 where EmpId=@P6";
            Cmd = new SqlCommand(Query, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@P6", Emp.EmpId);
            Cmd.Parameters.AddWithValue("@P1", Emp.EName);
            Cmd.Parameters.AddWithValue("@P2", Emp.Designation);
            Cmd.Parameters.AddWithValue("@P3", Emp.DOJ);
            Cmd.Parameters.AddWithValue("@P4", Emp.Salary);
            Cmd.Parameters.AddWithValue("@P5", Emp.Deptno);
            Con.Open();
            int i = Cmd.ExecuteNonQuery();
            Con.Close();
            return i;
        }
        public int DeleteEmployee(int Id)
        {
            Query = "delete empdetails where EmpId=@P1";
            Cmd = new SqlCommand(Query, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@P1", Id);
            Con.Open();
            int i = Cmd.ExecuteNonQuery();
            Con.Close();
            return i;

        }
        #region For Sample7
        public List< EmpDetails> FindEmployee(int Id)
        {
            EmpDetails Emp = new EmpDetails();
            Query = "select * from empdetails where EmpId=@P1";
            Cmd = new SqlCommand(Query, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@P1", Id);
            Con.Open();
            SqlDataReader DR = Cmd.ExecuteReader();

            if (DR.Read())
            {
                Emp.EmpId = DR.GetInt32(0);
                Emp.EName = DR.GetString(1);
                Emp.Designation = DR.GetString(2);
                Emp.DOJ = DR.GetDateTime(3);
                Emp.Salary = Convert.ToDouble(DR[4]);
                Emp.Deptno = Convert.ToInt32(DR[5]);
                EmpList.Add(Emp);
            }
            
            Con.Close();

            return EmpList; // Return the EmpDetails object
        }
        #endregion

        #region For Sample8
        public List<EmpDetails> GetEmpData()
        {

            Cmd = new SqlCommand("select * from empdetails", Con);
            Con.Open();
            SqlDataReader DR = Cmd.ExecuteReader();
            EmpDetails Emp = new EmpDetails();
            while (DR.Read())
            {
               
                Emp.EmpId = DR.GetInt32(0);
                Emp.EName = DR.GetString(1);
                Emp.Designation = DR.GetString(2);
                Emp.DOJ = DR.GetDateTime(3);
                Emp.Salary = Convert.ToDouble(DR[4]);
                Emp.Deptno = Convert.ToInt32(DR[5]);
                EmpList.Add(Emp);
            }

            Con.Close();

            return EmpList;
        }
        #endregion 

    }






}
