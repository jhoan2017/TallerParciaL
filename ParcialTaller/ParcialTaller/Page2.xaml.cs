﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

namespace ParcialTaller
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : MasterDetailPage
	{
		public Page2 ()
		{
			InitializeComponent ();
            this.Master = new Master();
            this.Detail = new NavigationPage(new Detail());
		}
	}
}