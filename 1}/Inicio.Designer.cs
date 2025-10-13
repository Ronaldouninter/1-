namespace _1_
{
    partial class Inicio
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
            this.dgvNombres = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.TextbNombre = new System.Windows.Forms.TextBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.TextbEliminar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNombres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNombres
            // 
            this.dgvNombres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNombres.Location = new System.Drawing.Point(43, 242);
            this.dgvNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNombres.Name = "dgvNombres";
            this.dgvNombres.RowHeadersWidth = 51;
            this.dgvNombres.Size = new System.Drawing.Size(367, 325);
            this.dgvNombres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(137, 145);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(100, 28);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(173, 575);
            this.BtnMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(100, 28);
            this.BtnMostrar.TabIndex = 4;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // TextbNombre
            // 
            this.TextbNombre.Location = new System.Drawing.Point(121, 80);
            this.TextbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextbNombre.Name = "TextbNombre";
            this.TextbNombre.Size = new System.Drawing.Size(132, 22);
            this.TextbNombre.TabIndex = 5;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(229, 15);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(180, 28);
            this.BtnRegresar.TabIndex = 6;
            this.BtnRegresar.Text = "Regresar al Loggin";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(379, 575);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(65, 28);
            this.btnExportar.TabIndex = 7;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(309, 207);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // TextbEliminar
            // 
            this.TextbEliminar.Location = new System.Drawing.Point(288, 175);
            this.TextbEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextbEliminar.Name = "TextbEliminar";
            this.TextbEliminar.Size = new System.Drawing.Size(132, 22);
            this.TextbEliminar.TabIndex = 9;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 618);
            this.Controls.Add(this.TextbEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.TextbNombre);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNombres);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNombres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.TextBox TextbNombre;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox TextbEliminar;
    }
}