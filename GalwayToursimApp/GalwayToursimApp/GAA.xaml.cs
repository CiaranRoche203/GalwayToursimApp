using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GalwayToursimApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GAA : ContentPage
	{
        public GAA()
        {
            InitializeComponent();
            var Image1 = new Image { Source = "GAA.jpg" };
        }




        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://twitter.com/Galway_GAA?ref_src=twsrc%5Egoogle%7Ctwcamp%5Eserp%7Ctwgr%5Eauthor"));
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/TribesmenGAA/"));
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.galwaygaa.ie/"));
        }
    }
}