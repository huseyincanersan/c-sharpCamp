using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            image1.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("logo.jpg") : ImageSource.FromFile("Images/logo.jpg");
            image2.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("logo.jpg") : ImageSource.FromFile("Images/logo.jpg");
            image3.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("logo.jpg") : ImageSource.FromFile("Images/logo.jpg");
        }
    }
}
