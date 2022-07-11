using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PickUpImageProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            image.Source = ImageSource.FromResource("PickUpImageProject.Images.logo.jpg");
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            MediaFile file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new PickMediaOptions {PhotoSize=PhotoSize.Full });
            if (file==null)
            {
                image.Source = ImageSource.FromResource("PickUpImageProject.Images.logo.jpg");
            }
            else
            {
                image.Source = ImageSource.FromStream(() =>
                {
                    
                    var stream = file.GetStream();
                    file.Dispose(); 
                    return stream;

                });
            }
        }
    }
}
