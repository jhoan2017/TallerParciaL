using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ParcialTaller
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
        }
            
        private void ButtonSignUp(object sender, EventArgs e)
        { 
                //await DisplayAlert("Mensaje", "Mensaje de BIENENIDA", "Aceptar");
                //lblverificar.Text="Su usuario es: "+txtuser.Text+" pass: "+txtpass.Text;
        }
        private   async void ButtonRegistro(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new Page2());
                //await DisplayAlert("Sistema", "Formulario de Registro", "Aceptar");
            }
        private async void ButtonOlvide(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPass());
        }
        private async void ButtonRegistrar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registrar());
        }
    }
    }
