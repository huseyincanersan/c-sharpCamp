using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AdaApp.Views;
using AdaApp.Services;

namespace AdaApp
{
    public partial class App : Application
    {
        private static UserRestService userService;

        public static UserRestService UserService { get => userService; set => userService = value; }

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
