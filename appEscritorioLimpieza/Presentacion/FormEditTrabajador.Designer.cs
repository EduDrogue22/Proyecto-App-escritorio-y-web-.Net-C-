
namespace appEscritorioLimpieza.Presentacion
{
    partial class FormEditTrabajador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditTrabajador));
            this.txtEmergencia = new System.Windows.Forms.TextBox();
            this.txtAprellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.NumericUpDown();
            this.txtDNI = new System.Windows.Forms.NumericUpDown();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtDisponible = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.BarraMenu = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            this.BarraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmergencia
            // 
            this.txtEmergencia.Location = new System.Drawing.Point(92, 341);
            this.txtEmergencia.MaxLength = 250;
            this.txtEmergencia.Name = "txtEmergencia";
            this.txtEmergencia.Size = new System.Drawing.Size(263, 20);
            this.txtEmergencia.TabIndex = 27;
            // 
            // txtAprellido
            // 
            this.txtAprellido.Location = new System.Drawing.Point(92, 249);
            this.txtAprellido.MaxLength = 100;
            this.txtAprellido.Name = "txtAprellido";
            this.txtAprellido.Size = new System.Drawing.Size(263, 20);
            this.txtAprellido.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 202);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 20);
            this.txtNombre.TabIndex = 25;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(92, 293);
            this.txtCelular.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(263, 20);
            this.txtCelular.TabIndex = 24;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(92, 153);
            this.txtDNI.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(263, 20);
            this.txtDNI.TabIndex = 23;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(161, 400);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(126, 39);
            this.btnActualizar.TabIndex = 22;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtDisponible
            // 
            this.txtDisponible.AutoSize = true;
            this.txtDisponible.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisponible.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDisponible.Location = new System.Drawing.Point(179, 367);
            this.txtDisponible.Name = "txtDisponible";
            this.txtDisponible.Size = new System.Drawing.Size(85, 18);
            this.txtDisponible.TabIndex = 21;
            this.txtDisponible.Text = "Disponible";
            this.txtDisponible.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(89, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(89, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 14);
            this.label6.TabIndex = 19;
            this.label6.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(91, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 14);
            this.label5.TabIndex = 18;
            this.label5.Text = "Contacto Emergencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(89, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 14);
            this.label3.TabIndex = 17;
            this.label3.Text = "Primer Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(89, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "Primer Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified Hans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(129, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Actualizar Trabajador";
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(92, 106);
            this.numId.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(263, 20);
            this.numId.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HP Simplified Hans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(89, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 28;
            this.label4.Text = "Id trabajador";
            // 
            // BarraMenu
            // 
            this.BarraMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraMenu.Controls.Add(this.btnCerrar);
            this.BarraMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraMenu.Location = new System.Drawing.Point(0, 0);
            this.BarraMenu.Name = "BarraMenu";
            this.BarraMenu.Size = new System.Drawing.Size(430, 35);
            this.BarraMenu.TabIndex = 43;
            this.BarraMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraMenu_Paint);
            this.BarraMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraMenu_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(393, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormEditTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(430, 451);
            this.Controls.Add(this.BarraMenu);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmergencia);
            this.Controls.Add(this.txtAprellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtDisponible);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditTrabajador";
            this.Text = "FormEditTrabajador";
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            this.BarraMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmergencia;
        private System.Windows.Forms.TextBox txtAprellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown txtCelular;
        private System.Windows.Forms.NumericUpDown txtDNI;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.CheckBox txtDisponible;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel BarraMenu;
        private System.Windows.Forms.PictureBox btnCerrar;
    }
}