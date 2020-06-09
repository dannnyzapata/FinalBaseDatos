namespace Diplomas
{
    partial class Datos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datos));
            this.alumnosDBDataSet = new Diplomas.AlumnosDBDataSet();
            this.registradosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registradosTableAdapter = new Diplomas.AlumnosDBDataSetTableAdapters.RegistradosTableAdapter();
            this.btActualizar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.btPic = new System.Windows.Forms.Button();
            this.AbrirFile = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.lbcurso = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registradosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // alumnosDBDataSet
            // 
            this.alumnosDBDataSet.DataSetName = "AlumnosDBDataSet";
            this.alumnosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registradosBindingSource
            // 
            this.registradosBindingSource.DataMember = "Registrados";
            this.registradosBindingSource.DataSource = this.alumnosDBDataSet;
            // 
            // registradosTableAdapter
            // 
            this.registradosTableAdapter.ClearBeforeFill = true;
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(93, 581);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(75, 23);
            this.btActualizar.TabIndex = 1;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(130, 81);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(201, 20);
            this.txtApellido1.TabIndex = 3;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(130, 122);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(201, 20);
            this.txtApellido2.TabIndex = 4;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(130, 159);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(201, 20);
            this.txtCorreo.TabIndex = 5;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(130, 199);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(201, 20);
            this.dtpFecha.TabIndex = 6;
            this.dtpFecha.Value = new System.DateTime(2020, 2, 24, 22, 33, 6, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Primer Apellido: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Segundo Apellido: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha de Ingreso:";
            // 
            // pcbFoto
            // 
            this.pcbFoto.Location = new System.Drawing.Point(79, 330);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(233, 214);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 13;
            this.pcbFoto.TabStop = false;
            // 
            // btPic
            // 
            this.btPic.Location = new System.Drawing.Point(130, 239);
            this.btPic.Name = "btPic";
            this.btPic.Size = new System.Drawing.Size(155, 23);
            this.btPic.TabIndex = 14;
            this.btPic.Text = "Foto de Alumno";
            this.btPic.UseVisualStyleBackColor = true;
            this.btPic.Click += new System.EventHandler(this.btPic_Click);
            // 
            // AbrirFile
            // 
            this.AbrirFile.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Curso:";
            // 
            // lbcurso
            // 
            this.lbcurso.AutoSize = true;
            this.lbcurso.Location = new System.Drawing.Point(131, 293);
            this.lbcurso.Name = "lbcurso";
            this.lbcurso.Size = new System.Drawing.Size(41, 13);
            this.lbcurso.TabIndex = 18;
            this.lbcurso.Text = "Prueba";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(210, 581);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 19;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 677);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.lbcurso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btPic);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btActualizar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Datos";
            this.Text = "Datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registradosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AlumnosDBDataSet alumnosDBDataSet;
        private System.Windows.Forms.BindingSource registradosBindingSource;
        private AlumnosDBDataSetTableAdapters.RegistradosTableAdapter registradosTableAdapter;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Button btPic;
        private System.Windows.Forms.OpenFileDialog AbrirFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbcurso;
        private System.Windows.Forms.Button btCancelar;
    }
}

