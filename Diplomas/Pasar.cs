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
    public partial class Pasar : Form
    {
        int Folio;
        string Curso;
        string upgrade = "lol";
        int supprofid;
        public Pasar(int i, string curs, string upar, string Cursos, int profid)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Conexion con = new Conexion();
            this.Show();
            Folio = i;
            supprofid = profid;

            Curso = curs;
            
            lbCorreo.Text = con.ObtenerCorreo(i, Cursos);             
            dtNuevoCurso.Value = System.DateTime.Now;
            lbCurso.Text = curs;
            lbFolio.Text = i.ToString();
            lbNombre.Text = con.NombreBus(i, Cursos);
            lbApellido1.Text = con.Apellido1Bus(i, Cursos);
            lbApellido2.Text = con.Apellido2Bus(i, Cursos);
            con.VerImagen(pcbFoto, Cursos, i);

            upgrade = upar;

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btCambiar_Click(object sender, EventArgs e)
        {

            Conexion con = new Conexion();
            con.SubirCurso(Curso, pcbFoto, lbFolio.Text ,lbCorreo.Text, lbNombre.Text, lbApellido1.Text, lbApellido2.Text, dtNuevoCurso.Value.ToString("dd/MM/yyyy"), supprofid);
            MessageBox.Show("Alumno correctamente en nuevo curso");
            con.conectar();
            con.ejecutaTransaccion("UPDATE " + upgrade + " SET Upgrade = 'TRUE' WHERE Folio = " + Folio);
            con.desconectar();
            this.Close();
        }
    }
}
