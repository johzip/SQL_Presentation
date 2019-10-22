
using SQL_DEMO.Model;  
using Microsoft.Extensions.Configuration;  
using System;  
using System.Collections.Generic;  
using System.Data;  
using System.Data.SqlClient;  
namespace SQL_DEMO.Database
{
    public class StudentDA //<NameOfDatabase>DataAccess
    {
        private string _connectionString;
        public StudentDA(IConfiguration iconfiguration)
        {
            _connectionString = iconfiguration.GetConnectionString("Default"); //Link to the Json File
        }
        public List<ListingClass> GetList(string TagQuerry)
        {
            var listStudent = new List<ListingClass>();            
            try // if no connection for exaple
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    //TagQuerry is the parrameter tht is the Tag of the Procedure safed on the Server throught the Querry
                    //you should be able to write a command Querry istead of a tag
                    SqlCommand cmd = new SqlCommand(TagQuerry, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    //Reading all Lines of the Table 
                    while (rdr.Read())
                    {
                        listStudent.Add(new ListingClass
                        {
                            Fac_FacultyName = rdr[1].ToString(),
                            Sub_SubjektName = rdr[0].ToString(),
                            Tea_TeacherName = rdr[2].ToString()
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
