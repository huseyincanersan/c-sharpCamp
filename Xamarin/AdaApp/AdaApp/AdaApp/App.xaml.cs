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
        private static PoliycRestServer policyService;

        public static UserRestService UserService { get => userService; set => userService = value; }
        public static PoliycRestServer PolicyService { get => policyService; set => policyService = value; }

        public App()
        {
            InitializeComponent();
            UserService = new UserRestService();
            PolicyService = new PoliycRestServer();
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
