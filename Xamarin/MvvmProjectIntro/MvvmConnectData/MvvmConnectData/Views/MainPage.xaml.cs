using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmConnectData.ViewModels;
using MvvmConnectData.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmConnectData.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();
        }
    }
}