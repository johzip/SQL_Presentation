using SQL_DEMO.Database;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace SQL_DEMO
{    
    class main
    {
        private static IConfiguration _iconfiguration;
        static void Main(string[] args)
        {
            GetAppSettingsFile();
            PrintStudents();
        }

        //Loads the json File into a SQL Client Config class, wich is used in StudentDA
        static void GetAppSettingsFile() 
        {
            var builder = new ConfigurationBuilder()
                                 .SetBasePath(Directory.GetCurrentDirectory())
                                 .AddJsonFile("Programm/appSettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }

        //Prints the Table of the Request, has to be set for each Request
        static void PrintStudents()
        {
            var studentDA = new StudentDA(_iconfiguration);
            var listStudentModel = studentDA.GetList("Faculty_Subjekt_Teacher");
            listStudentModel.ForEach(item => //Item is the given List by StudentDA
            {
                //This is the Output, can be used in any way you want                
                Console.WriteLine(item.Fac_FacultyName + "\t || " + item.Sub_SubjektName + "\t|| " + item.Tea_TeacherName );
            });
            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }
    }
}
