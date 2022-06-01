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
    public partial class OrderedItemsListPage1 : ContentPage
    {
        public OrderedItemsListPage1()
        {
            InitializeComponent();
        }

        private async void ItemAdded_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderedItemsListPage1());
        }
        private async void ListView_ItemSelected(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderedItemsListPage1());
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            OrderedItemsDataBase1 database = OrderedItemsDataBase1.Instance;
            listView.ItemsSource = database.GetItems();
        }

    }
}