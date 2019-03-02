using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basesdeDatos
{
    public class Student
    {
        public int id { get; set;}
        public string nombre { get; set; }
        public string especialidad { get; set; }
        public bool finalizado { get; set; }

        public Student(){}

        public Student(int id, string nombre, string especialidad, bool finalizado)
        {
            this.id = id;
            this.nombre = nombre;
            this.especialidad = especialidad;
            this.finalizado = finalizado;
        }
    }
}
