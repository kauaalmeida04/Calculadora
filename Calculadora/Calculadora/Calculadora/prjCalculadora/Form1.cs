using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculadora KH = new Calculadora();

        bool EstadoIgual = false; // botão igual

        private void btn0_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            KH.SetVisor(btn0.Text);
            lbVisor.Text = KH.Visor;
        }

        private void TestarIgual(object sender, EventArgs e)
        {
            if (EstadoIgual == true)
            {
                btnCE_Click(sender, e);
                EstadoIgual = false;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            KH.SetVisor(btn1.Text);
            lbVisor.Text = KH.Visor;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            KH.SetVisor(btn2.Text);
            lbVisor.Text = KH.Visor;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            KH.SetVisor(btn3.Text);
            lbVisor.Text = KH.Visor;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            KH.SetVisor(btn4.Text);
            lbVisor.Text = KH.Visor;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            KH.SetVisor(btn5.Text);
            lbVisor.Text = KH.Visor;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            KH.SetVisor(btn6.Text);
            lbVisor.Text = KH.Visor;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            KH.SetVisor(btn7.Text);
            lbVisor.Text = KH.Visor;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            KH.SetVisor(btn8.Text);
            lbVisor.Text = KH.Visor;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TestarIgual(sender, e);
            KH.SetVisor(btn9.Text);
            lbVisor.Text = KH.Visor;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            KH = new Calculadora();
            lbVisor.Text = KH.Visor;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            KH.Visor = "0";
            lbVisor.Text = KH.Visor;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            KH.Op = "+";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            KH.Calcular();
            lbVisor.Text = KH.Visor;
            EstadoIgual = true;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            KH.Op = "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            KH.Op = "*";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            KH.Op = "/";
        }

        private void btnInverterSinal_Click(object sender, EventArgs e)
        {
            KH.InverterSinal();
            lbVisor.Text = KH.Visor;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            KH.RaizQuadrada();
            lbVisor.Text = KH.Visor;
            EstadoIgual = true;
        }

        private void btnFracao_Click(object sender, EventArgs e)
        {
            KH.Fracao();
            lbVisor.Text = KH.Visor;
            EstadoIgual = true;
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            KH.Quadrado();
            lbVisor.Text = KH.Visor;
            EstadoIgual = true;
        }

        private void btnPontoDecimal_Click(object sender, EventArgs e)
        {
            KH.Decimal();
            lbVisor.Text = KH.Visor;
            EstadoIgual = true;
        }

        private void btnBK_Click(object sender, EventArgs e)
        {
            KH.BackSpace();
            lbVisor.Text = KH.Visor;
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            KH.Porcentagem();
            lbVisor.Text = KH.Visor;
            EstadoIgual = true;
            return;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                TestarIgual(sender, e);
                KH.SetVisor(e.KeyChar.ToString());
                lbVisor.Text = KH.Visor;
                return;
            }
            if (e.KeyChar == '+') KH.Op = "+";
            if (e.KeyChar == '-') KH.Op = "-";
            if (e.KeyChar == '*') KH.Op = "*";
            if (e.KeyChar == '/') KH.Op = "/";
            if (e.KeyChar == '=')
            {
                btnCalcular_Click(sender, e);
            }
        }

        private void btSeno_Click_1(object sender, EventArgs e)
        {
            EstadoIgual = true;
            KH.Seno();
            lbVisor.Text = KH.Visor;
        }

        private void btCosseno_Click_1(object sender, EventArgs e)
        {
            EstadoIgual = true;
            KH.Cosseno();
            lbVisor.Text = KH.Visor;
        }

        private void btTangente_Click_1(object sender, EventArgs e)
        {
            EstadoIgual = true;
            KH.Tangente();
            lbVisor.Text = KH.Visor;
        }

        private void btnPI_Click_1(object sender, EventArgs e)
        {
            EstadoIgual = true;
            KH.PI();
            lbVisor.Text = KH.Visor;
        }

        private void btnE_Click_1(object sender, EventArgs e)
        {
            EstadoIgual = true;
            KH.Euler();
            lbVisor.Text = KH.Visor;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            KH.Logaritmo();
            lbVisor.Text = KH.Visor;
        }

    }
}