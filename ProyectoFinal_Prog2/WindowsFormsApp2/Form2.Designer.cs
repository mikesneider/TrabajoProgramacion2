namespace WindowsFormsApp2
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CKB_Activar = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_CantidadLibro = new System.Windows.Forms.Label();
            this.LB_NombreLibro = new System.Windows.Forms.Label();
            this.TB_CantLibros = new System.Windows.Forms.TextBox();
            this.TB_ISBN = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.CB_Editorial = new System.Windows.Forms.ComboBox();
            this.BTN_Actualizar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Location = new System.Drawing.Point(423, 414);
            this.Btn_ayuda.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CKB_Activar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LB_CantidadLibro);
            this.groupBox1.Controls.Add(this.LB_NombreLibro);
            this.groupBox1.Controls.Add(this.TB_CantLibros);
            this.groupBox1.Controls.Add(this.TB_ISBN);
            this.groupBox1.Controls.Add(this.TB_Name);
            this.groupBox1.Controls.Add(this.CB_Editorial);
            this.groupBox1.Controls.Add(this.BTN_Actualizar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(420, 450);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Seleccionados";
            // 
            // CKB_Activar
            // 
            this.CKB_Activar.AutoSize = true;
            this.CKB_Activar.Location = new System.Drawing.Point(148, 332);
            this.CKB_Activar.Margin = new System.Windows.Forms.Padding(4);
            this.CKB_Activar.Name = "CKB_Activar";
            this.CKB_Activar.Size = new System.Drawing.Size(68, 20);
            this.CKB_Activar.TabIndex = 16;
            this.CKB_Activar.Text = "Activar";
            this.CKB_Activar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Editorial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "ISBN";
            // 
            // LB_CantidadLibro
            // 
            this.LB_CantidadLibro.AutoSize = true;
            this.LB_CantidadLibro.Location = new System.Drawing.Point(12, 129);
            this.LB_CantidadLibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_CantidadLibro.Name = "LB_CantidadLibro";
            this.LB_CantidadLibro.Size = new System.Drawing.Size(121, 16);
            this.LB_CantidadLibro.TabIndex = 13;
            this.LB_CantidadLibro.Text = "Cantidad de Libros";
            // 
            // LB_NombreLibro
            // 
            this.LB_NombreLibro.AutoSize = true;
            this.LB_NombreLibro.Location = new System.Drawing.Point(9, 62);
            this.LB_NombreLibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NombreLibro.Name = "LB_NombreLibro";
            this.LB_NombreLibro.Size = new System.Drawing.Size(112, 16);
            this.LB_NombreLibro.TabIndex = 12;
            this.LB_NombreLibro.Text = "Nombre del Libro";
            // 
            // TB_CantLibros
            // 
            this.TB_CantLibros.Location = new System.Drawing.Point(38, 155);
            this.TB_CantLibros.Margin = new System.Windows.Forms.Padding(4);
            this.TB_CantLibros.Name = "TB_CantLibros";
            this.TB_CantLibros.Size = new System.Drawing.Size(306, 22);
            this.TB_CantLibros.TabIndex = 9;
            this.TB_CantLibros.Leave += new System.EventHandler(this.TB_CantLibros_Leave);
            // 
            // TB_ISBN
            // 
            this.TB_ISBN.Location = new System.Drawing.Point(38, 224);
            this.TB_ISBN.Margin = new System.Windows.Forms.Padding(4);
            this.TB_ISBN.Name = "TB_ISBN";
            this.TB_ISBN.Size = new System.Drawing.Size(306, 22);
            this.TB_ISBN.TabIndex = 8;
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(38, 87);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(306, 22);
            this.TB_Name.TabIndex = 7;
            // 
            // CB_Editorial
            // 
            this.CB_Editorial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_Editorial.FormattingEnabled = true;
            this.CB_Editorial.Items.AddRange(new object[] {
            "Libro",
            "PDF",
            "DVD"});
            this.CB_Editorial.Location = new System.Drawing.Point(38, 291);
            this.CB_Editorial.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Editorial.Name = "CB_Editorial";
            this.CB_Editorial.Size = new System.Drawing.Size(306, 24);
            this.CB_Editorial.TabIndex = 1;
            // 
            // BTN_Actualizar
            // 
            this.BTN_Actualizar.Location = new System.Drawing.Point(135, 392);
            this.BTN_Actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Actualizar.Name = "BTN_Actualizar";
            this.BTN_Actualizar.Size = new System.Drawing.Size(129, 37);
            this.BTN_Actualizar.TabIndex = 0;
            this.BTN_Actualizar.Text = "Actualizar";
            this.BTN_Actualizar.UseVisualStyleBackColor = true;
            this.BTN_Actualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = base.BackColor; // System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(456, 482);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Datos";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.Btn_ayuda, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_CantidadLibro;
        private System.Windows.Forms.Label LB_NombreLibro;
        private System.Windows.Forms.TextBox TB_CantLibros;
        private System.Windows.Forms.TextBox TB_ISBN;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.ComboBox CB_Editorial;
        private System.Windows.Forms.Button BTN_Actualizar;
        private System.Windows.Forms.CheckBox CKB_Activar;
    }
}