using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigatioProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e) //async foksiyonu fonksiyonu arka planda calistirip telefonun tikanmasini onler
        {
            //await bu fonksiyonun async oldugunu temsil eder
            await Navigation.PushAsync(new Page2());
        }
    }
}
