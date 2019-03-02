using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basesdeDatos
{
    public class GlobalDBContext : DbContext
    {
        /*Constructor */
        public GlobalDBContext() : base("megacursoStringConexion") {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentModel());
        }

        // globalDBContext.Students() en el manager
        public DbSet<Student> Students() {
            return this.Set<Student>();
        }
    }
}
