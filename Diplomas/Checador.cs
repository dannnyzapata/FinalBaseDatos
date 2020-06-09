using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;



namespace Diplomas
{


    public partial class Checador : Form
    {
        Conexion con = new Conexion();
        int conv;
       
        
        
        public Checador(string curso)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.Show();
            InitializeComponent();
            dtpExpedicion.Value = System.DateTime.Now;
            dtpGraduar.Value = System.DateTime.Now;
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "Enviar";
            checkColumn.HeaderText = "Enviar";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            dgvAlumnos.Columns.Add(checkColumn);
            con.conectar();
            dgvAlumnos.DataSource = con.ejecutarQuery("SELECT Folio, CONCAT(Nombre, ' ', Apellido1, ' ', Apellido2) AS Nombre FROM " + curso + " WHERE Graduado = 'False'");
            con.desconectar();                 
        }

        

        private void btDiplomas_Click(object sender, EventArgs e)
        {
            string expedir;
            string graduado;
            string horas;
            string cursos = Menus.SetValueParaChecado;
            string tipo = textBox1.Text;
            expedir = dtpExpedicion.Value.Day.ToString() + " de " + dtpExpedicion.Value.ToString("MMMM") + " del " + dtpExpedicion.Value.Year.ToString();
            graduado = dtpGraduar.Value.Day.ToString() + " de " + dtpGraduar.Value.ToString("MMMM") + " del " + dtpGraduar.Value.Year.ToString();
            horas = spHoras.Value.ToString();

            foreach (DataGridViewRow check in dgvAlumnos.Rows)
            {
                if (Convert.ToBoolean(check.Cells[0].Value))
                {
                    conv = Int32.Parse(check.Cells[1].Value.ToString());
                    switch (cursos)
                    {
                        case "Basico":
                            Diplomad pDiploma = new Diplomad(conv, graduado, expedir, horas, cursos, tipo);
                            break;
                        case "IntermedioI":
                            IntermedioI pIntermedioI = new IntermedioI(conv, graduado, expedir, horas, cursos, tipo);
                            break;
                        case "IntermedioII":
                            IntermedioII pIntermedioII = new IntermedioII(conv, graduado, expedir, horas, cursos, tipo);
                            break;
                        case "IntermedioIII":
                            IntermedioIII pIntermedioIII = new IntermedioIII(conv, graduado, expedir, horas, cursos, tipo);
                            break;
                        case "IntermedioIV":
                            IntermedioIV pIntermedioIV = new IntermedioIV(conv, graduado, expedir, horas, cursos, tipo);
                            break;
                    }

                }
            }
            this.Close();

        }


        private void Checador_Load(object sender, EventArgs e)
        {                    
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
