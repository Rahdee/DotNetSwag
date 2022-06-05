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

        protected override void OnAppearing()
        {
            base.OnAppearing();

            OrderedItemsDataBase1 database = OrderedItemsDataBase1.Instance;
            listView.ItemsSource = database.GetItems();
        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderedItemsListPage1
            {
                BindingContext = new OrderedItems()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new OrderedItemsListPage1
                {
                    BindingContext = e.SelectedItem as OrderedItems
                });
            }

        }

        private async void ItemAdded_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderedItemsListPage1());
        }
        private async void ListView_ItemSelected(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderedItemsListPage1());
        }
       
    }
}