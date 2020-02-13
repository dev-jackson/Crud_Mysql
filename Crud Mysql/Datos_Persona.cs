using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Mysql
{
	public partial class Datos_Persona : Form
	{
		public Datos_Persona()
		{
			InitializeComponent();
		}

		private void Datos_Persona_Load(object sender, EventArgs e)
		{
			if (txtCI.Text.ToString()=="")
			{
				btnRegistrar.Visible = true;
				btnActualizar.Visible = false;
			}
			else
			{
				llenarTextBox(txtCI.Text);
				btnRegistrar.Visible = false;
				btnActualizar.Visible = true;
			}
		}
		public void llenarTextBox(string id)
		{
			Manejo_Datos md = new Manejo_Datos();
			Persona p=md.ObtenerPersona(id);
			txtNombre.Text = p.Nombre;
			txtApellido.Text = p.Apellido;
			txtEdad.Text = Convert.ToString(p.Edad);
			if (p.Genero == "Masculino")
			{
				cmbGenero.SelectedIndex = 0;
			}
			else
			{
				cmbGenero.SelectedIndex = 1;
			}
			if (p.Estado_Civil == "Soltero")
			{
				rdEstadoS.Checked=true;
			}
			else
			{
				rdEstadoC.Checked = true;
			}
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			Manejo_Datos md = new Manejo_Datos();
			string estado;
			if (rdEstadoS.Checked)
			{
				estado=rdEstadoS.Text;
			}
			else
			{
				estado = rdEstadoC.Text;
			}
			bool ban=md.Agregar_Persona(new Persona(
					Convert.ToInt64(txtCI.Text),
					Convert.ToString(txtNombre.Text),
					Convert.ToString(txtApellido.Text),
					Convert.ToInt32(txtEdad.Text),
					Convert.ToString(cmbGenero.SelectedItem.ToString()),	
					Convert.ToString(estado)
				));
			if (ban)
			{
				MessageBox.Show("Registro Con Exito!");
				Form1 f = new Form1();
				f.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Ups algo paso");
			}
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult result= MessageBox.Show("Seguro que quiere salir", "Info", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				Form1 f = new Form1();
				f.Show();
				this.Close();
			}
		}
	}
}
