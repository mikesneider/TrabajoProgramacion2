namespace WindowsFormsApp2
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTN_Ingresar = new System.Windows.Forms.Button();
            this.CB_Editorial = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.TB_Raiz = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GB_IngresarDatos = new System.Windows.Forms.GroupBox();
            this.BTN_Importar = new System.Windows.Forms.Button();
            this.LB_Editorial = new System.Windows.Forms.Label();
            this.LB_ISBN = new System.Windows.Forms.Label();
            this.LB_CantidadLibros = new System.Windows.Forms.Label();
            this.LB_NombreLibro = new System.Windows.Forms.Label();
            this.TB_CantLibros = new System.Windows.Forms.TextBox();
            this.TB_ISBN = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Idioma = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.GB_IngresarDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Ingresar
            // 
            this.BTN_Ingresar.Location = new System.Drawing.Point(0, 12);
            this.BTN_Ingresar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.BTN_Ingresar.Name = "BTN_Ingresar";
            this.BTN_Ingresar.Size = new System.Drawing.Size(0, 27);
            this.BTN_Ingresar.TabIndex = 0;
            this.BTN_Ingresar.Text = "algo";
            this.BTN_Ingresar.UseVisualStyleBackColor = true;
            this.BTN_Ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // CB_Editorial
            // 
            this.CB_Editorial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_Editorial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Editorial.FormattingEnabled = true;
            this.CB_Editorial.Items.AddRange(new object[] {
            "Libro",
            "PDF",
            "DVD"});
            this.CB_Editorial.Location = new System.Drawing.Point(0, 0);
            this.CB_Editorial.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.CB_Editorial.Name = "CB_Editorial";
            this.CB_Editorial.Size = new System.Drawing.Size(0, 24);
            this.CB_Editorial.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 407);
            this.panel1.TabIndex = 2;
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Calcular.Location = new System.Drawing.Point(0, 101);
            this.Btn_Calcular.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(0, 23);
            this.Btn_Calcular.TabIndex = 3;
            this.Btn_Calcular.Text = "Calcular";
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // TB_Raiz
            // 
            this.TB_Raiz.Location = new System.Drawing.Point(0, 38);
            this.TB_Raiz.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.TB_Raiz.Name = "TB_Raiz";
            this.TB_Raiz.Size = new System.Drawing.Size(0, 20);
            this.TB_Raiz.TabIndex = 4;
            this.TB_Raiz.Text = "942";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 12;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea1.Area3DStyle.Rotation = 12;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(0, 34);
            this.chart1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Name = "Libros";
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series1.SmartLabelStyle.IsOverlappedHidden = false;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(0, 403);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(0, 64);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "6";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(0, 63);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(0, 22);
            this.TB_Name.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // GB_IngresarDatos
            // 
            this.GB_IngresarDatos.Controls.Add(this.BTN_Importar);
            this.GB_IngresarDatos.Controls.Add(this.LB_Editorial);
            this.GB_IngresarDatos.Controls.Add(this.LB_ISBN);
            this.GB_IngresarDatos.Controls.Add(this.LB_CantidadLibros);
            this.GB_IngresarDatos.Controls.Add(this.LB_NombreLibro);
            this.GB_IngresarDatos.Controls.Add(this.TB_CantLibros);
            this.GB_IngresarDatos.Controls.Add(this.TB_ISBN);
            this.GB_IngresarDatos.Controls.Add(this.TB_Name);
            this.GB_IngresarDatos.Controls.Add(this.CB_Editorial);
            this.GB_IngresarDatos.Controls.Add(this.BTN_Ingresar);
            this.GB_IngresarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_IngresarDatos.Location = new System.Drawing.Point(0, 25);
            this.GB_IngresarDatos.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.GB_IngresarDatos.Name = "GB_IngresarDatos";
            this.GB_IngresarDatos.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.GB_IngresarDatos.Size = new System.Drawing.Size(0, 325);
            this.GB_IngresarDatos.TabIndex = 8;
            this.GB_IngresarDatos.TabStop = false;
            this.GB_IngresarDatos.Text = "Ingresar Datos";
            // 
            // BTN_Importar
            // 
            this.BTN_Importar.Location = new System.Drawing.Point(0, 272);
            this.BTN_Importar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.BTN_Importar.Name = "BTN_Importar";
            this.BTN_Importar.Size = new System.Drawing.Size(0, 27);
            this.BTN_Importar.TabIndex = 16;
            this.BTN_Importar.Text = "Importar datos";
            this.BTN_Importar.UseVisualStyleBackColor = true;
            // 
            // LB_Editorial
            // 
            this.LB_Editorial.AutoSize = true;
            this.LB_Editorial.Location = new System.Drawing.Point(0, 191);
            this.LB_Editorial.Margin = new System.Windows.Forms.Padding(0);
            this.LB_Editorial.Name = "LB_Editorial";
            this.LB_Editorial.Size = new System.Drawing.Size(57, 16);
            this.LB_Editorial.TabIndex = 15;
            this.LB_Editorial.Text = "Editorial";
            // 
            // LB_ISBN
            // 
            this.LB_ISBN.AutoSize = true;
            this.LB_ISBN.Location = new System.Drawing.Point(0, 143);
            this.LB_ISBN.Margin = new System.Windows.Forms.Padding(0);
            this.LB_ISBN.Name = "LB_ISBN";
            this.LB_ISBN.Size = new System.Drawing.Size(39, 16);
            this.LB_ISBN.TabIndex = 14;
            this.LB_ISBN.Text = "ISBN";
            // 
            // LB_CantidadLibros
            // 
            this.LB_CantidadLibros.AutoSize = true;
            this.LB_CantidadLibros.Location = new System.Drawing.Point(0, 93);
            this.LB_CantidadLibros.Margin = new System.Windows.Forms.Padding(0);
            this.LB_CantidadLibros.Name = "LB_CantidadLibros";
            this.LB_CantidadLibros.Size = new System.Drawing.Size(121, 16);
            this.LB_CantidadLibros.TabIndex = 13;
            this.LB_CantidadLibros.Text = "Cantidad de Libros";
            // 
            // LB_NombreLibro
            // 
            this.LB_NombreLibro.AutoSize = true;
            this.LB_NombreLibro.Location = new System.Drawing.Point(0, 45);
            this.LB_NombreLibro.Margin = new System.Windows.Forms.Padding(0);
            this.LB_NombreLibro.Name = "LB_NombreLibro";
            this.LB_NombreLibro.Size = new System.Drawing.Size(112, 16);
            this.LB_NombreLibro.TabIndex = 12;
            this.LB_NombreLibro.Text = "Nombre del Libro";
            // 
            // TB_CantLibros
            // 
            this.TB_CantLibros.Location = new System.Drawing.Point(0, 112);
            this.TB_CantLibros.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.TB_CantLibros.Name = "TB_CantLibros";
            this.TB_CantLibros.Size = new System.Drawing.Size(0, 22);
            this.TB_CantLibros.TabIndex = 2;
            this.TB_CantLibros.Leave += new System.EventHandler(this.TB_CantLibros_Leave);
            // 
            // TB_ISBN
            // 
            this.TB_ISBN.Location = new System.Drawing.Point(0, 162);
            this.TB_ISBN.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.TB_ISBN.Name = "TB_ISBN";
            this.TB_ISBN.Size = new System.Drawing.Size(0, 22);
            this.TB_ISBN.TabIndex = 3;
            this.TB_ISBN.TextChanged += new System.EventHandler(this.TB_ISBN_TextChanged);
            this.TB_ISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_ISBN_KeyPress);
            this.TB_ISBN.Leave += new System.EventHandler(this.TB_ISBN_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TB_Raiz);
            this.groupBox2.Controls.Add(this.Btn_Calcular);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(0, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.groupBox2.Size = new System.Drawing.Size(0, 137);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calcular Raiz de Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingresa Número";
            // 
            // CB_Idioma
            // 
            this.CB_Idioma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_Idioma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Idioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Idioma.FormattingEnabled = true;
            this.CB_Idioma.Items.AddRange(new object[] {
            "Español",
            "English"});
            this.CB_Idioma.Location = new System.Drawing.Point(0, 0);
            this.CB_Idioma.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.CB_Idioma.Name = "CB_Idioma";
            this.CB_Idioma.Size = new System.Drawing.Size(0, 21);
            this.CB_Idioma.TabIndex = 10;
            this.CB_Idioma.SelectedIndexChanged += new System.EventHandler(this.CB_Idioma_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-32768, 481);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Seleccionar Idioma";
            // 
            // Form1
            // 
            this.AcceptButton = this.BTN_Ingresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(831, 370);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CB_Idioma);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GB_IngresarDatos);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto - Michael Puentes (Profesor)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.GB_IngresarDatos.ResumeLayout(false);
            this.GB_IngresarDatos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ingresar;
        private System.Windows.Forms.ComboBox CB_Editorial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Calcular;
        private System.Windows.Forms.TextBox TB_Raiz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TB_Name;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox GB_IngresarDatos;
        private System.Windows.Forms.Label LB_Editorial;
        private System.Windows.Forms.Label LB_ISBN;
        private System.Windows.Forms.Label LB_CantidadLibros;
        private System.Windows.Forms.Label LB_NombreLibro;
        private System.Windows.Forms.TextBox TB_CantLibros;
        private System.Windows.Forms.TextBox TB_ISBN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button BTN_Importar;
        private System.Windows.Forms.ComboBox CB_Idioma;
        private System.Windows.Forms.Label label7;
    }
}

