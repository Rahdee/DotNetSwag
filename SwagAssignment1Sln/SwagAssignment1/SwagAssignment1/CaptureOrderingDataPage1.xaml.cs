using OrderedItemsDatabase;
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
    public partial class CaptureOrderingDataPage1 : ContentPage
    {
        public string Sku { get; set; }
        public string Filename { get; set; }


        public CaptureOrderingDataPage1(string sku, string filename)
        {
            InitializeComponent();

            Sku = sku;
            Filename = filename;
        }
        async void OnSaveClicked(object sender, EventArgs e)
        {
            var ordered = (OrderedItems)BindingContext;
            OrderedItemsDataBase1 database = OrderedItemsDataBase1.Instance;
            database.SaveItem(ordered);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var order = (OrderedItems)BindingContext;
            OrderedItemsDataBase1 database = OrderedItemsDataBase1.Instance;
            database.DeleteItem(order);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        
    }
}