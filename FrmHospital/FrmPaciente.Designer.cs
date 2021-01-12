namespace FrmHospital
{
    partial class FrmPaciente
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
            this.cbxPadecimiento = new System.Windows.Forms.ComboBox();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.tbxEdad = new System.Windows.Forms.TextBox();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.tbxDni = new System.Windows.Forms.TextBox();
            this.tbxApellidos = new System.Windows.Forms.TextBox();
            this.tbxNombres = new System.Windows.Forms.TextBox();
            this.lblPadecimiento = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgPacientes = new System.Windows.Forms.DataGridView();
            this.txtCodigoCita = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxPadecimiento
            // 
            this.cbxPadecimiento.FormattingEnabled = true;
            this.cbxPadecimiento.Items.AddRange(new object[] {
            "Diagnóstico de Alergia",
            "Diagnóstico de Corazón",
            "Enfermedades Adultos Mayores",
            "Diagnóstico de Útero, Vagina",
            "Enfermedades Neurológicas",
            "Enfermedades del Ojo",
            "Salud de Hijos",
            "Problemas Mentales",
            "Problemas Urinarios",
            "Lesiones Traumáticas",
            "Tumores Malignos",
            "Oido y Vias Respiratorias "});
            this.cbxPadecimiento.Location = new System.Drawing.Point(115, 141);
            this.cbxPadecimiento.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPadecimiento.Name = "cbxPadecimiento";
            this.cbxPadecimiento.Size = new System.Drawing.Size(270, 24);
            this.cbxPadecimiento.TabIndex = 27;
            // 
            // cbxSexo
            // 
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbxSexo.Location = new System.Drawing.Point(379, 27);
            this.cbxSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(160, 24);
            this.cbxSexo.TabIndex = 26;
            // 
            // tbxEdad
            // 
            this.tbxEdad.Location = new System.Drawing.Point(379, 68);
            this.tbxEdad.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEdad.Name = "tbxEdad";
            this.tbxEdad.Size = new System.Drawing.Size(41, 22);
            this.tbxEdad.TabIndex = 25;
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(115, 111);
            this.tbxTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(132, 22);
            this.tbxTelefono.TabIndex = 24;
            // 
            // tbxDni
            // 
            this.tbxDni.Location = new System.Drawing.Point(115, 82);
            this.tbxDni.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDni.Name = "tbxDni";
            this.tbxDni.Size = new System.Drawing.Size(132, 22);
            this.tbxDni.TabIndex = 23;
            // 
            // tbxApellidos
            // 
            this.tbxApellidos.Location = new System.Drawing.Point(115, 53);
            this.tbxApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.tbxApellidos.Name = "tbxApellidos";
            this.tbxApellidos.Size = new System.Drawing.Size(132, 22);
            this.tbxApellidos.TabIndex = 22;
            // 
            // tbxNombres
            // 
            this.tbxNombres.Location = new System.Drawing.Point(115, 27);
            this.tbxNombres.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNombres.Name = "tbxNombres";
            this.tbxNombres.Size = new System.Drawing.Size(132, 22);
            this.tbxNombres.TabIndex = 21;
            // 
            // lblPadecimiento
            // 
            this.lblPadecimiento.AutoSize = true;
            this.lblPadecimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblPadecimiento.Location = new System.Drawing.Point(14, 144);
            this.lblPadecimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPadecimiento.Name = "lblPadecimiento";
            this.lblPadecimiento.Size = new System.Drawing.Size(93, 17);
            this.lblPadecimiento.TabIndex = 20;
            this.lblPadecimiento.Text = "Padecimiento";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.Transparent;
            this.lblEdad.Location = new System.Drawing.Point(328, 71);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(41, 17);
            this.lblEdad.TabIndex = 19;
            this.lblEdad.Text = "Edad";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Location = new System.Drawing.Point(330, 30);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 17);
            this.lblSexo.TabIndex = 18;
            this.lblSexo.Text = "Sexo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Location = new System.Drawing.Point(29, 116);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 17;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Location = new System.Drawing.Point(29, 87);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(31, 17);
            this.lblDni.TabIndex = 16;
            this.lblDni.Text = "DNI";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidos.Location = new System.Drawing.Point(29, 58);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(65, 17);
            this.lblApellidos.TabIndex = 15;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.Transparent;
            this.lblNombres.Location = new System.Drawing.Point(29, 30);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(65, 17);
            this.lblNombres.TabIndex = 14;
            this.lblNombres.Text = "Nombres";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(379, 559);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 27);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(193, 559);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 27);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSalir.Location = new System.Drawing.Point(560, 557);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRegistrar.Location = new System.Drawing.Point(16, 557);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 28);
            this.btnRegistrar.TabIndex = 28;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Codigo Cita";
            // 
            // dgPacientes
            // 
            this.dgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPacientes.Location = new System.Drawing.Point(17, 189);
            this.dgPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgPacientes.Name = "dgPacientes";
            this.dgPacientes.Size = new System.Drawing.Size(667, 350);
            this.dgPacientes.TabIndex = 35;
            this.dgPacientes.SelectionChanged += new System.EventHandler(this.dgPacientes_SelectionChanged);
            // 
            // txtCodigoCita
            // 
            this.txtCodigoCita.Location = new System.Drawing.Point(379, 110);
            this.txtCodigoCita.Name = "txtCodigoCita";
            this.txtCodigoCita.Size = new System.Drawing.Size(160, 22);
            this.txtCodigoCita.TabIndex = 36;
            // 
            // FrmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 627);
            this.Controls.Add(this.txtCodigoCita);
            this.Controls.Add(this.dgPacientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbxPadecimiento);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.tbxEdad);
            this.Controls.Add(this.tbxTelefono);
            this.Controls.Add(this.tbxDni);
            this.Controls.Add(this.tbxApellidos);
            this.Controls.Add(this.tbxNombres);
            this.Controls.Add(this.lblPadecimiento);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPaciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPadecimiento;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.TextBox tbxEdad;
        private System.Windows.Forms.TextBox tbxTelefono;
        private System.Windows.Forms.TextBox tbxDni;
        private System.Windows.Forms.TextBox tbxApellidos;
        private System.Windows.Forms.TextBox tbxNombres;
        private System.Windows.Forms.Label lblPadecimiento;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPacientes;
        private System.Windows.Forms.TextBox txtCodigoCita;
    }
}