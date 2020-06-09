using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplomas
{

    public partial class Menus : Form
    {
        public static string SetValueParaChecado;
        public Menus()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            cbCursos.SelectedIndex = 0;
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {

            Datos Data = new Datos(cbCursos.SelectedItem.ToString());
        }

        private void cbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbCursos.SelectedIndex)
            {
                case 0:
                    btIngresar.Enabled = true;
                    btSubir.Enabled = false;
                    btDatosSuperior.Enabled = false;
                    break;

                case 1:
                    btIngresar.Enabled = false;
                    btSubir.Enabled = true;
                    btDatosSuperior.Enabled = true;
                    break;

                case 2:
                    btIngresar.Enabled = false;
                    btSubir.Enabled = true;
                    btDatosSuperior.Enabled = true;
                    break;
                case 3:
                    btIngresar.Enabled = false;
                    btSubir.Enabled = true;
                    btDatosSuperior.Enabled = true;
                    break;
                case 4:
                    btIngresar.Enabled = false;
                    btSubir.Enabled = true;
                    btDatosSuperior.Enabled = true;
                    break;
            }            
        }

        private void btVerAlu_Click(object sender, EventArgs e)
        {
            VisorAlumnos vAlumnos = new VisorAlumnos(cbCursos.SelectedItem.ToString());
        }

        private void btDiplomas_Click(object sender, EventArgs e)
        {
            string check = cbCursos.SelectedItem.ToString();
            SetValueParaChecado = check;
            
            Checador vChecar = new Checador(cbCursos.SelectedItem.ToString());
        }

        private void btSubir_Click(object sender, EventArgs e)
        {
            string upgrade = "lol";
            switch (cbCursos.SelectedItem.ToString())
            {
                case "IntermedioI":
                    upgrade = "Basico";
                    break;
                case "IntermedioII":
                    upgrade = "IntermedioI";
                    break;
                case "IntermedioIII":
                    upgrade = "IntermedioII";
                    break;
                case "IntermedioIV":
                    upgrade = "IntermedioIII";
                    break;

            }
            Subir Up = new Subir(cbCursos.SelectedItem.ToString(), upgrade);
            
        }

        private void btDatosSuperior_Click(object sender, EventArgs e)
        {
            Cursos_Nuevos Cursar = new Cursos_Nuevos(cbCursos.SelectedItem.ToString());
        }
    }
}
