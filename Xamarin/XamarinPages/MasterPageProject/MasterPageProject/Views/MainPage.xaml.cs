using MasterPageProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterPageProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profilImage.Source = ImageSource.FromUri(new Uri("https://i.tmgrup.com.tr/gq/original/17-06/22/user_male_circle_filled1600.png"));
            menuList.ItemsSource = getMenuList();
            IsPresented = false;
        }

        private void menuList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MastePageItem)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }

        public List<MastePageItem> getMenuList()
        {
            var list = new List<MastePageItem>();

            list.Add(new MastePageItem()
            {
                Title = "Cars",
                Icon = ImageSource.FromResource("MasterPageProject.Images.carIcon.png"),
                TargetType = typeof(CarsPage),
                Detail = "Cars Page"
            }); ;

            list.Add(new MastePageItem()
            {
                Title = "Contacts",
                Icon = ImageSource.FromResource("MasterPageProject.Images.contacts.png"),
                TargetType = typeof(ContactPage),
                Detail = "Contact Us"
            }); ;
            list.Add(new MastePageItem()
            {
                Title = "Settings",
                Icon = ImageSource.FromResource("MasterPageProject.Images.settings.png"),
                TargetType = typeof(SettingPage),
                Detail = "Settings Page"
            }); ;



            return list;

        }

    }
}