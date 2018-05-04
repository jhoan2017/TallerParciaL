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
	public partial class ForgotPass : ContentPage
	{
		public ForgotPass ()
		{
			InitializeComponent ();

            
        }
        private async void ButtonConfirmacion(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new ResetPass());
            String email = enName.Text;

            await Navigation.PushAsync(new ResetPass(email));
        }
    }
}