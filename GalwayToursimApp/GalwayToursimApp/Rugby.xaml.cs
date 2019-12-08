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
	public partial class Rugby : ContentPage
	{
        public Rugby()
        {
            InitializeComponent();
            var Image2 = new Image { Source = "Connacht.jpg" };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.connachtrugby.ie/matches/league-table/"));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.youtube.com/channel/UCgucukpMfuXvCtG9oELpN1Q"));
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://twitter.com/connachtrugby"));
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/ConnachtRugby/"));
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.connachtrugby.ie/"));
        }
    }
}