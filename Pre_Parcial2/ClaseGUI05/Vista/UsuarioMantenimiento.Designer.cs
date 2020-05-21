using System.ComponentModel;

namespace ClaseGUI05
{
    partial class UsuarioMantenimiento
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.modificarUsuario1 = new ClaseGUI05.ModificarUsuario();
            this.administrador1 = new ClaseGUI05.Administrador();
            this.eliminarUsuario1 = new ClaseGUI05.EliminarUsuario();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 183);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(3, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 183);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(3, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 183);
            this.button3.TabIndex = 2;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.11001F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.88999F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.modificarUsuario1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.administrador1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.eliminarUsuario1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1009, 631);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // modificarUsuario1
            // 
            this.modificarUsuario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modificarUsuario1.Location = new System.Drawing.Point(216, 192);
            this.modificarUsuario1.Name = "modificarUsuario1";
            this.modificarUsuario1.Size = new System.Drawing.Size(790, 183);
            this.modificarUsuario1.TabIndex = 3;
            // 
            // administrador1
            // 
            this.administrador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.administrador1.Location = new System.Drawing.Point(216, 3);
            this.administrador1.Name = "administrador1";
            this.administrador1.Size = new System.Drawing.Size(790, 183);
            this.administrador1.TabIndex = 4;
            // 
            // eliminarUsuario1
            // 
            this.eliminarUsuario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eliminarUsuario1.Location = new System.Drawing.Point(216, 381);
            this.eliminarUsuario1.Name = "eliminarUsuario1";
            this.eliminarUsuario1.Size = new System.Drawing.Size(790, 183);
            this.eliminarUsuario1.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 570);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 58);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // UsuarioMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1009, 631);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UsuarioMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioMantenimiento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsuarioMantenimiento_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ClaseGUI05.ModificarUsuario modificarUsuario1;
        private ClaseGUI05.Administrador administrador1;
        private ClaseGUI05.EliminarUsuario eliminarUsuario1;
        private System.Windows.Forms.Button button4;
    }
}