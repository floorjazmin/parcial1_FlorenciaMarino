using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial1
{
    public partial class Form1 : Form
    {
        //Creo la lista alumnos
        private List<Alumnos> Alumn = new List<Alumnos>();
        public Form1()
        {
            InitializeComponent();
        }
        private void botGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDato())
            {
                Alumn.Add(new Alumnos(txtNombre.Text, txtApellido.Text, int.Parse(txtDNI.Text), int.Parse(txtLegajo.Text), txtCarrera.Text, int.Parse(txtAñoInscripcion.Text), int.Parse(txtAñoNacimiento.Text), txtMailContacto.Text));
                MessageBox.Show("El/La Alumno/a se ha registrado correctamente");
                lblDatos.Text = "Usted ha ingresado : " + (Alumn.Count) + " Alumno";
                int datos = dgvDatos.Rows.Add();
                dgvDatos.Rows[datos].Cells[0].Value = txtNombre.Text;
                dgvDatos.Rows[datos].Cells[1].Value = txtApellido.Text;
                dgvDatos.Rows[datos].Cells[2].Value = txtDNI.Text;
                dgvDatos.Rows[datos].Cells[3].Value = txtAñoNacimiento.Text;
                dgvDatos.Rows[datos].Cells[4].Value = txtMailContacto.Text;
                dgvDatos.Rows[datos].Cells[5].Value = txtLegajo.Text;
                dgvDatos.Rows[datos].Cells[6].Value = txtCarrera.Text;
                dgvDatos.Rows[datos].Cells[7].Value = txtAñoInscripcion.Text;

                txtNombre.Clear();
                txtDNI.Clear();
                txtApellido.Clear();
                txtAñoInscripcion.Clear();
                txtCarrera.Clear();
                txtLegajo.Clear();
                txtAñoNacimiento.Clear();
                txtMailContacto.Clear();
            }
            else
            {
                MessageBox.Show("Intente nuevamente");
            }
        }

        private void BotEliminar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDNI.Clear();
            txtApellido.Clear();
            txtAñoInscripcion.Clear();
            txtCarrera.Clear();
            txtLegajo.Clear();
            txtAñoNacimiento.Clear();
            txtMailContacto.Clear();
        }

        private void botSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool ValidarDato()
        {
            //valida los campos ingresados por el usuario
            bool datoValido;
            datoValido = true;

            if (txtNombre.Text.Trim() == "")
            {

                MessageBox.Show("El nombre está vacío");
                datoValido = false;
                txtNombre.Focus();

            }

            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("El Apellido está vacío");
                txtApellido.Focus();
                datoValido = false;
            }

            try
            {
                Int32.Parse(txtDNI.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El dato DNI es incorrecto o esta vacio");
                datoValido = false;
            }
            try
            {
                int.Parse(txtLegajo.Text);


            }
            catch (Exception ex1)
            {
                MessageBox.Show("El dato Legajo es incorrecto o esta vacio");
                datoValido = false;
            }
            if (txtCarrera.Text.Trim() == "")
            {
                MessageBox.Show("La carrera está vacía");
                txtCarrera.Focus();
                datoValido = false;
            }
            try
            {
                int.Parse(txtAñoInscripcion.Text);

            }
            catch (Exception ex2)
            {
                MessageBox.Show("El año de inscripcion es incorrecto,debe ingresar 4 numeros o posiblemente el dato esta vacio");
                datoValido = false;
            }
            try
            {
                int.Parse(txtAñoNacimiento.Text);
                if (Int32.Parse(txtAñoNacimiento.Text) > 2002) {
                    MessageBox.Show("Usted debe ser mayor de 18 años para poder inscribirse");
                }

            }
            catch (Exception ex3)
            {
                MessageBox.Show("El año de nacimiento esta incorrecto,debe ingresar 4 numeros o posiblemente el dato esta vacio");
                datoValido = false;
            } 
            if (txtMailContacto.Text.Trim() == "")
            {

                MessageBox.Show("El Email está vacío");
                datoValido = false;
                txtMailContacto.Focus();

            }

            return datoValido;
        
        }

       
        
    }
}
