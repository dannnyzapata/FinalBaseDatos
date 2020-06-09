namespace Diplomas
{
    partial class Menus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menus));
            this.btVerAlu = new System.Windows.Forms.Button();
            this.btDiplomas = new System.Windows.Forms.Button();
            this.btIngresar = new System.Windows.Forms.Button();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btSubir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDatosSuperior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btVerAlu
            // 
            this.btVerAlu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btVerAlu.ForeColor = System.Drawing.Color.Snow;
            this.btVerAlu.Location = new System.Drawing.Point(212, 336);
            this.btVerAlu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btVerAlu.Name = "btVerAlu";
            this.btVerAlu.Size = new System.Drawing.Size(87, 105);
            this.btVerAlu.TabIndex = 19;
            this.btVerAlu.Text = "Ver Alumnos";
            this.btVerAlu.UseVisualStyleBackColor = false;
            this.btVerAlu.Click += new System.EventHandler(this.btVerAlu_Click);
            // 
            // btDiplomas
            // 
            this.btDiplomas.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btDiplomas.ForeColor = System.Drawing.Color.Snow;
            this.btDiplomas.Location = new System.Drawing.Point(125, 462);
            this.btDiplomas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDiplomas.Name = "btDiplomas";
            this.btDiplomas.Size = new System.Drawing.Size(87, 105);
            this.btDiplomas.TabIndex = 18;
            this.btDiplomas.Text = "Digitalizar";
            this.btDiplomas.UseVisualStyleBackColor = false;
            this.btDiplomas.Click += new System.EventHandler(this.btDiplomas_Click);
            // 
            // btIngresar
            // 
            this.btIngresar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btIngresar.ForeColor = System.Drawing.Color.Snow;
            this.btIngresar.Location = new System.Drawing.Point(125, 195);
            this.btIngresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(87, 105);
            this.btIngresar.TabIndex = 20;
            this.btIngresar.Text = "Ingresar Datos en Curso Basico";
            this.btIngresar.UseVisualStyleBackColor = false;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // cbCursos
            // 
            this.cbCursos.FormattingEnabled = true;
            this.cbCursos.Items.AddRange(new object[] {
            "Basico",
            "IntermedioI",
            "IntermedioII",
            "IntermedioIII",
            "IntermedioIV"});
            this.cbCursos.Location = new System.Drawing.Point(198, 130);
            this.cbCursos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(140, 25);
            this.cbCursos.TabIndex = 21;
            this.cbCursos.SelectedIndexChanged += new System.EventHandler(this.cbCursos_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Curso:";
            // 
            // btSubir
            // 
            this.btSubir.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btSubir.ForeColor = System.Drawing.Color.Snow;
            this.btSubir.Location = new System.Drawing.Point(296, 462);
            this.btSubir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSubir.Name = "btSubir";
            this.btSubir.Size = new System.Drawing.Size(87, 105);
            this.btSubir.TabIndex = 23;
            this.btSubir.Text = "Subir a Curso";
            this.btSubir.UseVisualStyleBackColor = false;
            this.btSubir.Click += new System.EventHandler(this.btSubir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Fugaz One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(88, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Digitalización y Visión de Alumnos ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Fugaz One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "Para el Instituo Chihuahuense de Lenguaje de Señas";
            // 
            // btDatosSuperior
            // 
            this.btDatosSuperior.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btDatosSuperior.ForeColor = System.Drawing.Color.Snow;
            this.btDatosSuperior.Location = new System.Drawing.Point(296, 195);
            this.btDatosSuperior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDatosSuperior.Name = "btDatosSuperior";
            this.btDatosSuperior.Size = new System.Drawing.Size(87, 105);
            this.btDatosSuperior.TabIndex = 26;
            this.btDatosSuperior.Text = "Ingresar Datos en Otros Cursos";
            this.btDatosSuperior.UseVisualStyleBackColor = false;
            this.btDatosSuperior.Click += new System.EventHandler(this.btDatosSuperior_Click);
            // 
            // Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(530, 649);
            this.Controls.Add(this.btDatosSuperior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSubir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCursos);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.btVerAlu);
            this.Controls.Add(this.btDiplomas);
            this.Font = new System.Drawing.Font("Fugaz One", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menus";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVerAlu;
        private System.Windows.Forms.Button btDiplomas;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.ComboBox cbCursos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSubir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDatosSuperior;
    }
}