using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MasterPageProject.Models;
using MasterPageProject.Services;

namespace MasterPageProject.ViewModels
{
    public class CarsPageViewModel
    {
        private ObservableCollection<Car> carList;

        public CarsPageViewModel()
        {
            CarList = ListCreator.getCars();
        }

        public ObservableCollection<Car> CarList { get => carList; set => carList = value; }
    }
}
