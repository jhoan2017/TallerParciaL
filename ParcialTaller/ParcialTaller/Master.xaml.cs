using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParcialTaller
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : ContentPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private async void ButtonListar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Listar());
        }
        private async void ButtonAcercaDe(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Acerca());
        }


    }
}