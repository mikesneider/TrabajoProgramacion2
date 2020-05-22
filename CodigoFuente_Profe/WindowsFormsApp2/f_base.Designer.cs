namespace WindowsFormsApp2
{
    partial class f_base
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
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.Location = new System.Drawing.Point(426, 186);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(112, 32);
            this.Btn_ayuda.TabIndex = 0;
            this.Btn_ayuda.Text = "ayuda";
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.button1_Click);
            // 
            // f_base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 228);
            this.Controls.Add(this.Btn_ayuda);
            this.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "f_base";
            this.Text = "f_base";
            this.Load += new System.EventHandler(this.f_base_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Btn_ayuda;
    }
}