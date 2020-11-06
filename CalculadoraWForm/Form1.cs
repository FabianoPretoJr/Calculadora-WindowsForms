using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWForm
{
    public partial class Form1 : Form
    {
        string imprimir, acum = "", esp = "", ope;
        double total;
        int cont = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            imprimir = imprimir + btnUm.Text;
            acum = acum + btnUm.Text;
            Imprimir_Click(imprimir);
            cont = 1;
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            imprimir = imprimir + btnDois.Text;
            acum = acum + btnDois.Text;
            Imprimir_Click(imprimir);
            cont = 1;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            imprimir = imprimir + btnTres.Text;
            acum = acum + btnTres.Text;
            Imprimir_Click(imprimir);
            cont = 1;
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            imprimir = imprimir + btnQuatro.Text;
            acum = acum + btnQuatro.Text;
            Imprimir_Click(imprimir);
            cont = 1;
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            imprimir = imprimir + btnCinco.Text;
            acum = acum + btnCinco.Text;
            Imprimir_Click(imprimir);
            cont = 1;
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            imprimir = imprimir + btnSeis.Text;
            acum = acum + btnSeis.Text;
            Imprimir_Click(imprimir);
            cont = 1;
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            imprimir = imprimir + btnSete.Text;
            acum = acum + btnSete.Text;
            Imprimir_Click(imprimir);
            cont = 1;
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            imprimir = imprimir + btnOito.Text;
            acum = acum + btnOito.Text;
            Imprimir_Click(imprimir);
            cont = 1;
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            imprimir = imprimir + btnNove.Text;
            acum = acum + btnNove.Text;
            Imprimir_Click(imprimir);
            cont = 1;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            imprimir = imprimir + btnZero.Text;
            acum = acum + btnZero.Text;
            Imprimir_Click(imprimir);
            cont = 1;
        }

        private void Imprimir_Click(string imprimir)
        {
            txtResultado.Text = imprimir;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (cont != 0)
            {
                imprimir = imprimir + btnVirgula.Text;
                acum = acum + btnVirgula.Text;
                Imprimir_Click(imprimir);
                cont = 0;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            imprimir = "";
            acum = "";
            esp = "";
            total = 0;
            Imprimir_Click(imprimir);
            cont = 0;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (acum != "")
            {
                imprimir = imprimir + btnDivisao.Text;
                Imprimir_Click(imprimir);
                if (esp == "")
                {
                    esp = acum;
                }
                acum = "";
                ope = "/";
                cont = 0;
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (acum != "")
            {
                imprimir = imprimir + btnMultiplicacao.Text;
                Imprimir_Click(imprimir);
                if (esp == "")
                {
                    esp = acum;
                }
                acum = "";
                ope = "*";
                cont = 0;
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (acum != "")
            {
                imprimir = imprimir + btnSubtracao.Text;
                Imprimir_Click(imprimir);
                if (esp == "")
                {
                    esp = acum;
                }
                acum = "";
                ope = "-";
                cont = 0;
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (acum != "")
            {
                imprimir = imprimir + btnSoma.Text;
                Imprimir_Click(imprimir);
                if (esp == "")
                {
                    esp = acum;
                }
                acum = "";
                ope = "+";
                cont = 0;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch(ope)
            {
                case "+":
                    total = Convert.ToDouble(esp) + Convert.ToDouble(acum);
                    esp = total.ToString();
                    Imprimir_Click(esp);
                    ope = "";
                    imprimir = esp;
                    break;
                case "-":
                    total = Convert.ToDouble(esp) - Convert.ToDouble(acum);
                    esp = total.ToString();
                    Imprimir_Click(esp);
                    ope = "";
                    imprimir = esp;
                    break;
                case "*":
                    total = Convert.ToDouble(esp) * Convert.ToDouble(acum);
                    esp = total.ToString();
                    Imprimir_Click(esp);
                    ope = "";
                    imprimir = esp;
                    break;
                case "/":
                    total = Convert.ToDouble(esp) / Convert.ToDouble(acum);
                    esp = total.ToString();
                    Imprimir_Click(esp);
                    ope = "";
                    imprimir = esp;
                    break;
            }
            cont = 0;
        }
    }
}
