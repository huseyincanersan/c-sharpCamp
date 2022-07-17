using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RestFulProject.Views;
using RestFulProject.Services;

namespace RestFulProject
{
    public partial class App : Application
    {
        public static UserRestService UserService { get; set; }

        public App()
        {
            InitializeComponent();

            UserService = new UserRestService();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
