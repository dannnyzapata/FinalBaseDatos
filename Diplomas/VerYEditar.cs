using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Diplomas
{
    public partial class VerYEditar : Form
    {
        int Folio;
        string Curso;
        public VerYEditar(int i, string curs)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Conexion con = new Conexion();
            this.Show();
            Folio = i;
            Curso = curs;
            txtCorreo.Text = con.ObtenerCorreo(i,curs);
            lbFecha.Text = con.ObtenerFechaInicio(i, Curso);
            lbCurso.Text = curs;
            txtNombre.Text = con.NombreBus(i,curs);
            txtApellido1.Text = con.Apellido1Bus(i, curs);
            txtApellido2.Text = con.Apellido2Bus(i, curs);
            con.VerImagen(pcbFoto,curs,i);

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btCambiar_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.conectar();
            if (txtApellido1.Text.Length > 0 && txtApellido2.Text.Length > 0 && txtNombre.Text.Length > 0 && txtCorreo.Text.Length > 0)
            {
                if (txtCorreo.Text.Contains("@"))
                {
                    con.ejecutaTransaccion("UPDATE " + Curso +
                                           " SET Nombre = '" + txtNombre.Text +
                                           "', Apellido1 = '" + txtApellido1.Text +
                                           "', Apellido2 = '" + txtApellido2.Text +
                                           "', Correo = '" + txtCorreo.Text +
                                           "' WHERE Folio = " + Folio);
                    MessageBox.Show("Alumno actualizado");
                }
                else
                {
                    MessageBox.Show("Por favor introdusca un correo valido");
                }
            }
            else
            {
                MessageBox.Show("Por favor no deje datos en blanco");
            }
            con.desconectar();

        }
    }
}
