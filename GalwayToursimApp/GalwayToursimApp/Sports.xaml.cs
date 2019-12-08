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
	public partial class Sports : ContentPage
	{
        public Sports()
        {
            InitializeComponent();
            var Image = new Image { Source = "Galway.jpg" };
            var Image1 = new Image { Source = "GAA.jpg" };
            var Image2 = new Image { Source = "Connacht.jpg" };
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Rugby());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GAA());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Football());
        }
    }
}