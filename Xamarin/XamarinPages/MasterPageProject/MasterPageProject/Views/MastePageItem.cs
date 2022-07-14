using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MasterPageProject.Views
{
    public class MastePageItem
    {
        private string title;
        private string detail;
        private ImageSource ıcon;
        private Type targetType;

        public string Title { get => title; set => title = value; }
        public string Detail { get => detail; set => detail = value; }
        public ImageSource Icon { get => ıcon; set => ıcon = value; }
        public Type TargetType { get => targetType; set => targetType = value; }
    }
}
