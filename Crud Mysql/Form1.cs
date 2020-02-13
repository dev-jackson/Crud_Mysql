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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Manejo_Datos md=new Manejo_Datos();
			dgwDatos.DataSource = md.Listar();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			long id = Convert.ToInt64(dgwDatos.Rows[dgwDatos.CurrentRow.Index].Cells[0].Value);
			Datos_Persona dp = new Datos_Persona();
			dp.txtCI.Text = Convert.ToString(id);
			dp.Show();
			this.Hide();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Datos_Persona dp = new Datos_Persona();
			dp.Show();
			this.Hide();
		}
	}
}
