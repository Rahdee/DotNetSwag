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
        public CaptureOrderingDataPage1()
        {
            InitializeComponent();
        }
        async void OnSaveClicked(object sender, EventArgs e)
        {
            var ordered = (OrderedItems)BindingContext;
            CaptureOrderingDataPage1 database = OrderedItemsDatabase.Instance;
            database.SaveItem(ordered);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var OrderedItemsDatabase = (OrderedItems)BindingContext;
            CaptureOrderingDataPage1 database = OrderedItemsDatabase.Instance;
            database.DeleteItem(ordered);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        
    }
}