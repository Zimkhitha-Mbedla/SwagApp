using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Swag_App
{
    public partial class MainPage : ContentPage
    {
        private List<SwagItem> _dotNetSwag;

        public List<SwagItem> DotNetSwag
        {
            get { return _dotNetSwag; }
            set { _dotNetSwag = value; }
        }



        public MainPage()
        {
            InitializeComponent();

            

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var database = SwagDatabase.Instance;

            DotNetSwag = database.GetSwagItems();

            BindingContext = this;

        }

        private void SwagAppListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}


