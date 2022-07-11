using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MvvmConnectData.Views;
using Xamarin.Forms;

namespace MvvmConnectData.ViewModels
{
    public class MainPageViewModel: INotifyPropertyChanged //cift tarafli baglama icin sart

    {
        private string userName;
        private string password;
        private string email;
        private Color bgColor;
        public event PropertyChangedEventHandler PropertyChanged;

        

        public string UserName { get => userName; set {
                if (userName!=value)
                {
                    userName = value;
                }
            } }
        public string Password { get => password; set {
                if (password!=value)
                {
                   
                    password = value;
                }
            } }
        public string Email { get => email; set {
                if (email!=value)
                {
                        email = value;

                    if (emailCheck(email))
                    {
                        BgColor = Color.LightGreen;
                    }
                    else
                    {
                        BgColor = Color.LightPink;
                    }
                }
            } }

        public Color BgColor { get => bgColor; set {
                if (bgColor!=value)
                {
                    bgColor = value;
                    OnpropertyChanged("BgColor");
                }
            } }

        protected virtual void OnpropertyChanged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool emailCheck(string email)
        {
            if (email.Contains("@") && email.Contains(".com"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
