﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinEx.Services;

namespace XamarinEx
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Constants.Deger = 5;

            InitializeComponent();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Constants.Deger += 1;
        }
    }
}
