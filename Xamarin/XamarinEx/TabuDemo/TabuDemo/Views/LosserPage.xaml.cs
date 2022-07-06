using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabuDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LosserPage : ContentPage
    {
        public LosserPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            var mainpage = Navigation.NavigationStack.First();
            Navigation.RemovePage(mainpage);
            await Navigation.PushAsync(new MainPage());

        }
    }
}