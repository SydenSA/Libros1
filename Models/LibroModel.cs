namespace Libros1.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data;
    using Libros1.Config;

    class LibroModel
    {
        public int Libro_id { get; set; }
        public string titulo { get; set; }


        List<LibroModel> Lista_libro = new List<LibroModel>();
        //instancia de base de datos
        private Conexion conexion = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public List<LibroModel> todos()
        {
            string cadena = "select *  from libros";
            SqlDataAdapter adapter = new SqlDataAdapter(cadena, conexion.AbrirConexion());
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            foreach (DataRow libro in tabla.Rows)
            {
                LibroModel nuevolibro = new LibroModel
                {
                    Libro_id = Convert.ToInt32(libro["libro_id"]),
                    titulo = libro["titulo"].ToString()
                };
                Lista_libro.Add(nuevolibro);
            }

            conexion.CerrarConexcion();
            return Lista_libro;
        }
        public LibroModel uno(LibroModel libro)
        { 
            string cadena = "select * from libros where libro_id=" + libro.Libro_id;
            cmd = new SqlCommand(cadena, conexion.AbrirConexion());
            SqlDataReader lector = cmd.ExecuteReader();

            lector.Read();
            LibroModel libroregresa = new LibroModel
            {
                Libro_id = Convert.ToInt32(lector["libro_id"]),
                titulo = lector["titulo"].ToString()
            };
            conexion.CerrarConexcion();
            return libroregresa;
        }
        public string insertar(LibroModel libro)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "insert into libros(titulo) values('" + libro.titulo + "')";
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception ex)
            {
                return "erorr: " + ex.Message;
            }
            finally
            {
                conexion.CerrarConexcion();
            }
        }
        public string actualizar(LibroModel libro)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "update libros set titulo='" + libro.titulo + "' where Libro_id=" + libro.Libro_id;
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception ex)
            {
                return "erorr: " + ex.Message;
            }
            finally
            {
                conexion.CerrarConexcion();
            }
        }
        public string eliminar(LibroModel libro)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "delete from libros where libro_id =" + libro.Libro_id;
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception ex)
            {
                return "erorr: " + ex.Message;
            }
            finally
            {
                conexion.CerrarConexcion();
            }
        }
    }
}
