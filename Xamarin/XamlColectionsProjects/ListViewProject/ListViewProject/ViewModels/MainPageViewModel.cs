using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using ListViewProject.Models;
using ListViewProject.Services;


namespace ListViewProject.ViewModels
{
    public class MainPageViewModel
    {
        private ObservableCollection<Car> carList;

        public ObservableCollection<Car> CarList { get => carList; set => carList = value; }

        public MainPageViewModel()
        {
            CarList = ListCreater.getCars();



        }
    }
}
