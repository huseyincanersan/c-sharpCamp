using MessagingCenterProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MessagingCenterProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<Page1, Message>("Subscriber1","Page1Message",MessageFunction);
            
        }

        public void MessageFunction(Page1 sender,Message arg)
        {
            LabelSender.Text = sender.Title;
            LabelContent.Text = arg.Content;
            LabelTopic.Text = arg.Topic;

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}