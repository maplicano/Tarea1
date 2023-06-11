using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Suma(object sender, EventArgs e)
        {
            var n1 = double.Parse(numero1.Text);
            var n2 = double.Parse(numero2.Text);
            double suma = n1 + n2;

          await Navigation.PushAsync(new Views.PageTwo(suma));
        }

        private async void Resta(object sender, EventArgs e)
        {
            var n1 = double.Parse(numero1.Text);
            var n2 = double.Parse(numero2.Text);
            var resta = n1 - n2;

            await Navigation.PushAsync(new Views.PageTwo(resta));
        }

        private async void Multi(object sender, EventArgs e)
        {
            var n1 = double.Parse(numero1.Text);
            var n2 = double.Parse(numero2.Text);
            var multi = n1 * n2;

            await Navigation.PushAsync(new Views.PageTwo(multi));
        }

        private async void Divi(object sender, EventArgs e)
        {
            var n1 = double.Parse(numero1.Text);
            var n2 = double.Parse(numero2.Text);

            if (n2 != 0)
            {
                var div = n1 / n2;
                await Navigation.PushAsync(new Views.PageTwo(div));
            }
            else
            {
                Resultado.Text = "No se puede realizar la división";
            }
        }

        //fin de funciones
    }
}
