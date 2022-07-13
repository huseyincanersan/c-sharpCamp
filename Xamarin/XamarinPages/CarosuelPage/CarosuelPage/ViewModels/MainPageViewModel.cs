using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using CarosuelPage.Models;
using CarosuelPage.Services;
using System.ComponentModel;

namespace CarosuelPage.ViewModels
{



    public class MainPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Car> carlist;
        Car selectedItem;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Car> Carlist { get => carlist; set => carlist = value; }
        public Car SelectedItem
        {
            get => selectedItem; set
            {
                if (selectedItem != value)
                {
                    selectedItem = value;
                    OnPropertyChanged("SelectedItem");
                }
            }
        }

        public MainPageViewModel()
        {
            Carlist = ListCreator.getCars();
        }

        public virtual void OnPropertyChanged(string propertName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertName));
        }
    }
}
