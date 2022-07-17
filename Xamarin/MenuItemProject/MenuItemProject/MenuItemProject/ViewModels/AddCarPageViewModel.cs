using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using MenuItemProject.Models;
using MenuItemProject.Service;
using System.Linq;

namespace MenuItemProject.ViewModels
{

    public class AddCarPageViewModel :INotifyPropertyChanged
    {
        string brand;
        string model;
        string year;
        string details;
        string imageUri;
        ImageSource imgSource;
        ICommand addCommand;

        public AddCarPageViewModel()
        {
            AddCommand = new Command(addFunction);
        }

        async void addFunction()
        {
            Car car = new Car();
            car.Id = ListCreator.CarList.Last().Id + 1;
            car.Brand = Brand;
            car.Model = Model;
            car.Year = Year;
            car.Details = Details;
            car.ImgSource = ImgSource;
            ListCreator.CarList.Add(car);

            await App.Current.MainPage.Navigation.PopAsync();
            MessagingCenter.Send<string, string>("MainPage", "AddMessage", "ok");
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

        public string Year
        {
            get => year; set
            {
                if (year != value)
                {
                    year = value;
                }
            }
        }


        public string Details
        {
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
        public ICommand AddCommand { get => addCommand; set => addCommand = value; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
