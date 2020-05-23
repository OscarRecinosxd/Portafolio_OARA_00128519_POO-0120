using System.ComponentModel;

namespace ClaseGUI05
{
    partial class MantenimientoStock
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombreAgregar = new System.Windows.Forms.Label();
            this.lblDescripcionAgregar = new System.Windows.Forms.Label();
            this.lblCantidadAgregar = new System.Windows.Forms.Label();
            this.lblPrecioAgregar = new System.Windows.Forms.Label();
            this.txtNombreAgregar = new System.Windows.Forms.TextBox();
            this.numericPrecioAgregar = new System.Windows.Forms.NumericUpDown();
            this.numericCantidadAgregar = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.richTextDescripcionAgregar = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombreEditar = new System.Windows.Forms.Label();
            this.lblDescripcionEditar = new System.Windows.Forms.Label();
            this.lblCantidadEditar = new System.Windows.Forms.Label();
            this.lblPrecioEditar = new System.Windows.Forms.Label();
            this.numericPrecioEditar = new System.Windows.Forms.NumericUpDown();
            this.numericCantidadEditar = new System.Windows.Forms.NumericUpDown();
            this.btnEditar = new System.Windows.Forms.Button();
            this.richTextEditar = new System.Windows.Forms.RichTextBox();
            this.comboNombreEditar = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNombreEliminar = new System.Windows.Forms.Label();
            this.comboUsuarioEliminar = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericPrecioAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericCantidadAgregar)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericPrecioEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericCantidadEditar)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(5, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 513);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(919, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar inventario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.RosyBrown;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblNombreAgregar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescripcionAgregar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCantidadAgregar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPrecioAgregar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNombreAgregar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericPrecioAgregar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericCantidadAgregar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAgregar, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.richTextDescripcionAgregar, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(913, 479);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblNombreAgregar
            // 
            this.lblNombreAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNombreAgregar.Location = new System.Drawing.Point(167, 36);
            this.lblNombreAgregar.Name = "lblNombreAgregar";
            this.lblNombreAgregar.Size = new System.Drawing.Size(121, 23);
            this.lblNombreAgregar.TabIndex = 0;
            this.lblNombreAgregar.Text = "Nombre";
            // 
            // lblDescripcionAgregar
            // 
            this.lblDescripcionAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcionAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDescripcionAgregar.Location = new System.Drawing.Point(163, 131);
            this.lblDescripcionAgregar.Name = "lblDescripcionAgregar";
            this.lblDescripcionAgregar.Size = new System.Drawing.Size(129, 23);
            this.lblDescripcionAgregar.TabIndex = 1;
            this.lblDescripcionAgregar.Text = "Descripcion";
            // 
            // lblCantidadAgregar
            // 
            this.lblCantidadAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidadAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblCantidadAgregar.Location = new System.Drawing.Point(171, 321);
            this.lblCantidadAgregar.Name = "lblCantidadAgregar";
            this.lblCantidadAgregar.Size = new System.Drawing.Size(114, 23);
            this.lblCantidadAgregar.TabIndex = 3;
            this.lblCantidadAgregar.Text = "Cantidad";
            // 
            // lblPrecioAgregar
            // 
            this.lblPrecioAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecioAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPrecioAgregar.Location = new System.Drawing.Point(171, 226);
            this.lblPrecioAgregar.Name = "lblPrecioAgregar";
            this.lblPrecioAgregar.Size = new System.Drawing.Size(114, 23);
            this.lblPrecioAgregar.TabIndex = 2;
            this.lblPrecioAgregar.Text = "Precio";
            // 
            // txtNombreAgregar
            // 
            this.txtNombreAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreAgregar.Location = new System.Drawing.Point(634, 36);
            this.txtNombreAgregar.Name = "txtNombreAgregar";
            this.txtNombreAgregar.Size = new System.Drawing.Size(100, 23);
            this.txtNombreAgregar.TabIndex = 4;
            // 
            // numericPrecioAgregar
            // 
            this.numericPrecioAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericPrecioAgregar.DecimalPlaces = 2;
            this.numericPrecioAgregar.Location = new System.Drawing.Point(624, 226);
            this.numericPrecioAgregar.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.numericPrecioAgregar.Name = "numericPrecioAgregar";
            this.numericPrecioAgregar.Size = new System.Drawing.Size(120, 23);
            this.numericPrecioAgregar.TabIndex = 6;
            // 
            // numericCantidadAgregar
            // 
            this.numericCantidadAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericCantidadAgregar.Location = new System.Drawing.Point(624, 321);
            this.numericCantidadAgregar.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.numericCantidadAgregar.Name = "numericCantidadAgregar";
            this.numericCantidadAgregar.Size = new System.Drawing.Size(120, 23);
            this.numericCantidadAgregar.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.Coral;
            this.tableLayoutPanel1.SetColumnSpan(this.btnAgregar, 2);
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(409, 410);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 38);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // richTextDescripcionAgregar
            // 
            this.richTextDescripcionAgregar.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.richTextDescripcionAgregar.Location = new System.Drawing.Point(459, 98);
            this.richTextDescripcionAgregar.Name = "richTextDescripcionAgregar";
            this.richTextDescripcionAgregar.Size = new System.Drawing.Size(451, 89);
            this.richTextDescripcionAgregar.TabIndex = 9;
            this.richTextDescripcionAgregar.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(919, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar inventario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.RosyBrown;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblNombreEditar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDescripcionEditar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCantidadEditar, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblPrecioEditar, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericPrecioEditar, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericCantidadEditar, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnEditar, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.richTextEditar, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboNombreEditar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(913, 481);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblNombreEditar
            // 
            this.lblNombreEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNombreEditar.Location = new System.Drawing.Point(178, 36);
            this.lblNombreEditar.Name = "lblNombreEditar";
            this.lblNombreEditar.Size = new System.Drawing.Size(100, 23);
            this.lblNombreEditar.TabIndex = 0;
            this.lblNombreEditar.Text = "Nombre";
            // 
            // lblDescripcionEditar
            // 
            this.lblDescripcionEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcionEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDescripcionEditar.Location = new System.Drawing.Point(169, 132);
            this.lblDescripcionEditar.Name = "lblDescripcionEditar";
            this.lblDescripcionEditar.Size = new System.Drawing.Size(117, 23);
            this.lblDescripcionEditar.TabIndex = 1;
            this.lblDescripcionEditar.Text = "Descripcion";
            // 
            // lblCantidadEditar
            // 
            this.lblCantidadEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidadEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblCantidadEditar.Location = new System.Drawing.Point(178, 324);
            this.lblCantidadEditar.Name = "lblCantidadEditar";
            this.lblCantidadEditar.Size = new System.Drawing.Size(100, 23);
            this.lblCantidadEditar.TabIndex = 3;
            this.lblCantidadEditar.Text = "Cantidad";
            // 
            // lblPrecioEditar
            // 
            this.lblPrecioEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecioEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPrecioEditar.Location = new System.Drawing.Point(178, 228);
            this.lblPrecioEditar.Name = "lblPrecioEditar";
            this.lblPrecioEditar.Size = new System.Drawing.Size(100, 23);
            this.lblPrecioEditar.TabIndex = 2;
            this.lblPrecioEditar.Text = "Precio";
            // 
            // numericPrecioEditar
            // 
            this.numericPrecioEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericPrecioEditar.DecimalPlaces = 2;
            this.numericPrecioEditar.Location = new System.Drawing.Point(624, 228);
            this.numericPrecioEditar.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.numericPrecioEditar.Name = "numericPrecioEditar";
            this.numericPrecioEditar.Size = new System.Drawing.Size(120, 23);
            this.numericPrecioEditar.TabIndex = 6;
            // 
            // numericCantidadEditar
            // 
            this.numericCantidadEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericCantidadEditar.Location = new System.Drawing.Point(624, 324);
            this.numericCantidadEditar.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.numericCantidadEditar.Name = "numericCantidadEditar";
            this.numericCantidadEditar.Size = new System.Drawing.Size(120, 23);
            this.numericCantidadEditar.TabIndex = 7;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.Coral;
            this.tableLayoutPanel2.SetColumnSpan(this.btnEditar, 2);
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(409, 413);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 38);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // richTextEditar
            // 
            this.richTextEditar.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.richTextEditar.Location = new System.Drawing.Point(459, 99);
            this.richTextEditar.Name = "richTextEditar";
            this.richTextEditar.Size = new System.Drawing.Size(451, 90);
            this.richTextEditar.TabIndex = 10;
            this.richTextEditar.Text = "";
            // 
            // comboNombreEditar
            // 
            this.comboNombreEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboNombreEditar.FormattingEnabled = true;
            this.comboNombreEditar.Location = new System.Drawing.Point(593, 36);
            this.comboNombreEditar.Name = "comboNombreEditar";
            this.comboNombreEditar.Size = new System.Drawing.Size(182, 23);
            this.comboNombreEditar.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(919, 485);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar inventario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.RosyBrown;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnEliminar, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblNombreEliminar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboUsuarioEliminar, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(919, 485);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.Coral;
            this.tableLayoutPanel3.SetColumnSpan(this.btnEliminar, 2);
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(412, 344);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 38);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblNombreEliminar
            // 
            this.lblNombreEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNombreEliminar.Location = new System.Drawing.Point(179, 109);
            this.lblNombreEliminar.Name = "lblNombreEliminar";
            this.lblNombreEliminar.Size = new System.Drawing.Size(100, 23);
            this.lblNombreEliminar.TabIndex = 0;
            this.lblNombreEliminar.Text = "Nombre";
            // 
            // comboUsuarioEliminar
            // 
            this.comboUsuarioEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboUsuarioEliminar.FormattingEnabled = true;
            this.comboUsuarioEliminar.Location = new System.Drawing.Point(628, 109);
            this.comboUsuarioEliminar.Name = "comboUsuarioEliminar";
            this.comboUsuarioEliminar.Size = new System.Drawing.Size(121, 23);
            this.comboUsuarioEliminar.TabIndex = 9;
            // 
            // MantenimientoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MantenimientoStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoStock";
            this.Load += new System.EventHandler(this.MantenimientoStock_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericPrecioAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericCantidadAgregar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.numericPrecioEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericCantidadEditar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RichTextBox richTextDescripcionAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numericCantidadAgregar;
        private System.Windows.Forms.NumericUpDown numericPrecioAgregar;
        private System.Windows.Forms.TextBox txtNombreAgregar;
        private System.Windows.Forms.Label lblPrecioAgregar;
        private System.Windows.Forms.Label lblCantidadAgregar;
        private System.Windows.Forms.Label lblDescripcionAgregar;
        private System.Windows.Forms.Label lblNombreAgregar;
        private System.Windows.Forms.ComboBox comboNombreEditar;
        private System.Windows.Forms.ComboBox comboUsuarioEliminar;
        private System.Windows.Forms.Label lblNombreEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.RichTextBox richTextEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.NumericUpDown numericCantidadEditar;
        private System.Windows.Forms.NumericUpDown numericPrecioEditar;
        private System.Windows.Forms.Label lblPrecioEditar;
        private System.Windows.Forms.Label lblCantidadEditar;
        private System.Windows.Forms.Label lblDescripcionEditar;
        private System.Windows.Forms.Label lblNombreEditar;
    }
}