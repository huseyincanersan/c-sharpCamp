using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CarosuelPage.Models
{
    public class Car
    {
        string brand;
        string model;
        string details;
        string year;
        ImageSource imgSource;

        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public string Details { get => details; set => details = value; }
        public string Year { get => year; set => year = value; }
        public ImageSource ImgSource { get => imgSource; set => imgSource = value; }
    }
}
