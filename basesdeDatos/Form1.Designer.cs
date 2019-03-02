namespace basesdeDatos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_students = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.especialidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.finalizado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_LoadStudents = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTextSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView_students
            // 
            this.listView_students.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.nombre,
            this.especialidad,
            this.finalizado});
            this.listView_students.Location = new System.Drawing.Point(12, 41);
            this.listView_students.Name = "listView_students";
            this.listView_students.Size = new System.Drawing.Size(392, 249);
            this.listView_students.TabIndex = 0;
            this.listView_students.UseCompatibleStateImageBehavior = false;
            this.listView_students.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 25;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 57;
            // 
            // especialidad
            // 
            this.especialidad.Text = "Especialidad";
            this.especialidad.Width = 115;
            // 
            // finalizado
            // 
            this.finalizado.Text = "estado";
            this.finalizado.Width = 129;
            // 
            // btn_LoadStudents
            // 
            this.btn_LoadStudents.Location = new System.Drawing.Point(267, 296);
            this.btn_LoadStudents.Name = "btn_LoadStudents";
            this.btn_LoadStudents.Size = new System.Drawing.Size(138, 44);
            this.btn_LoadStudents.TabIndex = 1;
            this.btn_LoadStudents.Text = "Refrescar";
            this.btn_LoadStudents.UseVisualStyleBackColor = true;
            this.btn_LoadStudents.Click += new System.EventHandler(this.btn_LoadStudents_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(266, 348);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(138, 47);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.Text = "Guardar Estudiante";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(83, 296);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(177, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 322);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(83, 348);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(177, 20);
            this.txtEspecialidad.TabIndex = 5;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBoxEstado.Location = new System.Drawing.Point(82, 374);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(178, 21);
            this.comboBoxEstado.Sorted = true;
            this.comboBoxEstado.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Especialidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Estado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(267, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(138, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtTextSearch
            // 
            this.txtTextSearch.Location = new System.Drawing.Point(12, 10);
            this.txtTextSearch.Name = "txtTextSearch";
            this.txtTextSearch.Size = new System.Drawing.Size(248, 20);
            this.txtTextSearch.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 407);
            this.Controls.Add(this.txtTextSearch);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_LoadStudents);
            this.Controls.Add(this.listView_students);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_students;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader especialidad;
        private System.Windows.Forms.ColumnHeader finalizado;
        private System.Windows.Forms.Button btn_LoadStudents;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtTextSearch;
    }
}

