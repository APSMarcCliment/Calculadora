using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora
{
    public partial class FormCalculadora : System.Web.UI.Page
    {
        private static int valor1;
        private static int valor2;
        private static int operacion;
        private string numero;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         protected void numberButtonClick9(object sender, EventArgs e)
        {
            numero = "9";
            Calculos.Text += numero;
            
        }
        protected void numberButtonClick8(object sender, EventArgs e)
        {
            Calculos.Text = String.Concat("8");
            numero = String.Concat("8");
        }
        protected void numberButtonClick7(object sender, EventArgs e)
        {
            Calculos.Text += 7;
        }
        protected void numberButtonClick6(object sender, EventArgs e)
        {
            Calculos.Text += 6;
        }
        protected void numberButtonClick5(object sender, EventArgs e)
        {
            Calculos.Text += 5;
        }
        protected void numberButtonClick4(object sender, EventArgs e)
        {
            Calculos.Text += 4;
        }
        protected void numberButtonClick3(object sender, EventArgs e)
        {
            Calculos.Text += 3;
        }
        protected void numberButtonClick2(object sender, EventArgs e)
        {
            Calculos.Text += 2;
            
        }
        protected void numberButtonClick1(object sender, EventArgs e)
        {
            Calculos.Text += 1;
            
        }
        protected void numberButtonClick0(object sender, EventArgs e)
        {
            Calculos.Text += 0;
            numero += 0;
            
        }
        protected void multButtonClick(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(Calculos.Text);
            Calculos.Text = "";
            operacionLabel.Text += valor1 + " * ";
            operacion = 3;
        }
        protected void divButtonClick(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(Calculos.Text);
            Calculos.Text = "";
            operacionLabel.Text += valor1 + " / ";
            operacion = 4;
        }
        protected void restaButtonClick(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(Calculos.Text);
            Calculos.Text = "";
            operacionLabel.Text += valor1 + " - ";
            operacion = 2;
        }
        protected void sumButtonClick(object sender, EventArgs e)
        {
            valor1 = Convert.ToInt32(Calculos.Text);
            Calculos.Text = "";
            operacionLabel.Text += valor1 +" + "; 
            operacion = 1;
            Calculos.Text = "" + operacion;
        }
        protected void equalsButtonClick(object sender, EventArgs e)
        {
            int result1 = valor1;
            valor2 = Convert.ToInt32(Calculos.Text);
            int result2 = valor2;
            int final = 0;
            operacionLabel.Text += result2 + " = ";
            switch (operacion)
            {
                case 1:
                    final = result1 + result2;
                    break;
                case 2:
                    result1 -= valor2;
                    break;
                case 3:
                    result1 = valor1 * valor2;
                    break;
                case 4:
                    result1 = valor1 / valor2;
                    break;
            }
            operacionLabel.Text += final;
            Calculos.Text = result1.ToString();
        }
        protected void clearButtonClick(object sender, EventArgs e)
        {
            operacionLabel.Text = "";
            Calculos.Text = string.Empty;
        }
    }
}