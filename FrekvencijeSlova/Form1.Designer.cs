namespace FrekvencijeSlova
{
    partial class FrmFrekvencije
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
            this.txtBoxUnos = new System.Windows.Forms.TextBox();
            this.txtBoxIspis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxUnos
            // 
            this.txtBoxUnos.Location = new System.Drawing.Point(12, 12);
            this.txtBoxUnos.Multiline = true;
            this.txtBoxUnos.Name = "txtBoxUnos";
            this.txtBoxUnos.Size = new System.Drawing.Size(647, 426);
            this.txtBoxUnos.TabIndex = 0;
            this.txtBoxUnos.TextChanged += new System.EventHandler(this.txtBoxUnos_TextChanged);
            // 
            // txtBoxIspis
            // 
            this.txtBoxIspis.Location = new System.Drawing.Point(665, 12);
            this.txtBoxIspis.Multiline = true;
            this.txtBoxIspis.Name = "txtBoxIspis";
            this.txtBoxIspis.Size = new System.Drawing.Size(123, 426);
            this.txtBoxIspis.TabIndex = 1;
            // 
            // FrmFrekvencije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxIspis);
            this.Controls.Add(this.txtBoxUnos);
            this.Name = "FrmFrekvencije";
            this.Text = "Frekvencije slova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUnos;
        private System.Windows.Forms.TextBox txtBoxIspis;
    }
}

