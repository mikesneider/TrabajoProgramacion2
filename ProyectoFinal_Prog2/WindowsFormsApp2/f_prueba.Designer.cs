namespace WindowsFormsApp2
{
    partial class f_prueba
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
            this.uC_graficador1 = new DLL_Graficador.UC_graficador();
            this.SuspendLayout();
            // 
            // uC_graficador1
            // 
            this.uC_graficador1.Location = new System.Drawing.Point(444, 12);
            this.uC_graficador1.Name = "uC_graficador1";
            this.uC_graficador1.Size = new System.Drawing.Size(344, 382);
            this.uC_graficador1.TabIndex = 0;
            // 
            // f_prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uC_graficador1);
            this.Name = "f_prueba";
            this.Text = "f_prueba";
            this.ResumeLayout(false);

        }

        #endregion

        private DLL_Graficador.UC_graficador uC_graficador1;
    }
}