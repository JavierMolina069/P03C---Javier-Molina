namespace P03___Javier_Molina
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
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblFarenheit = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.txtFarenheit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsius.Location = new System.Drawing.Point(289, 95);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(71, 25);
            this.lblCelsius.TabIndex = 0;
            this.lblCelsius.Text = "Celsius";
            // 
            // lblFarenheit
            // 
            this.lblFarenheit.AutoSize = true;
            this.lblFarenheit.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarenheit.Location = new System.Drawing.Point(273, 148);
            this.lblFarenheit.Name = "lblFarenheit";
            this.lblFarenheit.Size = new System.Drawing.Size(87, 25);
            this.lblFarenheit.TabIndex = 1;
            this.lblFarenheit.Text = "Farenheit";
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelvin.Location = new System.Drawing.Point(300, 193);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(60, 25);
            this.lblKelvin.TabIndex = 2;
            this.lblKelvin.Text = "Kelvin";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(132, 241);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(240, 41);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular las temperaturas";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(366, 95);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 4;
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(366, 193);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(100, 20);
            this.txtKelvin.TabIndex = 5;
            // 
            // txtFarenheit
            // 
            this.txtFarenheit.Location = new System.Drawing.Point(366, 148);
            this.txtFarenheit.Name = "txtFarenheit";
            this.txtFarenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFarenheit.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Temperaturas";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(406, 241);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(240, 41);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar el sistema";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFarenheit);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.lblFarenheit);
            this.Controls.Add(this.lblCelsius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblFarenheit;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.TextBox txtFarenheit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

