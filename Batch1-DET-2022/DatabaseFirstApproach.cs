using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class DatabaseFirstApproach
    {
       public static void Main(string[] args)
        {
            //GetAllEmpDetails();
            //  GetEmpDetailsByID();
            // AddNewEmployee();
            //DeleteEmployee();
            //GetEmpSP();
            // RemovingEmpDetails();
            CallStoredProcwithSQLParamater_insert();
            Console.ReadLine();
        }

        //private static void DeleteEmployee()
        //{
        //    var ctx = new traineeContext();
        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 7521;
        //        employee.Ename = "RamShyam";
        //        employee.Sal = 1000;
        //        employee.Deptno = 30;
        //        employee.Job = "MGR";
        //        ctx.Update(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine(" New employee deleted");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void AddNewEmployee()
        //{
        //    var ctx = new traineeContext();
        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 2979;
        //        employee.Ename = "Ram";
        //        employee.Sal = 1000;
        //        employee.Deptno = 30;
        //        employee.Job = "Trainer";
        //        ctx.Add(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine(" New employee added");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //public static void GetEmpDetailsByID()
        //{
        //    var CTX = new traineeContext();
        //    var emp = CTX.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
        //    Console.WriteLine(emp.Ename + " "+emp.Sal + " "+emp.Job);
        //}

        private static void GetAllEmpDetails()
        {
            //var ctx = new traineeContext();
            //var emps = ctx.Emps;

            //foreach (var emp in emps)
            //{
            //    Console.WriteLine(emp.Ename + +" ");
            //}
            var CTX = new traineeContext();
            var emp = CTX.Emps.Where(e => e.Empno == 7788).SingleOrDefault();
            Console.WriteLine(emp.Ename + " " + emp.Sal + " " + emp.Job); 
        }
        private static void GetEmpSP()
        {
            var ctx = new traineeContext();
            var employee = ctx.Emps.FromSqlRaw("GetallEmpsDetails").ToList(); 
            //var employee = ctx.Emps.FromSqlRaw("GetallEmpsDetailsByEmpno @p0", 7654).ToList();

            foreach (var e in employee)
            {
                Console.WriteLine(e.Empno);
            }
        }
        //private static void RemovingEmpDetails()
        //{
        //    var ctx = new traineeContext();
        //    var Value = 2979;
        //    int employee = ctx.Database.ExecuteSqlRaw("RemoveEmployee @p0", Value);
        //    Console.WriteLine($"No Of Rows Affected {employee}");
        //}
        private static void CallStoredProcwithSQLParamater_insert()
        {
            var ctx = new traineeContext();
            var param = new SqlParameter[] {
new SqlParameter() {
ParameterName = "@empno",
SqlDbType = System.Data.SqlDbType.Int,
Size = 100,
Direction = System.Data.
ParameterDirection.Input,
Value = 2285
},

new SqlParameter() {
ParameterName = "@ename",
SqlDbType = System.Data.
SqlDbType.VarChar,
Size = 100,
Direction = System.Data.
ParameterDirection.Input,
Value = "Vinay"},


new SqlParameter() {
ParameterName = "@job",
SqlDbType = System.Data.
SqlDbType.VarChar,
Size = 100,
Direction = System.Data.
ParameterDirection.Input,
Value = "Trainer"},

new SqlParameter()
{
    ParameterName = "@mgr",
    SqlDbType = System.Data.
SqlDbType.VarChar,
    Size = 100,
    Direction = System.Data.
ParameterDirection.Input,
    Value = 7698
},

new SqlParameter()
{
    ParameterName = "@hiredate",
    SqlDbType = System.Data.
SqlDbType.Date,
    Size = 100,
    Direction = System.Data.
ParameterDirection.Input,
    Value = DateTime.Now
},
new SqlParameter()
{
    ParameterName = "@sal",
    SqlDbType = System.Data.
SqlDbType.Int,
    Size = 100,
    Direction = System.Data.
ParameterDirection.Input,
    Value = 5000
},
new SqlParameter()
{
    ParameterName = "@comm",
    SqlDbType = System.Data.
SqlDbType.Int,
    Size = 100,
    Direction = System.Data.
ParameterDirection.Input,
    Value = 750
},
new SqlParameter()
{
    ParameterName = "@deptno",
    SqlDbType = System.Data.
SqlDbType.Int,
    Size = 100,
    Direction = System.Data.
ParameterDirection.Input,
    Value = 30}
};



            try
            {
                 var result = ctx.Database.ExecuteSqlRaw("InsertEmployee @empno, @ename, @job,@mgr,@hiredate,@sal,@comm,@deptno", param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {


                throw;
            }

            Console.WriteLine("update successful");


        }
    }
}
