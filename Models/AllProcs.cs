using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Practice.Models
{
    public class AllProcs
    {
        public static string GetConnection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Contxt"].ConnectionString;
            }
        }
        public static DataTable GetCountries()
        {
            SqlConnection con = new SqlConnection(GetConnection);
            SqlCommand cmd = new SqlCommand("SELECT *,CASE WHEN Status=1 THEN 'Active' ELSE 'Inactive' END AS 'StatusName' FROM Country", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sd = new SqlDataAdapter(); // To call DataTable OR DataSet
            DataTable dt = new DataTable();
            try
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
            }
            catch (Exception) { }
            return dt;
        }
        public static DataTable Country_Select()
        {
            SqlConnection con = new SqlConnection(GetConnection);
            SqlCommand cmd = new SqlCommand("Select * from Country order by name asc", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
            }
            catch (Exception) { }
            return dt;
        }
        
        public static DataTable Dept_Select()
        {
            SqlConnection con = new SqlConnection(GetConnection);
            SqlCommand cmd = new SqlCommand("Select * from Dept_Name order by name asc", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
            }
            catch (Exception) { }
            return dt;
        }
        public static string COUNTRY_DATA(string Name, bool? Status)
        {
            SqlConnection con = new SqlConnection(GetConnection);
            SqlCommand cmd = new SqlCommand("COUNTRY_DATA", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@countryName", Name);
            cmd.Parameters.AddWithValue("@status", Status);
            string res = "1";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery(); //To execute query. And your sql query does not return any value.
            }
            catch (Exception) { res = "0"; }
            finally { con.Close(); }
            return res;
        }
        public static string Delete_Employee(int? Id)
        {
            SqlConnection con = new SqlConnection(GetConnection);
            SqlCommand cmd = new SqlCommand("Proc_Delete_Employee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Id);
            string res = "1";
            //Console.WriteLine("Data updated successfully!");
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                res = "0";
                //Console.WriteLine("Data not updated successfully!");
            }
            finally
            {
                con.Close();
            }
            return res;
        }
        public static string Employee_Data(int Id,string Name, string Email, string Phone, int? Gender, int? Age, int? Dept, double? Salary, string Address, string Country)
        {
            SqlConnection con = new SqlConnection(GetConnection);
            SqlCommand cmd = new SqlCommand("EmployeeData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@phone", Phone);
            cmd.Parameters.AddWithValue("@gender", Gender);
            cmd.Parameters.AddWithValue("@age", Age);
            cmd.Parameters.AddWithValue("@dept", Dept);
            cmd.Parameters.AddWithValue("@salary", Salary);
            cmd.Parameters.AddWithValue("@address", Address);
            cmd.Parameters.AddWithValue("@country", Country);
            string res = "1";
            //Console.WriteLine("Data updated successfully!");
            try
            {
                con.Open();
                cmd.ExecuteNonQuery(); 
            }
            catch (Exception ex) 
            {
                res = "0";
                //Console.WriteLine("Data not updated successfully!");
            }
            finally 
            {
                con.Close();
            }
            return res;
        }
        public static string Submit_EmployeeData(string Name, string Email, string Phone, int? Gender, int? Age, int? Dept, double? Salary, string Address, string Country)
        {
            SqlConnection con = new SqlConnection(GetConnection);
            SqlCommand cmd = new SqlCommand("SubmitEmpDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@phone", Phone);
            cmd.Parameters.AddWithValue("@gender", Gender);
            cmd.Parameters.AddWithValue("@age", Age);
            cmd.Parameters.AddWithValue("@dept", Dept);
            cmd.Parameters.AddWithValue("@salary", Salary);
            cmd.Parameters.AddWithValue("@address", Address);
            cmd.Parameters.AddWithValue("@country", Country);
            string res = "1";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                res = "0";
            }
            finally
            {
                con.Close();
            }
            return res;
        }
       

        public static DataTable GetEmployees()
        {
            SqlConnection con = new SqlConnection(GetConnection);
            //SqlCommand cmd=new SqlCommand("select Id,Name,Email,PhoneNum, CASE WHEN Gender=0 THEN 'Male' WHEN Gender=1 THEN 'Female' END AS 'GenderName',Age, CASE WHEN Department=0 THEN 'HR' WHEN department=1 THEN 'Sales' ELSE 'Development' END AS 'DeptName', Salary,Address,Country from Employees");
            SqlCommand cmd = new SqlCommand("Select * from EmployeeDetails", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
            }
            catch (Exception)
            {

            }
            return dt;
        }

        public static DataTable GetStateDetails()
        {
            SqlConnection con = new SqlConnection(GetConnection);
            SqlCommand cmd = new SqlCommand("SELECT * FROM StateDetails", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sd = new SqlDataAdapter(); // To call DataTable OR DataSet
            DataTable dt = new DataTable();
            try
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
            }
            catch (Exception) { }
            return dt;
        }

        public static DataTable GetCountryDetail(int? Id)
        {
            SqlConnection con = new SqlConnection(GetConnection);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Country WHERE Id=@Id", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("Id", Id);
            SqlDataAdapter sd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
            }
            catch (Exception) { }
            return dt;
        }

        public static DataTable GetEmployeeDetail(int? Id)
        {
            SqlConnection con = new SqlConnection(GetConnection);
            SqlCommand cmd = new SqlCommand("Select * from EmployeeDetails where Id=@Id", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("Id", Id);
            SqlDataAdapter sd = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                sd.SelectCommand = cmd;
                sd.Fill(dt);
            }
            catch (Exception) { }
            return dt;

        }


        public static int CountCities()
        {
            SqlConnection con = new SqlConnection(GetConnection);
            SqlCommand cmd = new SqlCommand("SELECT Count(Id) as 'Total' FROM City", con);
            cmd.CommandType = CommandType.Text;
            int res = -1;
            try
            {
                con.Open();
                var r = cmd.ExecuteScalar(); //To get Single Column from Database.
                if (r != null)
                    res = int.Parse(r.ToString());
            }
            catch (Exception) { }
            finally { con.Close(); }
            return res;
        }
    }
}