using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListViewProject.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Car car = ((ListView)sender).SelectedItem as Car;

            if (car == null)
            {
                return;
            }
            else
            {
                await Navigation.PushAsync(new NavigationPage(new DetailedPage(car)));
            }
        }

        //async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    Car car = ((CollectionView)sender).SelectedItem as Car;
        //    if (car == null)
        //        return;
        //    await Navigation.PushAsync(new NavigationPage(new DetailedPage(car)));

        //}
    }
}