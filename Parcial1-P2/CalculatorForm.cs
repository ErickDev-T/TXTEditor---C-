using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_P2
{
    public enum Operacion
    {
        Nodefinida = 0,
        Suma = 1,
        Resta= 2,
        Multiplicacion= 3,
        Division = 4,
        modulo = 5
    }
    public partial class CalculatorForm : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        Operacion operacion = Operacion.Nodefinida;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void LeerNumero(string numero)
        {
            if (CajaResultado.Text == "0" && CajaResultado.Text != null)
            {
                CajaResultado.Text = numero;
            }
            else
            {
                CajaResultado.Text = CajaResultado.Text + numero;
            }
        }

        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operacion)
            {
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case Operacion.Division:

                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir por 0");
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case Operacion.modulo:
                    resultado = valor1 % valor2;
                    break;
            }
            return resultado;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LeerNumero("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void bnt3_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void bnt4_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void bnt7_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }
        private void ObtenerValor(string operador)
        {
            valor1 = Convert.ToDouble(CajaResultado.Text);
            ResultadoLABEL.Text = CajaResultado.Text + operador;
            CajaResultado.Text = "0";
        }

        private void bntSumar_Click(object sender, EventArgs e)
        {
            operacion = Operacion.Suma;
            ObtenerValor("+");


        }

        private void btnResulado_Click(object sender, EventArgs e)
        {
            if (valor2 == 0)
            {
                valor2 = Convert.ToDouble(CajaResultado.Text);
                ResultadoLABEL.Text += valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                CajaResultado.Text = Convert.ToString(resultado);


            }

        }

        private void bntRestar_Click(object sender, EventArgs e)
        {
            operacion = Operacion.Resta;
            ObtenerValor("-");
        }

        private void bntMuLtiplicar_Click(object sender, EventArgs e)
        {
            operacion = Operacion.Multiplicacion;
            ObtenerValor("x");
        }

        private void bntdividir_Click(object sender, EventArgs e)
        {
            operacion = Operacion.Division;
            ObtenerValor("/");
        }

        private void bntPorciento_Click(object sender, EventArgs e)
        {
            operacion = Operacion.modulo;
            ObtenerValor("%");
        }

        private void bntreset_Click(object sender, EventArgs e)
        {
            CajaResultado.Text = "0";
            ResultadoLABEL.Text = "";
        }

        private void bntborrar_Click(object sender, EventArgs e)
        {
            if (CajaResultado.Text.Length > 1)
            {
                CajaResultado.Text = CajaResultado.Text.Remove(CajaResultado.Text.Length - 1, 1);
                CajaResultado.Text = CajaResultado.Text;
            }
            else{
                CajaResultado.Text = "0";
            }



        }
    }
}
