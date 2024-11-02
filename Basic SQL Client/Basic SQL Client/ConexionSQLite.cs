using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using NETCore.Encrypt;

//Requiere del paquete NuGet: Microsoft.Data.Sqlite
namespace Basic_SQL_Client
{
    public class ConexionSQLite
    {
       private const string archivoBD = "config.bd";
        public  List<Dictionary<string, string>> conexiones =  new List<Dictionary<string, string>>();

        public ConexionSQLite()
        {
            if (!File.Exists(archivoBD))
            {
                SqliteConnection conexion = new SqliteConnection("Data Source=" + archivoBD);
                conexion.Open();
                string tabla = @" CREATE TABLE conexion (
                    nombre TEXT PRIMARY KEY,
                    usuario TEXT NOT NULL,
                    pass TEXT NOT NULL,
                    servidor TEXT NOT NULL,
                    nombreBD TEXT)";
                SqliteCommand comando = new SqliteCommand(tabla, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
        }

        public void guardar(string nombre,string usuario,string pass,string servidor="localhost",string nombreBD=null)
        {
            SqliteConnection conexion = new SqliteConnection("Data Source=" + archivoBD);
            conexion.Open();
            string sql = @"insert into conexion values(@nombre,@usuario,@pass,@servidor,@nombreBD)";
            
            SqliteCommand comando = new SqliteCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@pass", pass);
            comando.Parameters.AddWithValue("@servidor", servidor);
            comando.Parameters.AddWithValue("@nombreBD", nombreBD);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void borrar(string nombre)
        {
            SqliteConnection conexion = new SqliteConnection("Data Source=" + archivoBD);
            conexion.Open();
            string sql = @"delete from conexion where nombre=@nombre";
            SqliteCommand comando = new SqliteCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void actualizar(string nombre,string nuevoNombre, string nuevoUsuario, string nuevoPass, string nuevoServidor = "localhost", string nuevoNombreBD = null)
        {
            SqliteConnection conexion = new SqliteConnection("Data Source=" + archivoBD);
            conexion.Open();
            string sql = @"update conexion set nombre=@nuevoNombre,usuario=@usuario,pass=@pass,servidor=@servidor,nombreBD=@nombreBD where nombre=@nombre";

            SqliteCommand comando = new SqliteCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);
            comando.Parameters.AddWithValue("@usuario", nuevoUsuario);
            comando.Parameters.AddWithValue("@pass", nuevoPass);
            comando.Parameters.AddWithValue("@servidor", nuevoServidor);
            comando.Parameters.AddWithValue("@nombreBD", nuevoNombreBD);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void cargarConexiones(ComboBox combo)
        {
            SqliteConnection conexion = new SqliteConnection("Data Source=" + archivoBD);
            conexion.Open();
            string sql = @"select * from conexion";

            SqliteCommand comando = new SqliteCommand(sql, conexion);
            
            SqliteDataReader datos = comando.ExecuteReader();
            combo.Items.Clear();
            conexiones.Clear();

            while (datos.Read())
            {
                combo.Items.Add(datos.GetString("nombre"));
                
                Dictionary<string, string> con = new Dictionary<string, string>();
                con.Add("nombre", datos.GetString("nombre"));
                con.Add("usuario", datos.GetString("usuario"));
                con.Add("pass", datos.GetString("pass"));
                con.Add("servidor", datos.GetString("servidor"));
                con.Add("nombreBD", datos.GetString("nombreBD"));

                conexiones.Add(con);
            }

            conexion.Close();
        }



    }
}
