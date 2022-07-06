using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TabuDemo.Views;

namespace TabuDemo
{
    public partial class MainPage : ContentPage
    {
        Random random = new Random();
        int hedefSayi = 0;
        int kalanHak = 10;
        public MainPage()
        {

            InitializeComponent();
            hedefSayi = random.Next(100);
            int entSayi = random.Next(100);

            if (entSayi > hedefSayi)
            {
                boxview.BackgroundColor = Color.OrangeRed;
            }
            else
                boxview.BackgroundColor = Color.CornflowerBlue;

            EntrySayi.Text = entSayi.ToString();
                    
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            int sayi = int.Parse(EntrySayi.Text);

            if (kalanHak==0)
            {
                await Navigation.PushAsync(new LosserPage());
            }

            if(sayi == hedefSayi)
            {
                await Navigation.PushAsync(new WinnerPage());
            }       

            if(sayi > hedefSayi)
            {
                boxview.BackgroundColor = Color.OrangeRed;
            }
            else
            {
                boxview.BackgroundColor = Color.CornflowerBlue;
            }

            kalanHak -= 1;

            lblHak.Text = kalanHak.ToString();
        }
    }
}
