using ListViewProject.Models;
using ListViewProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailedPage : ContentPage
    {
        public DetailedPage(Car car)
        {
            InitializeComponent();
            BindingContext = new DetailedPageViewModel(car);
        }
    }
}