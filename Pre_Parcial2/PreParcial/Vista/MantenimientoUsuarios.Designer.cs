using System.ComponentModel;

namespace ClaseGUI05
{
    partial class MantenimientoUsuarios
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPassAgregar = new System.Windows.Forms.TextBox();
            this.lblPassAgregar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.CheckAdmiAgregar = new System.Windows.Forms.CheckBox();
            this.lblusuarioAgregar = new System.Windows.Forms.Label();
            this.txtUsuarioAgregar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuarioEditar = new System.Windows.Forms.Label();
            this.txtPassEditar = new System.Windows.Forms.TextBox();
            this.checkAdmiEditar = new System.Windows.Forms.CheckBox();
            this.cmbEditarUsuario = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.lblUsuarioEliminar = new System.Windows.Forms.Label();
            this.cmbUsuarioEliminar = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 519);
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
            this.tabControl1.Size = new System.Drawing.Size(927, 513);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(919, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.RosyBrown;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtPassAgregar, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPassAgregar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAgregar, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.CheckAdmiAgregar, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblusuarioAgregar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtUsuarioAgregar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(913, 479);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // txtPassAgregar
            // 
            this.txtPassAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassAgregar.Location = new System.Drawing.Point(610, 227);
            this.txtPassAgregar.Name = "txtPassAgregar";
            this.txtPassAgregar.PasswordChar = '*';
            this.txtPassAgregar.Size = new System.Drawing.Size(149, 23);
            this.txtPassAgregar.TabIndex = 2;
            // 
            // lblPassAgregar
            // 
            this.lblPassAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPassAgregar.Location = new System.Drawing.Point(144, 227);
            this.lblPassAgregar.Name = "lblPassAgregar";
            this.lblPassAgregar.Size = new System.Drawing.Size(167, 23);
            this.lblPassAgregar.TabIndex = 1;
            this.lblPassAgregar.Text = "Contraseña";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.Coral;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(174, 374);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 48);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // CheckAdmiAgregar
            // 
            this.CheckAdmiAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CheckAdmiAgregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.CheckAdmiAgregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckAdmiAgregar.Location = new System.Drawing.Point(586, 386);
            this.CheckAdmiAgregar.Name = "CheckAdmiAgregar";
            this.CheckAdmiAgregar.Size = new System.Drawing.Size(197, 24);
            this.CheckAdmiAgregar.TabIndex = 5;
            this.CheckAdmiAgregar.Text = "Administrador";
            this.CheckAdmiAgregar.UseVisualStyleBackColor = true;
            // 
            // lblusuarioAgregar
            // 
            this.lblusuarioAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblusuarioAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblusuarioAgregar.Location = new System.Drawing.Point(178, 68);
            this.lblusuarioAgregar.Name = "lblusuarioAgregar";
            this.lblusuarioAgregar.Size = new System.Drawing.Size(100, 23);
            this.lblusuarioAgregar.TabIndex = 0;
            this.lblusuarioAgregar.Text = "Usuario";
            // 
            // txtUsuarioAgregar
            // 
            this.txtUsuarioAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuarioAgregar.Location = new System.Drawing.Point(613, 68);
            this.txtUsuarioAgregar.Name = "txtUsuarioAgregar";
            this.txtUsuarioAgregar.Size = new System.Drawing.Size(143, 23);
            this.txtUsuarioAgregar.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(919, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar usuario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.RosyBrown;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnEditarUsuario, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblUsuarioEditar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtPassEditar, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.checkAdmiEditar, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.cmbEditarUsuario, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(913, 479);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarUsuario.BackColor = System.Drawing.Color.Coral;
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarUsuario.Location = new System.Drawing.Point(174, 374);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(108, 48);
            this.btnEditarUsuario.TabIndex = 8;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(139, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nueva contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuarioEditar
            // 
            this.lblUsuarioEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuarioEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUsuarioEditar.Location = new System.Drawing.Point(178, 68);
            this.lblUsuarioEditar.Name = "lblUsuarioEditar";
            this.lblUsuarioEditar.Size = new System.Drawing.Size(100, 23);
            this.lblUsuarioEditar.TabIndex = 1;
            this.lblUsuarioEditar.Text = "Usuario";
            // 
            // txtPassEditar
            // 
            this.txtPassEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassEditar.Location = new System.Drawing.Point(610, 227);
            this.txtPassEditar.Name = "txtPassEditar";
            this.txtPassEditar.PasswordChar = '*';
            this.txtPassEditar.Size = new System.Drawing.Size(149, 23);
            this.txtPassEditar.TabIndex = 6;
            // 
            // checkAdmiEditar
            // 
            this.checkAdmiEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkAdmiEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkAdmiEditar.Location = new System.Drawing.Point(599, 386);
            this.checkAdmiEditar.Name = "checkAdmiEditar";
            this.checkAdmiEditar.Size = new System.Drawing.Size(171, 24);
            this.checkAdmiEditar.TabIndex = 7;
            this.checkAdmiEditar.Text = "Administrador";
            this.checkAdmiEditar.UseVisualStyleBackColor = true;
            // 
            // cmbEditarUsuario
            // 
            this.cmbEditarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEditarUsuario.FormattingEnabled = true;
            this.cmbEditarUsuario.Location = new System.Drawing.Point(613, 68);
            this.cmbEditarUsuario.Name = "cmbEditarUsuario";
            this.cmbEditarUsuario.Size = new System.Drawing.Size(142, 23);
            this.cmbEditarUsuario.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(919, 485);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar usuario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.RosyBrown;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnEliminarUsuario, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblUsuarioEliminar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmbUsuarioEliminar, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(919, 485);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.Coral;
            this.tableLayoutPanel3.SetColumnSpan(this.btnEliminarUsuario, 2);
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(405, 339);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(108, 48);
            this.btnEliminarUsuario.TabIndex = 9;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // lblUsuarioEliminar
            // 
            this.lblUsuarioEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuarioEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUsuarioEliminar.Location = new System.Drawing.Point(179, 109);
            this.lblUsuarioEliminar.Name = "lblUsuarioEliminar";
            this.lblUsuarioEliminar.Size = new System.Drawing.Size(100, 23);
            this.lblUsuarioEliminar.TabIndex = 2;
            this.lblUsuarioEliminar.Text = "Usuario";
            // 
            // cmbUsuarioEliminar
            // 
            this.cmbUsuarioEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUsuarioEliminar.FormattingEnabled = true;
            this.cmbUsuarioEliminar.Location = new System.Drawing.Point(594, 109);
            this.cmbUsuarioEliminar.Name = "cmbUsuarioEliminar";
            this.cmbUsuarioEliminar.Size = new System.Drawing.Size(189, 23);
            this.cmbUsuarioEliminar.TabIndex = 10;
            // 
            // MantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MantenimientoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoUsuarios";
            this.Load += new System.EventHandler(this.MantenimientoUsuarios_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblusuarioAgregar;
        private System.Windows.Forms.Label lblPassAgregar;
        private System.Windows.Forms.TextBox txtPassAgregar;
        private System.Windows.Forms.CheckBox CheckAdmiAgregar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cmbUsuarioEliminar;
        private System.Windows.Forms.TextBox txtUsuarioAgregar;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Label lblUsuarioEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.CheckBox checkAdmiEditar;
        private System.Windows.Forms.TextBox txtPassEditar;
        private System.Windows.Forms.Label lblUsuarioEditar;
        private System.Windows.Forms.ComboBox cmbEditarUsuario;
    }
}