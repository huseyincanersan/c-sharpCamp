using AdaApp.Models;
using AdaApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PolicyPage : ContentPage
    {
        public PolicyPage()
        {
            InitializeComponent();
        }

        public PolicyPage(USER u)
        {
            InitializeComponent();
            BindingContext = new PolicyPageViewModel(u);
        }
    }
}