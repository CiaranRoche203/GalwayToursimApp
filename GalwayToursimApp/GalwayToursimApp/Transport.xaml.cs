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
	public partial class Transport : ContentPage
	{
        public Transport()
        {
            
            InitializeComponent();
          
        }
        

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.buseireann.ie/timetables/402-1536317273.pdf"));
        }



        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.buseireann.ie/timetables/404-1536325488.pdf"));
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.buseireann.ie/timetables/405-1536327672.pdf"));
        }


        private void Button_Clicked_6(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.buseireann.ie/timetables/407-1536330823.pdf"));
        }



        private void Button_Clicked_8(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.buseireann.ie/timetables/409-1536332909.pdf"));
        }


        private void Button_Clicked_12(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.buseireann.ie/"));
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.buseireann.ie/timetables/401-1536250364.pdf"));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.galwaytransport.info/p/home.html"));
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:091535353"));
        }

        private async void Button_Clicked_7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pictures());
        }
    }
}