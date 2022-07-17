using RestFulProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RestFulProject.ViewModels
{
    public class SignUpViewModel : BaseViewModel
    {
        string username;
        string password;
        string name;
        string surname;
        ICommand signUpCommand;

        public SignUpViewModel()
        {
            signUpCommand = new Command(signUpFunction);
        }

        public async void signUpFunction()
        {
            USER u = new USER();

            u.NAME = Name;
            u.PASSWORD = Password;
            u.SURNAME = Surname;
            u.USERNAME = Username;
            string status = await App.UserService.addUser(u);

            if(status != "0")
            {
               await App.Current.MainPage.DisplayAlert("Message", "KayitBasarili", "Ok");
                await App.Current.MainPage.Navigation.PopAsync();
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
        public string Name
        {
            get => name; set
            {
                if (name != value)
                {
                    name = value;
                }
            }
        }
        public string Surname
        {
            get => surname; set
            {
                if (surname != value)
                {
                    surname = value;
                }
            }
        }

        public ICommand SignUpCommand { get => signUpCommand; set => signUpCommand = value; }
    }
}
