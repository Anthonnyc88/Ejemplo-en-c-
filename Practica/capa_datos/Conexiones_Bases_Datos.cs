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
            cmd = new NpgsqlCommand("INSERT INTO usuario (contraseña, usuario, ) VALUES ('" + contraseña + "', '" + usuario +  "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //Esta funcion modifica la contraseña guardada en la tabla de la bases de datos
        public void ModificarContraseñaUsuario(int contraseña, string usuario)
        {
            Conectando_Base_Datos();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE usuario SET usuario = '" + usuario  + "' WHERE contraseña = '" + contraseña + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }



        //Este metodo inserta productos hacia la base de datos
        public void InsertarDatosProducto(int codigo, string nombre, int cantidad , string proveedor , string fecha_registro)
        {
            Conectando_Base_Datos();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO producto (codigo, nombre, cantidad, proveedor , fecha_registro ) VALUES ('" + codigo + "', '" + nombre + "', '" + cantidad + "', '" + proveedor + "', '" + fecha_registro + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        //Este metodo modifica la tabla productos dentro de la base de datos
        public void ModificarDatosProductos(int codigo, string nombre, int cantidad, string proveedor , string fecha_registro)
        {
            Conectando_Base_Datos();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE producto SET nombre = '" + nombre + "', cantidad = '" + cantidad + "', proveedor = '" + proveedor + "', fecha_registro = '" + fecha_registro + "' WHERE codigo = '" + codigo + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //Este metodo elimina un dato dentro de la base de datos 
        public void EliminarDatosProductos(int codigo)
        {
            Conectando_Base_Datos();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM producto WHERE codigo = '" + codigo + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //Este metodo inserta datos de las ventas diarias en la base de datos
        public void InsertarVentasDiarias(int codigo_venta, string fecha_venta, int ganancia_dia, string nombre_ruta)
        {
            Conectando_Base_Datos();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO ventas (codigo_venta, fecha_venta, ganancia_dia, nombre_ruta ) VALUES ('" + codigo_venta + "', '" + fecha_venta + "', '" + ganancia_dia + "', '" + nombre_ruta + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //Este metodo modifica datos de ventas diarias dentro de la base de datos
        public void ModificarDatosVentasDiarias(int codigo_venta, string fecha_venta, int ganancia_dia, string nombre_ruta)
        {
            Conectando_Base_Datos();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE ventas SET fecha_venta = '" + fecha_venta + "', ganancia_dia = '" + ganancia_dia + "', nombre_ruta = '" + nombre_ruta + "' WHERE codigo_venta = '" + codigo_venta + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }


        //Este metodo elimina datos de ventas diarias dentro de la base de datos
        public void EliminarDatosVentasDiarias(int codigo_venta)
        {
            Conectando_Base_Datos();
            conexion.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM venta WHERE codigo_venta = '" + codigo_venta + "'", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }



    }



}


