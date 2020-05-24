namespace WindowsFormsApp2
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Editar = new System.Windows.Forms.Button();
            this.CKB_Activado = new System.Windows.Forms.CheckBox();
            this.LB_Contador = new System.Windows.Forms.Label();
            this.LB_NombreLibro = new System.Windows.Forms.Label();
            this.LB_Nombre = new System.Windows.Forms.Label();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Editar
            // 
            this.BTN_Editar.Location = new System.Drawing.Point(25, 91);
            this.BTN_Editar.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Editar.Name = "BTN_Editar";
            this.BTN_Editar.Size = new System.Drawing.Size(120, 24);
            this.BTN_Editar.TabIndex = 0;
            this.BTN_Editar.Text = "Editar Info";
            this.BTN_Editar.UseVisualStyleBackColor = true;
            this.BTN_Editar.Click += new System.EventHandler(this.BTN_1_Click);
            // 
            // CKB_Activado
            // 
            this.CKB_Activado.AutoSize = true;
            this.CKB_Activado.Enabled = false;
            this.CKB_Activado.Location = new System.Drawing.Point(204, 7);
            this.CKB_Activado.Margin = new System.Windows.Forms.Padding(4);
            this.CKB_Activado.Name = "CKB_Activado";
            this.CKB_Activado.Size = new System.Drawing.Size(85, 22);
            this.CKB_Activado.TabIndex = 3;
            this.CKB_Activado.Text = "Activado";
            this.CKB_Activado.UseVisualStyleBackColor = true;
            // 
            // LB_Contador
            // 
            this.LB_Contador.AutoSize = true;
            this.LB_Contador.Location = new System.Drawing.Point(4, 8);
            this.LB_Contador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Contador.Name = "LB_Contador";
            this.LB_Contador.Size = new System.Drawing.Size(16, 18);
            this.LB_Contador.TabIndex = 6;
            this.LB_Contador.Text = "#";
            // 
            // LB_NombreLibro
            // 
            this.LB_NombreLibro.AutoSize = true;
            this.LB_NombreLibro.Location = new System.Drawing.Point(147, 40);
            this.LB_NombreLibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NombreLibro.Name = "LB_NombreLibro";
            this.LB_NombreLibro.Size = new System.Drawing.Size(78, 18);
            this.LB_NombreLibro.TabIndex = 5;
            this.LB_NombreLibro.Text = "+++++++";
            // 
            // LB_Nombre
            // 
            this.LB_Nombre.AutoSize = true;
            this.LB_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Nombre.Location = new System.Drawing.Point(22, 41);
            this.LB_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Nombre.Name = "LB_Nombre";
            this.LB_Nombre.Size = new System.Drawing.Size(106, 16);
            this.LB_Nombre.TabIndex = 4;
            this.LB_Nombre.Text = "Nombre Libro:";
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(169, 91);
            this.btn_mostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(120, 24);
            this.btn_mostrar.TabIndex = 7;
            this.btn_mostrar.Text = "Mostrar Ventas";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.CKB_Activado);
            this.Controls.Add(this.BTN_Editar);
            this.Controls.Add(this.LB_NombreLibro);
            this.Controls.Add(this.LB_Contador);
            this.Controls.Add(this.LB_Nombre);
            this.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(314, 131);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Editar;
        private System.Windows.Forms.CheckBox CKB_Activado;
        private System.Windows.Forms.Label LB_Nombre;
        private System.Windows.Forms.Label LB_NombreLibro;
        private System.Windows.Forms.Label LB_Contador;
        private System.Windows.Forms.Button btn_mostrar;
    }
}
