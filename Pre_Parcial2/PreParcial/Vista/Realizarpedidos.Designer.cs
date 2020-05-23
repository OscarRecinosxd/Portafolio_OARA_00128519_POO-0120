using System.ComponentModel;

namespace ClaseGUI05
{
    partial class Realizar_pedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lblProducto = new System.Windows.Forms.Label();
            this.comboProductos = new System.Windows.Forms.ComboBox();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.Location = new System.Drawing.Point(92, 70);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(96, 31);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // comboProductos
            // 
            this.comboProductos.FormattingEnabled = true;
            this.comboProductos.Location = new System.Drawing.Point(205, 67);
            this.comboProductos.Name = "comboProductos";
            this.comboProductos.Size = new System.Drawing.Size(100, 23);
            this.comboProductos.TabIndex = 1;
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(205, 121);
            this.numericCantidad.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.numericCantidad.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(100, 23);
            this.numericCantidad.TabIndex = 2;
            this.numericCantidad.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(92, 123);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(76, 18);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.Coral;
            this.btnComprar.FlatAppearance.BorderSize = 0;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComprar.Location = new System.Drawing.Point(145, 183);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(119, 37);
            this.btnComprar.TabIndex = 4;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // Realizar_pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(422, 365);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.comboProductos);
            this.Controls.Add(this.lblProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Realizar_pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar_pedidos";
            this.Load += new System.EventHandler(this.Realizar_pedidos_Load);
            ((System.ComponentModel.ISupportInitialize) (this.numericCantidad)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox comboProductos;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.NumericUpDown numericCantidad;
    }
}