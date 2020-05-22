namespace WindowsFormsApp2
{
    partial class f_principal
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
            this.GB_IngresarDatos = new WindowsFormsApp2.cs_CustomGroupBox();
            this.BTN_Calcular = new System.Windows.Forms.Button();
            this.LB_Editorial = new System.Windows.Forms.Label();
            this.CB_Editorial = new System.Windows.Forms.ComboBox();
            this.LB_ISBN = new System.Windows.Forms.Label();
            this.TB_ISBN = new System.Windows.Forms.TextBox();
            this.LB_CantidadLibros = new System.Windows.Forms.Label();
            this.TB_CantLibros = new System.Windows.Forms.TextBox();
            this.LB_NombreLibro = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_Grf = new System.Windows.Forms.Panel();
            this.CB_Idioma = new System.Windows.Forms.ComboBox();
            this.Lbl_Elige_Idioma = new System.Windows.Forms.Label();
            this.BTN_Config = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.Btn_Cargar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_IngresarDatos.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Location = new System.Drawing.Point(1008, 472);
            this.Btn_ayuda.Size = new System.Drawing.Size(87, 25);
            this.Btn_ayuda.Text = "Activar";
            // 
            // GB_IngresarDatos
            // 
            this.GB_IngresarDatos.Controls.Add(this.BTN_Calcular);
            this.GB_IngresarDatos.Controls.Add(this.LB_Editorial);
            this.GB_IngresarDatos.Controls.Add(this.CB_Editorial);
            this.GB_IngresarDatos.Controls.Add(this.LB_ISBN);
            this.GB_IngresarDatos.Controls.Add(this.TB_ISBN);
            this.GB_IngresarDatos.Controls.Add(this.LB_CantidadLibros);
            this.GB_IngresarDatos.Controls.Add(this.TB_CantLibros);
            this.GB_IngresarDatos.Controls.Add(this.LB_NombreLibro);
            this.GB_IngresarDatos.Controls.Add(this.TB_Name);
            this.GB_IngresarDatos.Location = new System.Drawing.Point(12, 41);
            this.GB_IngresarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_IngresarDatos.Name = "GB_IngresarDatos";
            this.GB_IngresarDatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GB_IngresarDatos.Size = new System.Drawing.Size(301, 319);
            this.GB_IngresarDatos.TabIndex = 1;
            this.GB_IngresarDatos.TabStop = false;
            this.GB_IngresarDatos.Text = "Ingresar Datos";
            // 
            // BTN_Calcular
            // 
            this.BTN_Calcular.Location = new System.Drawing.Point(23, 244);
            this.BTN_Calcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Calcular.Name = "BTN_Calcular";
            this.BTN_Calcular.Size = new System.Drawing.Size(233, 26);
            this.BTN_Calcular.TabIndex = 2;
            this.BTN_Calcular.Text = "Ingresar";
            this.BTN_Calcular.UseVisualStyleBackColor = true;
            this.BTN_Calcular.Click += new System.EventHandler(this.BTN_Calcular_Click);
            // 
            // LB_Editorial
            // 
            this.LB_Editorial.AutoSize = true;
            this.LB_Editorial.Location = new System.Drawing.Point(20, 176);
            this.LB_Editorial.Name = "LB_Editorial";
            this.LB_Editorial.Size = new System.Drawing.Size(63, 18);
            this.LB_Editorial.TabIndex = 8;
            this.LB_Editorial.Text = "Editorial";
            // 
            // CB_Editorial
            // 
            this.CB_Editorial.FormattingEnabled = true;
            this.CB_Editorial.Location = new System.Drawing.Point(22, 196);
            this.CB_Editorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_Editorial.Name = "CB_Editorial";
            this.CB_Editorial.Size = new System.Drawing.Size(233, 26);
            this.CB_Editorial.TabIndex = 7;
            // 
            // LB_ISBN
            // 
            this.LB_ISBN.AutoSize = true;
            this.LB_ISBN.Location = new System.Drawing.Point(19, 123);
            this.LB_ISBN.Name = "LB_ISBN";
            this.LB_ISBN.Size = new System.Drawing.Size(39, 18);
            this.LB_ISBN.TabIndex = 5;
            this.LB_ISBN.Text = "ISBN";
            // 
            // TB_ISBN
            // 
            this.TB_ISBN.Location = new System.Drawing.Point(23, 143);
            this.TB_ISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_ISBN.Name = "TB_ISBN";
            this.TB_ISBN.Size = new System.Drawing.Size(233, 25);
            this.TB_ISBN.TabIndex = 6;
            this.TB_ISBN.Leave += new System.EventHandler(this.TB_ISBN_Leave);
            // 
            // LB_CantidadLibros
            // 
            this.LB_CantidadLibros.AutoSize = true;
            this.LB_CantidadLibros.Location = new System.Drawing.Point(19, 75);
            this.LB_CantidadLibros.Name = "LB_CantidadLibros";
            this.LB_CantidadLibros.Size = new System.Drawing.Size(109, 18);
            this.LB_CantidadLibros.TabIndex = 3;
            this.LB_CantidadLibros.Text = "Cantidad Libros";
            // 
            // TB_CantLibros
            // 
            this.TB_CantLibros.Location = new System.Drawing.Point(23, 94);
            this.TB_CantLibros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_CantLibros.Name = "TB_CantLibros";
            this.TB_CantLibros.Size = new System.Drawing.Size(233, 25);
            this.TB_CantLibros.TabIndex = 4;
            this.TB_CantLibros.Leave += new System.EventHandler(this.TB_CantLibros_Leave);
            // 
            // LB_NombreLibro
            // 
            this.LB_NombreLibro.AutoSize = true;
            this.LB_NombreLibro.Location = new System.Drawing.Point(19, 27);
            this.LB_NombreLibro.Name = "LB_NombreLibro";
            this.LB_NombreLibro.Size = new System.Drawing.Size(99, 18);
            this.LB_NombreLibro.TabIndex = 2;
            this.LB_NombreLibro.Text = "Nombre Libro";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(23, 47);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(233, 25);
            this.TB_Name.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(328, 12);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(354, 315);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Panel_Grf
            // 
            this.Panel_Grf.Location = new System.Drawing.Point(704, 12);
            this.Panel_Grf.Name = "Panel_Grf";
            this.Panel_Grf.Size = new System.Drawing.Size(391, 325);
            this.Panel_Grf.TabIndex = 3;
            // 
            // CB_Idioma
            // 
            this.CB_Idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Idioma.FormattingEnabled = true;
            this.CB_Idioma.Items.AddRange(new object[] {
            "Español",
            "Inglés",
            "Francés"});
            this.CB_Idioma.Location = new System.Drawing.Point(787, 471);
            this.CB_Idioma.Name = "CB_Idioma";
            this.CB_Idioma.Size = new System.Drawing.Size(121, 26);
            this.CB_Idioma.TabIndex = 4;
            this.CB_Idioma.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Lbl_Elige_Idioma
            // 
            this.Lbl_Elige_Idioma.AutoSize = true;
            this.Lbl_Elige_Idioma.Location = new System.Drawing.Point(784, 450);
            this.Lbl_Elige_Idioma.Name = "Lbl_Elige_Idioma";
            this.Lbl_Elige_Idioma.Size = new System.Drawing.Size(109, 18);
            this.Lbl_Elige_Idioma.TabIndex = 9;
            this.Lbl_Elige_Idioma.Text = "Elige un idioma";
            // 
            // BTN_Config
            // 
            this.BTN_Config.Location = new System.Drawing.Point(914, 472);
            this.BTN_Config.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_Config.Name = "BTN_Config";
            this.BTN_Config.Size = new System.Drawing.Size(87, 26);
            this.BTN_Config.TabIndex = 9;
            this.BTN_Config.Text = "Color";
            this.BTN_Config.UseVisualStyleBackColor = true;
            this.BTN_Config.Click += new System.EventHandler(this.BTN_Config_Click);
            // 
            // Btn_Cargar
            // 
            this.Btn_Cargar.Location = new System.Drawing.Point(33, 344);
            this.Btn_Cargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Cargar.Name = "Btn_Cargar";
            this.Btn_Cargar.Size = new System.Drawing.Size(233, 26);
            this.Btn_Cargar.TabIndex = 9;
            this.Btn_Cargar.Text = "Cargar";
            this.Btn_Cargar.UseVisualStyleBackColor = true;
            this.Btn_Cargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1107, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generosToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "agregar";
            // 
            // generosToolStripMenuItem
            // 
            this.generosToolStripMenuItem.Name = "generosToolStripMenuItem";
            this.generosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generosToolStripMenuItem.Text = "generos";
            this.generosToolStripMenuItem.Click += new System.EventHandler(this.generosToolStripMenuItem_Click);
            // 
            // f_principal
            // 
            this.AcceptButton = this.BTN_Calcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 502);
            this.Controls.Add(this.Btn_Cargar);
            this.Controls.Add(this.BTN_Config);
            this.Controls.Add(this.Lbl_Elige_Idioma);
            this.Controls.Add(this.CB_Idioma);
            this.Controls.Add(this.Panel_Grf);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.GB_IngresarDatos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "f_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mike Puentes";
            this.Load += new System.EventHandler(this.f_principal_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.GB_IngresarDatos, 0);
            this.Controls.SetChildIndex(this.Btn_ayuda, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.Panel_Grf, 0);
            this.Controls.SetChildIndex(this.CB_Idioma, 0);
            this.Controls.SetChildIndex(this.Lbl_Elige_Idioma, 0);
            this.Controls.SetChildIndex(this.BTN_Config, 0);
            this.Controls.SetChildIndex(this.Btn_Cargar, 0);
            this.GB_IngresarDatos.ResumeLayout(false);
            this.GB_IngresarDatos.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cs_CustomGroupBox GB_IngresarDatos; // System.Windows.Forms.GroupBox GB_IngresarDatos;
        private System.Windows.Forms.Label LB_ISBN;
        private System.Windows.Forms.TextBox TB_ISBN;
        private System.Windows.Forms.Label LB_CantidadLibros;
        private System.Windows.Forms.TextBox TB_CantLibros;
        private System.Windows.Forms.Label LB_NombreLibro;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label LB_Editorial;
        private System.Windows.Forms.ComboBox CB_Editorial;
        private System.Windows.Forms.Button BTN_Calcular;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel Panel_Grf;
        private System.Windows.Forms.ComboBox CB_Idioma;
        private System.Windows.Forms.Label Lbl_Elige_Idioma;
        private System.Windows.Forms.Button BTN_Config;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button Btn_Cargar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generosToolStripMenuItem;
    }
}