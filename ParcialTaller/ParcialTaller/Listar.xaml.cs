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
	public partial class Listar : ContentPage
	{
		public Listar ()
		{
			InitializeComponent ();
		}
        public async void btn1_click(object sender, EventArgs e)
        {
            //await DisplayAlert("Mensaje","Aqui estamos","OK")
            try
            {
                //System.Diagnostics.Debug.Writeline("Here we");
                UserManager manager = new UserManager();
                var res = await manager.getUsuarios();
                System.Diagnostics.Debug.WriteLine(res);

                if (res != null)
                {
                    lst.ItemsSource = res;
                }
            }
            catch (Exception e1) { }
        }
    }
}