using AdaApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AdaApp.ViewModels
{
    public class AddPolicyViewModel : BaseViewModel
    {
        string policyTip;
        string companyName;
        ICommand addCommand;

        public AddPolicyViewModel()
        {
            AddCommand = new Command(addFunction);
        }

        async void addFunction()
        {
            POLICY policy = new POLICY();
            policy.POLICYTIP= PolicyTip;
            policy.COMPANYNAME = CompanyName;
            string status = await App.PolicyService.addPolicy(policy);

            if (status!="0")
            {
                await App.Current.MainPage.DisplayAlert("Message", "Police Eklendi", "Ok");
                await App.Current.MainPage.Navigation.PopAsync();            }
        }

        public string PolicyTip { get => policyTip; set => policyTip = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public ICommand AddCommand { get => addCommand; set => addCommand = value; }
    }
}
