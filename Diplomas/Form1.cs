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
    public partial class Datos : Form
    {
        
        
        Conexion con = new Conexion();
        string cursos;
        public Datos(string curso)
        {
            cursos = curso; 
            InitializeComponent();
            dtpFecha.Value = System.DateTime.Now;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbcurso.Text = cursos;

        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            int profid = 1;

            if (txtApellido1.Text.Length>0 && txtApellido2.Text.Length > 0  && txtNombre.Text.Length > 0 && txtCorreo.Text.Length >0 )
            {
                if (txtCorreo.Text.Contains("@"))
                {     
                    if (pcbFoto.Image != null)
                    {                        
                            con.InsertarDatos(lbcurso.Text, pcbFoto, txtCorreo.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, dtpFecha.Value.ToString("dd/MM/yyyy"), profid);
                            txtApellido1.Clear();
                            txtApellido2.Clear();
                            txtCorreo.Clear();
                            txtNombre.Clear();
                            pcbFoto.Image = null;
                            MessageBox.Show("Alumno en base de Datos");
                            
                        }                     
                    }                                                                                       
                
                else
                {
                    MessageBox.Show("Introdusca un correo valido por favor");
                }

            }
            else
            {
                MessageBox.Show("Complete todos los campos por favor");
            }
            


        }


        private void btPic_Click(object sender, EventArgs e)
        {
            try
            {
                this.AbrirFile.ShowDialog();
                pcbFoto.Load(this.AbrirFile.FileName);

            }
            catch
            {
                MessageBox.Show("No se pudo cargar la imagen");
            }
        }



        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtCorreo.Clear();
            txtNombre.Clear();
            pcbFoto.Image = null;
            this.Close();
        }
    }
}
