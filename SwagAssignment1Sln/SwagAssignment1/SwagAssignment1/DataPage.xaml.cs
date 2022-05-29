using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwagAssignment1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataPage : ContentPage
    {
        private static DataPage database;

        public static DataPage Database
        {
            get
            {
                if (database == null)
                {
                    database = new DataBase1(Path.Combine(Environment.GetFolderPath(Environment.
                        SpecialFolder.LocalApplicationData), "people.db3"));
                }
                return database;
            }
        }
        public DataPage()
        {
            InitializeComponent();
        }

        public static implicit operator DataPage(DataBase1 v)
        {
            throw new NotImplementedException();
        }
    }
}