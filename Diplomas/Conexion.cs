using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.IO;

namespace Diplomas
{
    public class Conexion
    {
        static string nombserv = Dns.GetHostName();
        static string cadenaConexion = "Data Source= " + nombserv + "\\SQLEXPRESS;Initial Catalog=AlumnosDB;Integrated Security=True";
        SqlConnection conn = new SqlConnection(cadenaConexion);
        public void conectar()
        {
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void desconectar()
        {
            conn.Close();
        }
        public DataTable ejecutarQuery(string consulta)
        {
            DataTable resultado = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
            adaptador.Fill(resultado);
            return resultado;
        }
        public bool ejecutaTransaccion(string consulta)
        {
            bool bien = true;
            try
            {
                SqlCommand comando = new SqlCommand(consulta, conn);
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                bien = false;
                MessageBox.Show(ex.Message);
            }
            return bien;
        }




        public string AlumnoNombre(int i, string Curso)
        {
            string stmt = "select * FROM "+ Curso +" WHERE Folio= " + i;
            string count = "1";
            SqlCommand comando = new SqlCommand(stmt, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                count = registro["Nombre"].ToString() + " " + registro["Apellido1"].ToString() + " " + registro["Apellido2"].ToString();
            }

            conn.Close();
            return count;

        }


        public string AlumnoFolio(int i, string Curso)
        {
            string stmt = "select * FROM "+ Curso +" WHERE Folio= " + i;
            string count = "1";
            SqlCommand comando = new SqlCommand(stmt, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                count = registro["Folio"].ToString();
            }

            conn.Close();
            return count;



        }

        public string ObtenerFechaInicio(int i, string Curso)
        {
            string getFecha = "SELECT * FROM " + Curso + " WHERE Folio = " + i;
            string FechaInicio = " ";
            string resultado = " ";
            SqlCommand comando = new SqlCommand(getFecha, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                FechaInicio = registro["Fecha"].ToString();
            }
            DateTimePicker FechaAString = new DateTimePicker();
            FechaAString.Value = Convert.ToDateTime(FechaInicio);
            resultado = FechaAString.Value.Day.ToString() + " de " + FechaAString.Value.ToString("MMMM") + " del " + FechaAString.Value.Year.ToString();

            conn.Close();
            return resultado;

        }



        public string ObtenerCorreo(int i, string Curso)
        {
            string correo = "SELECT * FROM "+ Curso + " WHERE Folio = " + i;
            string enviar = " ";
            SqlCommand comando = new SqlCommand(correo, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                enviar = registro["Correo"].ToString();
            }

            conn.Close();
            return enviar;
            
        }

        public string ObtenerUsuario()
        {
            string correo = "SELECT Usuario FROM Correo";
            string enviar = " ";
            SqlCommand comando = new SqlCommand(correo, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                enviar = registro["Usuario"].ToString();
            }

            conn.Close();
            return enviar;

        }


        public string ObtenerContraseña()
        {
            string correo = "SELECT Contraseña FROM Correo";
            string enviar = " ";
            SqlCommand comando = new SqlCommand(correo, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                enviar = registro["Contraseña"].ToString();
            }

            conn.Close();
            return enviar;
        }
        public string NombreBus(int i, string Curso)
        {
            string stmt = "select * FROM " + Curso + " WHERE Folio= " + i;
            string count = " ";
            SqlCommand comando = new SqlCommand(stmt, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                count = registro["Nombre"].ToString();
            }

            conn.Close();
            return count;

        }


        public string Apellido1Bus(int i, string Curso)
        {
            string stmt = "select * FROM " + Curso + " WHERE Folio= " + i;
            string count = " ";
            SqlCommand comando = new SqlCommand(stmt, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                count = registro["Apellido1"].ToString();
            }

            conn.Close();
            return count;

        }


        public string Apellido2Bus(int i, string Curso)
        {
            string stmt = "select * FROM " + Curso + " WHERE Folio= " + i;
            string count = " ";
            SqlCommand comando = new SqlCommand(stmt, conn);
            conn.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                count = registro["Apellido2"].ToString();
            }

            conn.Close();
            return count;

        }

   
     

        public string InsertarDatos(string curso, PictureBox Foto, string correo, string nombre, string apellido1, string apellido2, string fecha, int profid)
        {
            
            string mensaje = "Todo bien";
            try
            {
                           
                SqlCommand comando = new SqlCommand("insert into " + curso + "(Nombre, Apellido1, Apellido2, Correo, Fecha, Graduado, Upgrade, Foto) values ('" +
                        nombre + "','"
                        + apellido1 + "','"
                        + apellido2 + "','"
                         + correo + "','"
                        + fecha + "', 'FALSE','FALSE', @Imagen, '" + profid +"');", conn);
                
                conn.Open();
                comando.Parameters.Add("@Imagen", SqlDbType.Image);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                Foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                comando.Parameters["@Imagen"].Value = ms.GetBuffer();
                comando.ExecuteNonQuery();
                conn.Close();              
            }
            catch 
            {
                MessageBox.Show("No se guardo la imagen");
            }
            
            return mensaje;

        }

        public string InsertarDatosAvanzados(int Folio, string curso, PictureBox Foto, string correo, string nombre, string apellido1, string apellido2, string fecha, int profid)
        {

            string mensaje = "Todo bien";
            try
            {

                SqlCommand comando = new SqlCommand("insert into " + curso + "(Folio,Nombre, Apellido1, Apellido2, Correo, Fecha, Graduado, Upgrade, Foto) values ('" + Folio + "','" +
                        nombre + "','"
                        + apellido1 + "','"
                        + apellido2 + "','"
                         + correo + "','"
                        + fecha + "', 'FALSE','FALSE', @Imagen, '" + profid + "');", conn);

                conn.Open();
                comando.Parameters.Add("@Imagen", SqlDbType.Image);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                Foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                comando.Parameters["@Imagen"].Value = ms.GetBuffer();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("No se guardo la imagen");
            }

            return mensaje;

        }

        public string SubirCurso(string curso, PictureBox Foto, string folio, string correo, string nombre, string apellido1, string apellido2, string fecha, int profid)
        {

            string mensaje = "Todo bien";
            try
            {

                SqlCommand comando = new SqlCommand("insert into " + curso + "(Folio,Nombre, Apellido1, Apellido2, Correo, Fecha, Graduado, Upgrade, Foto, IdProf) values ('" + folio + "','" +
                        nombre + "','"
                        + apellido1 + "','"
                        + apellido2 + "','"
                         + correo + "','"
                        + fecha + "', 'FALSE', 'FALSE', @Imagen, '"+ profid + "');", conn);

                conn.Open();
                comando.Parameters.Add("@Imagen", SqlDbType.Image);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                Foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                comando.Parameters["@Imagen"].Value = ms.GetBuffer();
                comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return mensaje;

        }

        public void VerImagen(PictureBox Foto, string curso, int i)
        {
           
            try
            {
                DataRow dr;
                string request = "SELECT Foto FROM " + curso + " WHERE Folio = " + i;
                SqlDataAdapter ver = new SqlDataAdapter(request, conn);
                DataSet ds = new DataSet();
                ver.Fill(ds, curso);
                byte[] datos = new byte[0];
                dr = ds.Tables[curso].Rows[0];
                datos = (byte[])dr["Foto"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                Foto.Image = System.Drawing.Bitmap.FromStream(ms);

            }
            catch 
            {
                MessageBox.Show("No se pudo cargar la imagen del alumno");
                Foto.Image = null;
            }


        }

    }
}
