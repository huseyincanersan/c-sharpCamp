using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using MenuItemProject.Models;
using MenuItemProject.Service;
using MenuItemProject.Views;
using Xamarin.Forms;

namespace MenuItemProject.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        ObservableCollection<Car> carList;
        ICommand deleteCommand;
        ICommand editCommand;
        ICommand addCommand;

        public ObservableCollection<Car> CarList
        {
            get => carList; set
            {
                carList = value;
                OnPropertyChanged("CarList");
            }
        }

        public ICommand DeleteCommand { get => deleteCommand; set => deleteCommand = value; }
        public ICommand EditCommand { get => editCommand; set => editCommand = value; }
        public ICommand AddCommand { get => addCommand; set => addCommand = value; }

        public event PropertyChangedEventHandler PropertyChanged;


        public MainPageViewModel()
        {
            CarList = new ObservableCollection<Car>(ListCreator.getCars());
            DeleteCommand = new Command<Car>(deleteFunction);
            EditCommand = new Command<Car>(editFunction);
            AddCommand = new Command(addFunction);

            MessagingCenter.Subscribe<string, string>("MainPage", "EditMessage",MessageFuntion);
            MessagingCenter.Subscribe<string, string>("MainPage", "AddMessage",AddMessageFuntion);


        }

        async void MessageFuntion(string sender,string arg)
        {
            if (arg.Equals("ok"))
            {
                CarList = new ObservableCollection<Car>(ListCreator.CarList);
                await App.Current.MainPage.DisplayAlert("Message", "Kaydedildi", "Ok");
            }
        }

        async void AddMessageFuntion(string sender, string arg)
        {
            if (arg.Equals("ok"))
            {
                CarList = new ObservableCollection<Car>(ListCreator.CarList);
                await App.Current.MainPage.DisplayAlert("Message", "Kayit tamamlandi", "ok");
            }
        }

        public void deleteFunction(Car c)
        {
           ListCreator.CarList.Remove(c);
            CarList = new ObservableCollection<Car>(ListCreator.CarList);
            App.Current.MainPage.DisplayAlert("Oops","Arac Silindi"+c.Brand ,"Ok!!");
        }

        async void editFunction(Car c)
        {
            
            await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new EditPage(c)));
        }

        async void addFunction()
        {
            await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new AddCarPage()));
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }

}
