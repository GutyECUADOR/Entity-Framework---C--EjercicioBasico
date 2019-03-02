using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basesdeDatos
{
    class StudentManager
    {
        private List<Student> listStudents;
        
        public List<Student> GetStudents()
        {
            this.listStudents = new List<Student>();
            using (GlobalDBContext globalDBContext = new GlobalDBContext())
            {
                this.listStudents = globalDBContext.Students().ToList();
            }
            return this.listStudents;
        }

        public List<Student> searchStudent(string searchText) {

            using (GlobalDBContext globalDBContext = new GlobalDBContext())
            {
                IQueryable<Student> query = globalDBContext.Students();
                query = query.Where(row => row.nombre.Contains(searchText) || 
                                           row.especialidad.Contains(searchText)
                                    );
                query = query.OrderBy(row => row.nombre);
                return query.ToList();
            }

            
        }


        public void saveStudent(Student student) {

            using (GlobalDBContext globalDBContext = new GlobalDBContext())
            {
                globalDBContext.Students().Add(student);
                globalDBContext.SaveChanges();
            }
        }

    }   
}
