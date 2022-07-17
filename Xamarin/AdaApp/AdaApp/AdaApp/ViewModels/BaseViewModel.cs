using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AdaApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public BaseViewModel()
        {

        }

        public virtual void OnPropertyChanged(string porpertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(porpertyName));
        }
    }
}
