using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4,
        Modulo = 5,
        Potencia = 6
    }
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        bool numeroLeido = false;
        Operacion operador = Operacion.NoDefinida;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LeerNumero(string numero)
        {
            if (cajaResultado.Text == "0" && cajaResultado.Text != null)
            {
                cajaResultado.Text = numero;
            }
            else
            {
                cajaResultado.Text += numero;
            }
        }

        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)
            {
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.Division:
                    if (valor2 > 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    else
                    {
                        lblHistorial.Text = "No se puede dividir entre 0";
                        resultado = 0;
                    }
                    break;
                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case Operacion.Modulo:
                    resultado = valor1 % valor2;
                    break;
                case Operacion.Potencia:
                    resultado = Math.Pow(valor1, valor2);
                    break;
                default:
                    break;
            }
            return resultado;
        }
        private void btnCero_Click(object sender, EventArgs e)
        {
            if (cajaResultado.Text == "0")
            {
                return;
            }
            else
            {
                cajaResultado.Text += "0";
                numeroLeido = true;
            }

        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            LeerNumero("1");
            numeroLeido = true;

        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
            numeroLeido = true;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
            numeroLeido = true;
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
            numeroLeido = true;
        }


        private void btnCinco_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
            numeroLeido = true;
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
            numeroLeido = true;
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
            numeroLeido = true;
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
            numeroLeido = true;
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
            numeroLeido = true;
        }
        private void ObtenerValor(string operador)
        {
            valor1 = Convert.ToDouble(cajaResultado.Text);
            lblHistorial.Text = cajaResultado.Text + operador;
            cajaResultado.Text = "0";
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerValor("+");

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (valor2 == 0 && numeroLeido)
            {
                valor2 = Convert.ToDouble(cajaResultado.Text);
                lblHistorial.Text += valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                numeroLeido = false;
                cajaResultado.Text = Convert.ToString(resultado);
            }


        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor("-");
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerValor("x");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtenerValor("/");
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            operador = Operacion.Modulo;
            ObtenerValor("%");
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            operador = Operacion.Potencia;
            ObtenerValor("^");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblHistorial.Text = "";
            cajaResultado.Text = "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cajaResultado.Text.Length > 1)
            {
                string txtResultado = cajaResultado.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);
                if (txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    cajaResultado.Text = "0";
                }
                else
                {
                    cajaResultado.Text = txtResultado;
                }
            }
            else
            {
                cajaResultado.Text = "0";
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (cajaResultado.Text.Contains(","))
            {
                return;
            }
            else
            {
                cajaResultado.Text += ",";
            }

        }
    }
}
