using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RestFulProject.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public BaseViewModel()
        {

        }

        public virtual void OnPropertyChanged(string propertName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertName));
        }
    }
}
