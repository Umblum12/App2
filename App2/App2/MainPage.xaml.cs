using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(altura.Text) && !string.IsNullOrEmpty(peso.Text)) {
            var Altura = double.Parse(altura.Text);
            var Peso = double.Parse(peso.Text);
            var imc = Peso / (Altura * Altura);

            IMC.Text = imc.ToString();
            string resultado = "";
            if (imc > 0.0016 && imc < 0.00185)
            {
                resultado = " Tienes bajo peso ";
            }
            else if (imc > 0.00185 && imc < 0.00249)
            {
                resultado = " Tu peso es normal ";
            }
            else if (imc > 0.0025 && imc < 0.00299)
            {
                resultado = " Tienes sobre peso ";
            }
            else if (imc > 0.00299)
            {
                resultado = " Tienes obesidad , cuidate ! ";
            }
            DisplayAlert(" Resultado : ", resultado, " Ok ");
            }
            else{
                DisplayAlert("Datos erroneos", "Por favor, llena toda la informacion", "Quitar");
            }
        }
    }
}
