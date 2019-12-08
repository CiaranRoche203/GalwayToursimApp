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
	public partial class Cinema : ContentPage
	{
        public Cinema()
        {
            InitializeComponent();
            var Image = new Image { Source = "Popcorn.jpg" };
            var Image1 = new Image { Source = "Movie.jpg" };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.imccinemas.ie/Whats-On/Galway"));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.eyecinema.ie/"));

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.omniplex.ie/cinema/galway"));
        }
    }
}