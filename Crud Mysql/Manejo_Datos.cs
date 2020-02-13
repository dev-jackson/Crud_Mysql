
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Crud_Mysql
{
	class Manejo_Datos
	{
		public Manejo_Datos()
		{

		}
		public bool Agregar_Persona(Persona p)
		{
			string sql = "INSERT INTO persona(id_persona,nombre,apellido,edad," +
				"genero,estado_civil) values(@id_persona,@nombre,@apellido,@edad," +
				"@genero,@estado_civil)";
			try
			{
				MySqlCommand cmd = Connection.obtenerConnection().CreateCommand();
				cmd.CommandText = sql;
				cmd.Parameters.AddWithValue("@id_persona",p.Ci);
				cmd.Parameters.AddWithValue("@nombre",p.Nombre);
				cmd.Parameters.AddWithValue("@apellido",p.Apellido);
				cmd.Parameters.AddWithValue("@edad", p.Edad);
				cmd.Parameters.AddWithValue("@genero",p.Genero);
				cmd.Parameters.AddWithValue("@estado_civil",p.Estado_Civil);
				cmd.ExecuteNonQuery();
				return true;
			}catch(MySqlException e)
			{
				MessageBox.Show(e.Message);
				return false;
			}
		}
		public List<Persona> Listar()
		{
			List<Persona> personas = null;
			string sql = "SELECT * FROM persona";
			try
			{
				MySqlCommand cmd = new MySqlCommand(sql,Connection.obtenerConnection());
				MySqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					personas = new List<Persona>();
					while (reader.Read())
					{
						personas.Add(new Persona(
								reader.GetInt64(0),
								reader.GetString(1),
								reader.GetString(2),
								reader.GetInt32(3),
								reader.GetString(4),
								reader.GetString(5))
							);
					}
				}
			}catch(MySqlException e)
			{
				MessageBox.Show(e.Message);
			}
			finally
			{
				Connection.obtenerConnection().Close();
			}
			return personas;
		}
		public Persona ObtenerPersona(string id)
		{
			Persona persona = null;
			string sql="SELECT *FROM persona WHERE id_persona="+id+"";
			try
			{
				MySqlCommand cmd = new MySqlCommand(sql, Connection.obtenerConnection());
				MySqlDataReader rd = cmd.ExecuteReader();
				if (rd.HasRows)
				{
					persona = new Persona();
					while (rd.Read())
					{
						persona.Ci = rd.GetInt64(0);
						persona.Nombre = rd.GetString(1);
						persona.Apellido = rd.GetString(2);
						persona.Edad = rd.GetInt32(3);
						persona.Genero = rd.GetString(4);
						persona.Estado_Civil = rd.GetString(5);
					}
				}
			}catch(MySqlException e)
			{
				MessageBox.Show(e.Message);
			}
			finally
			{
				Connection.obtenerConnection().Close();
			}
			return persona;
		}
		
	}
}
