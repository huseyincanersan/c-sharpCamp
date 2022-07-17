using MenuItemProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MenuItemProject.ViewModels
{
    public class EditPageModel : INotifyPropertyChanged
    {
        public Car SelectedCar { get; set; }
        string brand;
        string model;
        string year;
        string details;
        string imageUri;
        ImageSource imgSource;
        ICommand saveCommand;

        public EditPageModel()
        {

        }

        async void saveFunction()
        {
            SelectedCar.Brand=Brand;
            SelectedCar.Year=Year;
            SelectedCar.Model=Model;
            SelectedCar.Details = Details;
            SelectedCar.ImgSource=ImgSource;

            await App.Current.MainPage.Navigation.PopAsync();
            MessagingCenter.Send<string, string>("MainPage", "EditMessage", "ok");
        }

        
        public string Brand
        {
            get => brand; set
            {
                if (brand != value)
                {
                    brand = value;
                }
            }
        }

        public string Model
        {
            get => model; set
            {
                if (model != value)
                {
                    model = value;
                }
            }
        }

        public string Year { 
            get => year; set 
            {
                if (year!=value)
                {
                    year = value;
                }
            }
        }


        public string Details { 
            get => details; set 
            {
                if (details != value)
                {
                    details = value;
                }
            } 
        }

        public string ImageUri
        {
            get => imageUri; set
            {
                if (imageUri != value)
                {
                    imageUri = value;
                    ImgSource = ImageSource.FromUri(new Uri(ImageUri));
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
                    OnPropertyChanged("ImgSource");
                }
            }
        }

        public ICommand SaveCommand { get => saveCommand; set => saveCommand = value; }

        public EditPageModel(Car car)
        {
            SelectedCar = car;
            Brand = car.Brand;
            Model = car.Model;
            Year = car.Year;
            Details = car.Details;
            ImgSource = car.ImgSource;
            SaveCommand = new Command(saveFunction);

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
