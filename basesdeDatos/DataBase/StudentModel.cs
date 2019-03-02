using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using System.Threading.Tasks;

namespace basesdeDatos
{
    /*Mapeo de la clase a tabla*/
    class StudentModel : EntityTypeConfiguration<Student>
    {
        public StudentModel() {
            /*En el constructor se pueden definir el nombre personalizado de la columna, el nombre de la tabla, etc*/

            this.Property(property => property.id).HasColumnName("ID");
            this.ToTable("student");
        }

        
    }
}
