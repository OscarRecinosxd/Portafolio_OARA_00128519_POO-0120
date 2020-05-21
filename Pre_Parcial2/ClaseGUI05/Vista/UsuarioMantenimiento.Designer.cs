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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.administrador1 = new ClaseGUI05.Administrador();
            this.modificarUsuario1 = new ClaseGUI05.ModificarUsuario();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.eliminarUsuario1 = new ClaseGUI05.EliminarUsuario();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 468);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 462);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.administrador1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(645, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.modificarUsuario1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(645, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar usuario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // administrador1
            // 
            this.administrador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.administrador1.Location = new System.Drawing.Point(3, 3);
            this.administrador1.Name = "administrador1";
            this.administrador1.Size = new System.Drawing.Size(639, 428);
            this.administrador1.TabIndex = 0;
            // 
            // modificarUsuario1
            // 
            this.modificarUsuario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modificarUsuario1.Location = new System.Drawing.Point(3, 3);
            this.modificarUsuario1.Name = "modificarUsuario1";
            this.modificarUsuario1.Size = new System.Drawing.Size(639, 428);
            this.modificarUsuario1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.eliminarUsuario1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(645, 434);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar usuario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // eliminarUsuario1
            // 
            this.eliminarUsuario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eliminarUsuario1.Location = new System.Drawing.Point(0, 0);
            this.eliminarUsuario1.Name = "eliminarUsuario1";
            this.eliminarUsuario1.Size = new System.Drawing.Size(645, 434);
            this.eliminarUsuario1.TabIndex = 0;
            // 
            // UsuarioMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(659, 468);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UsuarioMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioMantenimiento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsuarioMantenimiento_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private ClaseGUI05.Administrador administrador1;
        private ClaseGUI05.ModificarUsuario modificarUsuario1;
        private ClaseGUI05.EliminarUsuario eliminarUsuario1;
        private System.Windows.Forms.TabPage tabPage3;
    }
}