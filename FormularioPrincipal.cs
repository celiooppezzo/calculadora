using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculadora
{
    public partial class FormularioPrincipal : Form
    {
        private byte i = 0; // Controla se o ponto flutuante já foi inserido no número
        cl_operacoes operacoes = new cl_operacoes();

        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            txtX.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtX.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtX.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtX.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtX.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtX.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtX.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtX.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtX.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtX.Text += "0";
        }

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            if(this.i == 0)
            {
                txtX.Text += ",";
                this.i = 1;
            }
       
        }  
        
        //=================Realiza a transposição do valor em txtX para txtY
        private void btnEnter_Click(object sender, EventArgs e)
        {
            txtResposta.Text = "";
            txtY.Text = txtX.Text;
            txtX.Text = "";
            this.i = 0;
        }
         //================Realiza a adição dos valores
        private void btnAdicao_Click(object sender, EventArgs e)
        {
            //=== Verifica se há indicação de potência de 10 =====criar uma classe para isso
            txtX.Text.IndexOf("E", 0, txtX.Text.Length); 

            double x = Convert.ToDouble(Convert.ToDecimal(txtX.Text));
            double y = Convert.ToDouble(Convert.ToDecimal(txtY.Text));
            MessageBox.Show("Valor de x = " + x.ToString());
            operacoes.X = x;
            operacoes.Y = y;
            operacoes.somar();
            txtResposta.Text = Convert.ToString(operacoes.Resposta);
            this.i = 0;
            txtX.Text = "";
            txtY.Text = "";
            
            
        }
      
    }
}
