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
    public partial class ResetPass : ContentPage
    {
        public ResetPass (string email)
        {
            InitializeComponent();
            lblCorreo.Text = email;

        }

        private async void ButtonLog(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MainPage());
        }
    }
}