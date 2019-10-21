
using SQL_DEMO.Model;  
using Microsoft.Extensions.Configuration;  
using System;  
using System.Collections.Generic;  
using System.Data;  
using System.Data.SqlClient;  
namespace SQL_DEMO.Database
{
    public class StudentDAL
    {
        private string _connectionString;
        public StudentDAL(IConfiguration iconfiguration)
        {
            _connectionString = iconfiguration.GetConnectionString("Default");
        }
        public List<Student> GetList()
        {
            var listStudent = new List<Student>();            
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand("GET_ALL", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        listStudent.Add(new Student
                        {
                            firstName = rdr[0].ToString(),
                            lastName = rdr[1].ToString(),
                            age = Convert.ToInt32(rdr[2]),
                            studentID = Convert.ToInt32(rdr[3])
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listStudent;
        }
    }
}
