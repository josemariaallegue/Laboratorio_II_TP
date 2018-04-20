using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = LaCalculadora.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();

            //aplicacion de formatos a los textbox y comobox para hacer que la calculadora sea
            //mas agradable visualmente
            if (txtNumero1.Text == "")
            {
                txtNumero1.Text = "0";
            }
            if (txtNumero2.Text == "")
            {
                txtNumero2.Text = "0";
            }
            if (cmbOperador.Text != "+" && cmbOperador.Text != "-" && cmbOperador.Text != "/" && cmbOperador.Text != "*")
            {
                cmbOperador.Text = "+";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            lblResultado.Text = numero.BinarioDecimal(lblResultado.Text);
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero numero = new Numero();
            lblResultado.Text = numero.DecimalBinario(lblResultado.Text);
        }

        /// <summary>
        /// Limpia todos los textbox y combobox
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "";
        }

        /// <summary>
        /// Calcula el resultado a partir de los numeros y operadores ingresados
        /// </summary>
        /// <param name="numero1"> Primer numero a operar </param>
        /// <param name="numero2"> Segundo numero a operar </param>
        /// <param name="operador"> El string que determinar la operacion </param>
        /// <returns> El resultado de la operacion </returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double retorno;
            Calculadora calculadora = new Calculadora();
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            retorno = calculadora.Operar(num1,num2, operador);

            return retorno;
        }
    }
}
