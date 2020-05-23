﻿using System.ComponentModel;

namespace ClaseGUI05
{
    partial class VerPedidosUsuario
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
            this.dataGridPedidosUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridPedidosUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPedidosUsuario
            // 
            this.dataGridPedidosUsuario.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPedidosUsuario.Location = new System.Drawing.Point(1, 8);
            this.dataGridPedidosUsuario.Name = "dataGridPedidosUsuario";
            this.dataGridPedidosUsuario.Size = new System.Drawing.Size(688, 507);
            this.dataGridPedidosUsuario.TabIndex = 0;
            // 
            // VerPedidosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 519);
            this.Controls.Add(this.dataGridPedidosUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VerPedidosUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerPedidosUsuario";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridPedidosUsuario)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPedidosUsuario;
    }
}