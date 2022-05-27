using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwagAssignment1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SignupButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage1());
        }
    }
}
