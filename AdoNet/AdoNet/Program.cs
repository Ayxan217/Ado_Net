using AdoNet.Data;
using AdoNet.Models;
using AdoNet.Services;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sql sql = new Sql();
            //sql.ExecuteCommnad("INSERT INTO People VALUES('test','testov',34)");


            StudentServices services = new StudentServices();
            Student student = new Student
            {
                Name = "Elöseddin",
                Surname = "Kosayev",
                Age = 24
            };
            Student student2 = new Student
            {
                Name = "Raul",
                Surname = "Kosayev",
                Age = 56
            };

            Student student3 = new Student
            {
                Name = "Elariz",
                Surname = "mensimov",
                Age = 16
            };

            Student student4 = new Student {
            Name = "agahüseyn",
            Surname = "Mirdavudov",
            Age = 45
            
            };
            Student student5 = new Student
            {
                Name = "resul",
                Surname = "Kazımov",
                Age = 25

            };


            //services.Add(student3);
            //services.Add(student4);
            //services.Add(student2);
            //services.Add(student);


            //services.Update(student5, 3);
            //services.Delete(2);
            //services.GetAll().ForEach(s => { Console.WriteLine($"{s.Id}. {s.Name} {s.Surname} {s.Age} "); });
            //services.Get(1);

          



        }
    }
}

