
namespace Ex_MaxiFront
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.txtNumEmpleado = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.Label();
            this.txtSsn = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(671, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleados Registrados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar Empleado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccion:";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(12, 244);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(16, 13);
            this.txtId.TabIndex = 4;
            this.txtId.Text = "Id";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(12, 274);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(44, 13);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Text = "Nombre";
            // 
            // txtApellidos
            // 
            this.txtApellidos.AutoSize = true;
            this.txtApellidos.Location = new System.Drawing.Point(12, 313);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(49, 13);
            this.txtApellidos.TabIndex = 6;
            this.txtApellidos.Text = "Apellidos";
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Location = new System.Drawing.Point(12, 352);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(93, 13);
            this.txtFecha.TabIndex = 7;
            this.txtFecha.Text = "Fecha Nacimiento";
            // 
            // txtNumEmpleado
            // 
            this.txtNumEmpleado.AutoSize = true;
            this.txtNumEmpleado.Location = new System.Drawing.Point(350, 244);
            this.txtNumEmpleado.Name = "txtNumEmpleado";
            this.txtNumEmpleado.Size = new System.Drawing.Size(65, 13);
            this.txtNumEmpleado.TabIndex = 8;
            this.txtNumEmpleado.Text = "N Empleado";
            // 
            // txtCurp
            // 
            this.txtCurp.AutoSize = true;
            this.txtCurp.Location = new System.Drawing.Point(350, 274);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(29, 13);
            this.txtCurp.TabIndex = 9;
            this.txtCurp.Text = "Curp";
            // 
            // txtSsn
            // 
            this.txtSsn.AutoSize = true;
            this.txtSsn.Location = new System.Drawing.Point(350, 313);
            this.txtSsn.Name = "txtSsn";
            this.txtSsn.Size = new System.Drawing.Size(29, 13);
            this.txtSsn.TabIndex = 10;
            this.txtSsn.Text = "SSN";
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoSize = true;
            this.txtTelefono.Location = new System.Drawing.Point(350, 352);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(49, 13);
            this.txtTelefono.TabIndex = 11;
            this.txtTelefono.Text = "Telefono";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(703, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 12;
            this.button2.Text = "Modificar Empleado/Beneficiario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(703, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 52);
            this.button3.TabIndex = 13;
            this.button3.Text = "Eliminar Empleado";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtSsn);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.txtNumEmpleado);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtApellidos;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.Label txtNumEmpleado;
        private System.Windows.Forms.Label txtCurp;
        private System.Windows.Forms.Label txtSsn;
        private System.Windows.Forms.Label txtTelefono;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

