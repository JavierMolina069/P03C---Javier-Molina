using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03___Javier_Molina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // --- DISEÑO SUBLIME ---
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            this.Text = "Conversor de Temperaturas - Javier Molina";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Diseño de botones
            btnCalcular.BackColor = Color.MediumSlateBlue;
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.FlatAppearance.BorderSize = 0;

            btnLimpiar.BackColor = Color.IndianRed;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Si el usuario escribe en Celsius
                if (!string.IsNullOrEmpty(txtCelsius.Text))
                {
                    double celsius = Convert.ToDouble(txtCelsius.Text);
                    txtFarenheit.Text = (celsius * 9 / 5 + 32).ToString("0.00");
                    txtKelvin.Text = (celsius + 273.15).ToString("0.00");
                }
                // Si el usuario escribe en Fahrenheit
                else if (!string.IsNullOrEmpty(txtFarenheit.Text))
                {
                    double fahrenheit = Convert.ToDouble(txtFarenheit.Text);
                    double celsius = (fahrenheit - 32) * 5 / 9;
                    txtCelsius.Text = celsius.ToString("0.00");
                    txtKelvin.Text = (celsius + 273.15).ToString("0.00");
                }
                // Si el usuario escribe en Kelvin
                else if (!string.IsNullOrEmpty(txtKelvin.Text))
                {
                    double kelvin = Convert.ToDouble(txtKelvin.Text);
                    double celsius = kelvin - 273.15;
                    txtCelsius.Text = celsius.ToString("0.00");
                    txtFarenheit.Text = ((celsius * 9 / 5) + 32).ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Por favor ingresa un valor en una casilla.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Por favor ingresa un número válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCelsius.Clear();
            txtFarenheit.Clear();
            txtKelvin.Clear();
            txtCelsius.Focus();
        }
    }
}
