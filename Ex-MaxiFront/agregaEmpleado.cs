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
    public partial class agregaEmpleado : Form
    {
        public agregaEmpleado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void agregaEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int porcentaje1 = 0;
            int porcentaje2 = 0;
             porcentaje1 = Convert.ToInt32(textBox8.Text.Trim());
            if (textBox15.Text != "")
            {
                 porcentaje2 = Convert.ToInt32(textBox15.Text.Trim());
            }
            if (textBox1.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            else if (textBox2.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            else if (textBox4.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            else if (textBox5.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            else if (textBox6.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            else if (textBox7.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            else if (textBox8.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            else if (textBox9.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            else if (textBox10.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            else if (textBox11.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            else if (textBox13.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            else if (textBox14.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            //else if (textBox15.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            //else if (textBox16.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            //else if (textBox17.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            //else if (textBox18.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            //else if (textBox20.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            //else if (textBox21.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            else if (textBox3.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            else if (textBox12.Text == "") MessageBox.Show("Por favor ingrese todos los campos");
            else if(porcentaje1+porcentaje2  == 100 )
            {
                Modelos.Empleados emp = new Modelos.Empleados();
                List<Modelos.Empleados> lis = new List<Modelos.Empleados>();
                emp.Nombre = textBox1.Text;
                emp.Apellidos = textBox2.Text;
                emp.fNacimiento = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                emp.nEmpleado = Convert.ToInt32(textBox7.Text);
                emp.Curp = textBox4.Text;
                emp.Ssn = textBox5.Text;
                emp.Telefono = Convert.ToInt32(textBox6.Text);
                emp.Nacionalidad = textBox3.Text;

                lis.Add(emp);

                Peticiones servicio = new Peticiones();
                servicio.AgregarEmpleado(lis);
                var a = servicio.catalogoEmepleados();
                DataTable table = JsonConvert.DeserializeObject<DataTable>(a);
                List<DataRow> drlist = new List<DataRow>();

                foreach (DataRow row in table.Rows)
                {
                    drlist.Add((DataRow)row);
                }
                int listado = drlist.Count();
                string idEmpleado = table.Rows[listado-1]["id"].ToString();

                Modelos.Beneficiarios ben = new Modelos.Beneficiarios();
                List<Modelos.Beneficiarios> lisben = new List<Modelos.Beneficiarios>();
                ben.Nombre = textBox14.Text;
                ben.Apellidos = textBox13.Text;
                ben.fNacimiento = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                ben.Curp = textBox11.Text;
                ben.Ssn = textBox10.Text;
                ben.Telefono = Convert.ToInt32(textBox9.Text);
                ben.Nacionalidad = textBox12.Text;
                ben.idEmpleado = Convert.ToInt32(idEmpleado);
                ben.Porcentaje = Convert.ToInt32(textBox8.Text);

                lisben.Add(ben);

                //Peticiones servicio1 = new Peticiones();
                servicio.AgregarBeneficiario(lisben);

                if(textBox15.Text!=""&& textBox16.Text != "" && textBox17.Text != "" && textBox18.Text != "" && textBox19.Text != "" &&
                    textBox20.Text != "" && textBox21.Text != "")
                {
                    Modelos.Beneficiarios ben2 = new Modelos.Beneficiarios();
                    List<Modelos.Beneficiarios> lisben2 = new List<Modelos.Beneficiarios>();
                    ben2.Nombre = textBox21.Text;
                    ben2.Apellidos = textBox20.Text;
                    ben2.fNacimiento = dateTimePicker3.Value.ToString("yyyy-MM-dd");
                    ben2.Curp = textBox18.Text;
                    ben2.Ssn = textBox17.Text;
                    ben2.Telefono = Convert.ToInt32(textBox16.Text);
                    ben2.Nacionalidad = textBox19.Text;
                    ben2.idEmpleado = Convert.ToInt32(idEmpleado);
                    ben2.Porcentaje = Convert.ToInt32(textBox15.Text);

                    lisben2.Add(ben2);

                    //Peticiones servicio1 = new Peticiones();
                    servicio.AgregarBeneficiario(lisben2);
                }

                MessageBox.Show("Empleado Guardado Correctamente");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";
                textBox16.Text = "";
                textBox17.Text = "";
                textBox18.Text = "";
                textBox19.Text = "";
                textBox20.Text = "";
                textBox21.Text = "";


                //Console.WriteLine(drlist[listado - 1].Table.Rows[listado - 1]);
                //List<> ae = JsonConvert.DeserializeObject<DataTable>(a);
            }
            else
            {
                MessageBox.Show("El porcentaje de los beneficiarios debe sumar 100");

            }

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
