using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basesdeDatos
{
    public partial class Form1 : Form
    {
        private StudentManager studentManager;
        private List<Student> students;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            this.studentManager = new StudentManager();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void btn_LoadStudents_Click(object sender, EventArgs e)
        {
            listView_students.Items.Clear();
            loadStudents();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                nombre = txtNombre.Text,
                especialidad = txtEspecialidad.Text,
                finalizado = false
            };

            saveStudent(student);
            listView_students.Items.Clear();
            loadStudents();
        }

        private void loadStudents()
        {
            this.students =  studentManager.GetStudents();
            foreach (Student student in students)
            {
                ListViewItem row = listView_students.Items.Add(student.id.ToString());
                row.SubItems.Add(student.nombre);
                row.SubItems.Add(student.especialidad);
                row.SubItems.Add(student.finalizado.ToString());
            }
        }

        private void saveStudent(Student student) {
            this.studentManager.saveStudent(student);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listView_students.Items.Clear();
            string searchText = txtTextSearch.Text;
            this.students = studentManager.searchStudent(searchText);
            foreach (Student student in students)
            {
                ListViewItem row = listView_students.Items.Add(student.id.ToString());
                row.SubItems.Add(student.nombre);
                row.SubItems.Add(student.especialidad);
                row.SubItems.Add(student.finalizado.ToString());
            }
        }
    }
}
