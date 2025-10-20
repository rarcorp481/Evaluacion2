using Evaluacion2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluacion2.DAO;
using Evaluacion2.Model;


namespace Evaluacion2
{
    public partial class Form1 : Form
    {
        PilaEmpleados pila = new PilaEmpleados();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleado eliminado = pila.Eliminar();
            if (eliminado != null)
            {
                lblAdvertencia.Text = $"Eliminado: {eliminado.NombreCompleto()}";
            }
            else
            {
                lblAdvertencia.Text = "La pila está vacía.";
            }
            ActualizarListBox();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text) ||
        string.IsNullOrWhiteSpace(tbApellido.Text) ||
        string.IsNullOrWhiteSpace(tbCargo.Text) ||
        string.IsNullOrWhiteSpace(tbSalario.Text))
            {
                lblAdvertencia.Text = "Todos los campos son obligatorios.";
                return;
            }

            if (!decimal.TryParse(tbSalario.Text, out decimal salario))
            {
                lblAdvertencia.Text = "El salario debe ser un número válido.";
                return;
            }

            Empleado nuevo = new Empleado(tbNombre.Text, tbApellido.Text, tbCargo.Text, salario);
            pila.Agregar(nuevo);
            ActualizarListBox();
            lblAdvertencia.Text = "Empleado agregado correctamente.";

        }
        private void ActualizarListBox()
        {
            Contenido.Items.Clear();
            foreach (var item in pila.ObtenerContenido())
            {
                Contenido.Items.Add(item);
            }
        }
        private void Datos_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVerTope_Click(object sender, EventArgs e)
        {
            Empleado tope = pila.VerTope();
            lblAdvertencia.Text = tope != null ? $"Tope: {tope.NombreCompleto()}" : "La pila está vacía.";

        }

        private void lblDatos_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblAdvertencia_Click(object sender, EventArgs e)
        {

        }
    }
}
