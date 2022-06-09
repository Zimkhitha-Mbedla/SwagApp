using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Swag_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwaggPage : ContentPage
    {
        public SwaggPage()
        {
            InitializeComponent();

            BindingContext = new SwagItem();

        }

        private void OnSaveClicked(object sender, EventArgs e)
        {

            var item = BindingContext as SwagItem;

            var database = SwagDatabase.Instance;

            database.SaveSwagItem(item);

        }

        private void OrderItemsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

     
    }
}