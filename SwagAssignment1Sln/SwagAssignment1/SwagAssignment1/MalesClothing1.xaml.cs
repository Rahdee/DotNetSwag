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
    public partial class MalesClothing1 : ContentPage
    {
        public MalesClothing1()
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

                if (source.File.ToLower() == "DotNetMan1")
                    sku = "SKU0006";
                else
                if (source.File.ToLower() == "DotNetMan2")
                    sku = "SKU0008";

                Navigation.PushAsync(new CaptureOrderingDataPage1(sku, source.File));

            }

            if (pic != null)
            {
                //    if (pic.Source.)
                var source = pic.Source as FileImageSource;

                string sku = string.Empty;

                if (source.File.ToLower() == "DotNET4")
                    sku = "SKU0009";
                else
                if (source.File.ToLower() == "DotNeT2")
                    sku = "SKU0010";

                Navigation.PushAsync(new CaptureOrderingDataPage1(sku, source.File));
            }
            if (pic != null)
            {
               
                var source = pic.Source as FileImageSource;

                string sku = string.Empty;

                if (source.File.ToLower() == "cnet1")
                    sku = "SKU0011";
                else
                if (source.File.ToLower() == "DotNetMan3")
                    sku = "SKU0012";




            }
        }
    }
}