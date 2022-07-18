using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdaApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PolicyControl : ContentView
    {
        public static BindableProperty PolicyTipTextProperty = BindableProperty.Create(propertyName: "PolicyTipText", defaultValue: string.Empty,
          returnType: typeof(string), declaringType: typeof(PolicyControl), defaultBindingMode: BindingMode.TwoWay, propertyChanged: PolicyTipTextPropertyChanged);


        public static BindableProperty CompanyNameTextProperty = BindableProperty.Create(propertyName: "CompanyNameText", defaultValue: string.Empty,
            returnType: typeof(string), declaringType: typeof(PolicyControl), defaultBindingMode: BindingMode.TwoWay, propertyChanged: CompanyNameTextPropertyChanged);

        

        public string PolicyTipText
        {
            get { return GetValue(PolicyTipTextProperty).ToString(); }
            set { SetValue(PolicyTipTextProperty, value); }

        }
        
        public string CompanyNameText
        {
            get { return GetValue(CompanyNameTextProperty).ToString(); }
            set { SetValue(CompanyNameTextProperty, value); }

        }
        
        


       
       
        
        private static void PolicyTipTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {

            var control = (PolicyControl)bindable;
            if (newValue != null)
                control.labelPolicyTip.Text = newValue.ToString();

        }
       
        private static void CompanyNameTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {

            var control = (PolicyControl)bindable;
            if (newValue != null)
                control.labelCompanyName.Text = newValue.ToString();

        }
        public PolicyControl()
        {
            InitializeComponent();
        }
    }
}