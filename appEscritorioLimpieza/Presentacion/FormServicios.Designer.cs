
namespace appEscritorioLimpieza.Presentacion
{
    partial class FormServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServicios));
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.numHoras = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dtHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numComision = new System.Windows.Forms.NumericUpDown();
            this.dtHoraFin = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxSolicitud = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxDireccion = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxTrabajador = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.BarraMenu = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).BeginInit();
            this.BarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified Hans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(121, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Agregar Servicio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(93, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 14);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fecha del servicio";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(95, 107);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(92, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nuneros de horas";
            // 
            // numHoras
            // 
            this.numHoras.Location = new System.Drawing.Point(95, 154);
            this.numHoras.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numHoras.Name = "numHoras";
            this.numHoras.Size = new System.Drawing.Size(200, 20);
            this.numHoras.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(93, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 14);
            this.label3.TabIndex = 25;
            this.label3.Text = "Hora de inicio";
            // 
            // dtHoraInicio
            // 
            this.dtHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraInicio.Location = new System.Drawing.Point(96, 199);
            this.dtHoraInicio.Name = "dtHoraInicio";
            this.dtHoraInicio.Size = new System.Drawing.Size(199, 20);
            this.dtHoraInicio.TabIndex = 26;
            this.dtHoraInicio.Value = new System.DateTime(2023, 7, 7, 0, 13, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(92, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 14);
            this.label4.TabIndex = 27;
            this.label4.Text = "Comision empresa";
            // 
            // numComision
            // 
            this.numComision.Location = new System.Drawing.Point(95, 291);
            this.numComision.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numComision.Name = "numComision";
            this.numComision.Size = new System.Drawing.Size(200, 20);
            this.numComision.TabIndex = 28;
            // 
            // dtHoraFin
            // 
            this.dtHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraFin.Location = new System.Drawing.Point(96, 247);
            this.dtHoraFin.Name = "dtHoraFin";
            this.dtHoraFin.Size = new System.Drawing.Size(199, 20);
            this.dtHoraFin.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(92, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 14);
            this.label8.TabIndex = 34;
            this.label8.Text = "Hora fin";
            // 
            // cbxSolicitud
            // 
            this.cbxSolicitud.FormattingEnabled = true;
            this.cbxSolicitud.Location = new System.Drawing.Point(95, 339);
            this.cbxSolicitud.Name = "cbxSolicitud";
            this.cbxSolicitud.Size = new System.Drawing.Size(200, 21);
            this.cbxSolicitud.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(93, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 14);
            this.label9.TabIndex = 36;
            this.label9.Text = "Id Solicitud";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(93, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 14);
            this.label10.TabIndex = 38;
            this.label10.Text = "Id Direccion";
            // 
            // cbxDireccion
            // 
            this.cbxDireccion.FormattingEnabled = true;
            this.cbxDireccion.Location = new System.Drawing.Point(95, 382);
            this.cbxDireccion.Name = "cbxDireccion";
            this.cbxDireccion.Size = new System.Drawing.Size(200, 21);
            this.cbxDireccion.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(93, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 14);
            this.label11.TabIndex = 40;
            this.label11.Text = "Id Trabajador";
            // 
            // cbxTrabajador
            // 
            this.cbxTrabajador.FormattingEnabled = true;
            this.cbxTrabajador.Location = new System.Drawing.Point(95, 428);
            this.cbxTrabajador.Name = "cbxTrabajador";
            this.cbxTrabajador.Size = new System.Drawing.Size(200, 21);
            this.cbxTrabajador.TabIndex = 39;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(133, 465);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 38);
            this.btnAgregar.TabIndex = 41;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BarraMenu
            // 
            this.BarraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraMenu.Controls.Add(this.btnCerrar);
            this.BarraMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraMenu.Location = new System.Drawing.Point(0, 0);
            this.BarraMenu.Name = "BarraMenu";
            this.BarraMenu.Size = new System.Drawing.Size(384, 35);
            this.BarraMenu.TabIndex = 42;
            this.BarraMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraMenu_Paint);
            this.BarraMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraMenu_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(347, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(384, 517);
            this.Controls.Add(this.BarraMenu);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbxTrabajador);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxDireccion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxSolicitud);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtHoraFin);
            this.Controls.Add(this.numComision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtHoraInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numHoras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormServicios";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormServicios";
            this.Load += new System.EventHandler(this.FormServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComision)).EndInit();
            this.BarraMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numHoras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtHoraInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numComision;
        private System.Windows.Forms.DateTimePicker dtHoraFin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxSolicitud;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxDireccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxTrabajador;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel BarraMenu;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}