using AdoNet.Data;
using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Services
{
    internal class StudentServices
    {
        private static Sql _sql;
        public StudentServices()
        {
            _sql = new Sql();
        }


        public void Add(Student student) {

         int result = _sql.ExecuteCommnad($"INSERT INTO People VALUES('{student.Name}', '{student.Surname}','{student.Age}')");
            if (result > 0)
            {
                Console.WriteLine("complected");

            }
            else 
            {
                Console.WriteLine("we have a problem");
            }
        
        }

        public List<Student> GetAll() {
            List<Student> students = new List<Student>();
            DataTable table = _sql.ExecuteQuery("SELECT * FROM People");

            foreach (DataRow item in table.Rows) {
                Student student = new Student
                {
                    Id = (int)item["Id"],
                    Name = item["Name"].ToString(),
                    Surname = item["Surname"].ToString(),
                    Age = (int)item["Age"]


                };
                students.Add(student);
            }

        return students;

        }

        public void Delete(int id) {

            _sql.ExecuteCommnad($"DELETE FROM People WHERE Id ={id}");
        
        }

        public void Get(int id) {
            Student student = null;
            DataTable table = _sql.ExecuteQuery($"SELECT Id, Name, Surname, Age FROM People WHERE Id={id}");
            foreach (DataRow item in table.Rows)
            {
                 student = new Student
                {
                    Id = (int)item["Id"],
                    Name = item["Name"].ToString(),
                    Surname = item["Surname"].ToString(),
                    Age = (int)item["Age"]


                };
              
            }
            if (student != null) {
            
            Console.WriteLine($"{student.Id} {student.Name} {student.Surname} {student.Age}");

            }
            else
            {
                Console.WriteLine("bele bir telebe yoxdur");
            }
            

        }

        public void Update(Student student)
        {
          
            int result = _sql.ExecuteCommnad($"UPDATE People SET Name = 'sasd' WHERE Id ={}");

            Console.WriteLine($"Rows affected: {result}");
        }


    }
}
