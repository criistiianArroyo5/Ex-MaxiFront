using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_MaxiFront
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Peticiones servicio = new Peticiones();
            var a = servicio.catalogoEmepleados();
            DataTable table = JsonConvert.DeserializeObject<DataTable>(a);
            dataGridView1.DataSource = table;

            txtId.Text = "Id:          " + this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtNombre.Text = "Nombre: " + this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtApellidos.Text = "Apellidos: " + this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtFecha.Text = "Fecha Nacimiento: " + this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtNumEmpleado.Text = "N Empleado: " + this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtCurp.Text = "Curp:     " + this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtSsn.Text = "SSN:  " + this.dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtTelefono.Text = "Telefono:  " + this.dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("hola");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtId.Text = "Id:          "+this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtNombre.Text = "Nombre: "+this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtApellidos.Text ="Apellidos: "+ this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtFecha.Text = "Fecha Nacimiento: "+this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtNumEmpleado.Text ="N Empleado: "+ this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtCurp.Text ="Curp:     "+this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtSsn.Text = "SSN:  "+this.dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtTelefono.Text = "Telefono:  "+this.dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = "¿Confirma eliminar el empleado seleccionado?";
            string title = "Eliminar Empleado";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Peticiones servicio = new Peticiones();
                servicio.DeleteBeneficiario(Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value));

                int res = servicio.DeleteEmpleado(Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value));


                var a = servicio.catalogoEmepleados();
                DataTable table = JsonConvert.DeserializeObject<DataTable>(a);
                dataGridView1.DataSource = table;
            }
            else
            {
                // Do something  
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Peticiones servicio = new Peticiones();
            agregaEmpleado agregar = new agregaEmpleado();
            agregar.ShowDialog();
;

            var a = servicio.catalogoEmepleados();
            DataTable table = JsonConvert.DeserializeObject<DataTable>(a);
            dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Peticiones servicio = new Peticiones();
            modificarEmpleado modficar = new modificarEmpleado(Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value));
            modficar.ShowDialog();
            ;

            var a = servicio.catalogoEmepleados();
            DataTable table = JsonConvert.DeserializeObject<DataTable>(a);
            dataGridView1.DataSource = table;
        }
    }
}
