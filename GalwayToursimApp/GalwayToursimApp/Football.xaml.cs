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
	public partial class Football : ContentPage
	{
        public Football()
        {
            InitializeComponent();
            var Image = new Image { Source = "Galway.jpg" };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.sseairtricityleague.ie/competition/first-division/id-025K4DS1I8000003VUM100GLVVH56HPG-G#table"));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.youtube.com/channel/UCHiTwNLuIeQmGxHVMOmyDxA"));
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://twitter.com/GalwayUnitedFC?ref_src=twsrc%5Egoogle%7Ctwcamp%5Eserp%7Ctwgr%5Eauthor"));
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/GalwayUnitedFC/"));
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://galwayunitedfc.ie/"));
        }
    }
}