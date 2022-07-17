using RestFulProject.Models;
using RestFulProject.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;


namespace RestFulProject.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        string username;
        string password;
        ImageSource imgSource;
        string loginStatus;
        ICommand loginCommand;
        ICommand signUpCommand;
        
        public MainPageViewModel()
        {
            ImgSource = ImageSource.FromResource("RestFulProject.Images.logo.jpg");
            LoginCommand = new Command(loginFunction);
            SignUpCommand = new Command(signUpFunction);
        }

        public async void signUpFunction()
        {
            await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new SignUp()));
        }

        public async void loginFunction()
        {
            USER U = await App.UserService.getUserByUserNameAndPassword(Username, Password);
            if (U==null)
            {
                LoginStatus = "Oturum Acma Basarisiz oldu";
                
            }
            else
            {
                LoginStatus = "Oturum Acma Basarili";
                
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
