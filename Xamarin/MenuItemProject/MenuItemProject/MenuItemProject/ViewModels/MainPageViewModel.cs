using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using MenuItemProject.Models;
using MenuItemProject.Service;
using Xamarin.Forms;

namespace MenuItemProject.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        ObservableCollection<Car> carList;
        ICommand deleteCommand;

        public ObservableCollection<Car> CarList
        {
            get => carList; set
            {
                carList = value;
                OnPropertyChanged("CarList");
            }
        }

        public ICommand DeleteCommand { get => deleteCommand; set => deleteCommand = value; }

        public event PropertyChangedEventHandler PropertyChanged;


        public MainPageViewModel()
        {
            CarList = new ObservableCollection<Car>(ListCreator.getCars());
            DeleteCommand = new Command<Car>(deleteFunction);


        }

        public void deleteFunction(Car c)
        {
           ListCreator.CarList.Remove(c);
            CarList = new ObservableCollection<Car>(ListCreator.CarList);
            App.Current.MainPage.DisplayAlert("Oops","Arac Silindi"+c.Brand ,"Ok!!");
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }

}
