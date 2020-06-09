namespace Diplomas
{
    partial class Checador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checador));
            this.dtpGraduar = new System.Windows.Forms.DateTimePicker();
            this.btDiplomas = new System.Windows.Forms.Button();
            this.alumnosDBDataSet1 = new Diplomas.AlumnosDBDataSet();
            this.btCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpExpedicion = new System.Windows.Forms.DateTimePicker();
            this.spHoras = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpGraduar
            // 
            this.dtpGraduar.Location = new System.Drawing.Point(169, 350);
            this.dtpGraduar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpGraduar.Name = "dtpGraduar";
            this.dtpGraduar.Size = new System.Drawing.Size(200, 20);
            this.dtpGraduar.TabIndex = 1;
            // 
            // btDiplomas
            // 
            this.btDiplomas.Location = new System.Drawing.Point(279, 538);
            this.btDiplomas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btDiplomas.Name = "btDiplomas";
            this.btDiplomas.Size = new System.Drawing.Size(113, 23);
            this.btDiplomas.TabIndex = 3;
            this.btDiplomas.Text = "Crear Diplomas";
            this.btDiplomas.UseVisualStyleBackColor = true;
            this.btDiplomas.Click += new System.EventHandler(this.btDiplomas_Click);
            // 
            // alumnosDBDataSet1
            // 
            this.alumnosDBDataSet1.DataSetName = "AlumnosDBDataSet";
            this.alumnosDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(147, 538);
            this.btCerrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(113, 23);
            this.btCerrar.TabIndex = 7;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 377);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha de Expedición: ";
            // 
            // dtpExpedicion
            // 
            this.dtpExpedicion.Location = new System.Drawing.Point(169, 399);
            this.dtpExpedicion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpExpedicion.Name = "dtpExpedicion";
            this.dtpExpedicion.Size = new System.Drawing.Size(200, 20);
            this.dtpExpedicion.TabIndex = 8;
            // 
            // spHoras
            // 
            this.spHoras.Location = new System.Drawing.Point(239, 447);
            this.spHoras.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.spHoras.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.spHoras.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spHoras.Name = "spHoras";
            this.spHoras.Size = new System.Drawing.Size(60, 20);
            this.spHoras.TabIndex = 10;
            this.spHoras.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 431);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Horas del Curso:";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 12);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(514, 300);
            this.dgvAlumnos.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 328);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de Graduación: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 479);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo de Curso:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 495);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 14;
            // 
            // Checador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 595);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.spHoras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpExpedicion);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btDiplomas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpGraduar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Checador";
            this.Text = "Generar Diplomas";
            this.Load += new System.EventHandler(this.Checador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpGraduar;
        private System.Windows.Forms.Button btDiplomas;
        private AlumnosDBDataSet alumnosDBDataSet1;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpExpedicion;
        private System.Windows.Forms.NumericUpDown spHoras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}