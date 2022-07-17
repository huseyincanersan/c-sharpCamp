using AdaApp.Models;
using AdaApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AdaApp.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        string username;
        string password;
        string loginStatus;
        ImageSource imgSource;
        ICommand loginCommand;
        ICommand signUpCommand;

        public MainPageViewModel()
        {
            ImgSource = ImageSource.FromResource("AdaApp.Images.logo.jpg");
            LoginCommand = new Command(loginFunction);
            SignUpCommand = new Command(signUpFunction);
        }

        public async void signUpFunction()
        {
            await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new SignUp()));
        }

        public async void loginFunction()
        {
            USER u = await App.UserService.getUserByUsernameAndPassword(Username, Password);
            if (u==null)
            {
                LoginStatus = "Oturum Acma Basarisiz";
            }
            else
            {
                LoginStatus = "Oturum Acma Basarili"+u.NAME;
                 await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new PolicyPage()));
            }
        }


        public string Username
        {
            get => username; set
            {
                if (username != value)
                {
                    username = value;
                }
            }
        }
        public string Password
        {
            get => password; set
            {
                if (password != value)
                {
                    password = value;
                }
            }
        }
        public ImageSource ImgSource
        {
            get => imgSource; set
            {
                if (imgSource != value)
                {
                    imgSource = value;

                }
            }
        }

        public string LoginStatus
        {
            get => loginStatus; set
            {
                if (loginStatus != value)
                {
                    loginStatus = value;
                    OnPropertyChanged("LoginStatus");
                }
            }
        }

        public ICommand LoginCommand { get => loginCommand; set => loginCommand = value; }
        
        public ICommand SignUpCommand { get => signUpCommand; set => signUpCommand = value; }
    }
}
