using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace MVVMColorPalatte.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        int red, green, blue;
        Color color = Color.Black;
        public event PropertyChangedEventHandler PropertyChanged;

        public int Red { get => red; set {
                if (red!=value)
                {
                    red = value;
                    OnPropertyChanged("Red");
                    setNewColor();
                }
            } }
        public int Green { get => green; set {
                if (green != value)
                {
                    green = value;
                    OnPropertyChanged("Green");
                    setNewColor();
                }
            } }
        public int Blue { get => blue; set {
                if (blue != value)
                {
                    blue = value;
                    OnPropertyChanged("Blue");
                    setNewColor();
                }
            } }
        public Color Color { get => color; set {
                if (color != value)
                {
                    color = value;
                    OnPropertyChanged("Color");
                    setNewColor();
                }
            } }

        //yeni bir renk ureten fonksiyonumuz
        void setNewColor()
        {
            Color = Color.FromRgb(red, green, blue);    
            //255 saydamligi geri kalanlar ise renk degerlerini belirtir. 255 degerini 0 yaparsak tamamen saydam olacaktir.
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            //Bu fonksiyon xaml sayfasina ozelligin degistigini bildirir
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

       
    }
}
