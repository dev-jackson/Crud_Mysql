using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Crud_Mysql
{
	class Connection
	{
		public static MySqlConnection obtenerConnection()
		{
			MySqlConnection conexion = new MySqlConnection("server=localhost;database=ayudantia;Uid=root;pwd=;");
			conexion.Open();
			return conexion;


		}
	}	
}
