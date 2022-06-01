using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwagAssignment1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KidsClothing1 : ContentPage
    {
        public KidsClothing1()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Image pic = sender as Image;

            if (pic != null)
            {

                var source = pic.Source as FileImageSource;

                string sku = string.Empty;

                if (source.File.ToLower() == "KidDotNet")
                    sku = "SKU0013";
                else
                if (source.File.ToLower() == "KidDotNet2")
                    sku = "SKU0014";

                Navigation.PushAsync(new CaptureOrderingDataPage1(sku, source.File));

            }

            if (pic != null)
            {
                //    if (pic.Source.)
                var source = pic.Source as FileImageSource;

                string sku = string.Empty;

                if (source.File.ToLower() == "KidDotNet3")
                    sku = "SKU0015";
                else
                if (source.File.ToLower() == "KidDotNet4")
                    sku = "SKU0016";

                Navigation.PushAsync(new CaptureOrderingDataPage1(sku, source.File));
            }
            if (pic != null)
            {

                var source = pic.Source as FileImageSource;

                string sku = string.Empty;

                if (source.File.ToLower() == "KidDotNet6")
                    sku = "SKU0017";
                else
                if (source.File.ToLower() == "KidDotNet5")
                    sku = "SKU0018";

            }
        }
    }
}