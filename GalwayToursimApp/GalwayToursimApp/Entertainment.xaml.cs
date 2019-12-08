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
	public partial class Entertainment : ContentPage
	{
        public Entertainment()
        {
            InitializeComponent();
        }
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TopPicksEntertainment());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cinema());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sports());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.google.com/maps/search/entertainment+in+galway/@53.2782886,-9.0537908,12z/data=!3m1!4b1"));
        }
    }
}