namespace ClaseGUI05
{
    partial class frmInicioSesion
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.VendePapas = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.VendePapas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(182, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(278, 92);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(175, 23);
            this.cmbUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(182, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contrasena:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(278, 137);
            this.txtContrasena.MaxLength = 25;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(175, 23);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContrasena_KeyDown);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Coral;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(278, 185);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(177, 27);
            this.btnIniciarSesion.TabIndex = 6;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Las mejores papas de konoha";
            // 
            // VendePapas
            // 
            this.VendePapas.BackgroundImage = global::ClaseGUI05.Properties.Resources.Logo__2_;
            this.VendePapas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VendePapas.Location = new System.Drawing.Point(23, 64);
            this.VendePapas.Name = "VendePapas";
            this.VendePapas.Size = new System.Drawing.Size(153, 165);
            this.VendePapas.TabIndex = 8;
            this.VendePapas.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(59, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tienda Orochi Papas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(493, 304);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VendePapas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidos - Iniciar sesion";
            this.Load += new System.EventHandler(this.frmInicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize) (this.VendePapas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox VendePapas;
        private System.Windows.Forms.Label label4;
    }
}