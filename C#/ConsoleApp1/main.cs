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

        static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
                                 .SetBasePath(Directory.GetCurrentDirectory())
                                 .AddJsonFile("Programm/appSettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
        static void PrintStudents()
        {
            var studentDAL = new StudentDAL(_iconfiguration);
            var listStudentModel = studentDAL.GetList();
            listStudentModel.ForEach(item =>
            {
                Console.WriteLine(item.firstName + " || " + item.lastName + " || " + item.age + " || " + item.studentID);
            });
            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }
    }
}
