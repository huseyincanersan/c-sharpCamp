using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MenuItemProject.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Details { get; set; }
        public string Year { get; set; }
        public ImageSource ImgSource { get; set; }

    }
}
