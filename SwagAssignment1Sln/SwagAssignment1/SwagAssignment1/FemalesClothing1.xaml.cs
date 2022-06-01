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
    public partial class FemalesClothing1 : ContentPage
    {
        public FemalesClothing1()
        {
            InitializeComponent();
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
           Image pic =  sender as Image;

            if (pic != null)
            {
                
                var source = pic.Source as FileImageSource;

                string sku = string.Empty;

                if (source.File.ToLower() == "dotnetwoman1")
                    sku = "SKU0001";
                else
                if (source.File.ToLower() == "dotnetwoman2")
                    sku = "SKU0002";

                Navigation.PushAsync(new CaptureOrderingDataPage1(sku,source.File));

            }

            if (pic != null)
            {
                
                var source = pic.Source as FileImageSource;

                string sku = string.Empty;

                if (source.File.ToLower() == "dotnetwoman3")
                    sku = "SKU0003";
                else
                if (source.File.ToLower() == "dotnetwoman4")
                    sku = "SKU0004";

                Navigation.PushAsync(new CaptureOrderingDataPage1(sku, source.File));
            }
            if (pic != null)
            {
                
                var source = pic.Source as FileImageSource;

                string sku = string.Empty;

                if (source.File.ToLower() == "dotnetwoman5")
                    sku = "SKU0005";
                else
                if (source.File.ToLower() == "dotnetwoman7")
                    sku = "SKU0007";

                

            }
        }
    }
}