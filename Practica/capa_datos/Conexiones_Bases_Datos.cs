using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace capa_datos
{
    public class Conexiones_Bases_Datos
    {

        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;

        public static void Conectando_Base_Datos()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            string clave = "1414250816ma";
            string baseDatos = "sistema_ventas";

            string cadenaConexion = "Server=" + servidor + ";" + "Port=" + puerto + ";" + "User Id=" + usuario + ";" + "Password=" + clave + ";" + "Database=" + baseDatos;
            conexion = new NpgsqlConnection(cadenaConexion);
        }


        //Esta funcion inserta datos en la tabla usuarios 
        public void InsertarDatosUsuario(int contraseña, string usuario)
        {
            Conectando_Base_Datos();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO usuario (contraseña, usuario, edad, comentario) VALUES ('" + contraseña + "', '" + usuario +  "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }







    }
}
