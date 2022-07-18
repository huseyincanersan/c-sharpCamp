using AdaApp.Models;
using AdaApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AdaApp.ViewModels
{
    public class PolicyPageViewModel : BaseViewModel
    {

        private USER user;
        ICommand addPolicyCommand;
        ICommand removePolicyCommand;
        ObservableCollection<POLICY> policyList;

        public PolicyPageViewModel()
        {
            
        }

        public async void deletePolicyFunction(POLICY policy)
        {
            await App.PolicyService.deletePolicy(policy.POLICYID);
             initializeData();
            await App.Current.MainPage.DisplayAlert("Message", "Police Silindi", "Ok");
        }

        public async void addPolicyFunction()
        {
            await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new AddPolicyPage()));
        }

        

        public PolicyPageViewModel(USER u)
        {
            
            User = u;

            AddPolicyCommand = new Command(addPolicyFunction);

            initializeData();
            RemovePolicyCommand = new Command<POLICY>(deletePolicyFunction);

        }

        public async void initializeData()
        {
            List<POLICY> policies = await App.PolicyService.getPolicies();
            if (policies!=null)          
            PolicyList = new ObservableCollection<POLICY>(await App.PolicyService.getPolicies());
        }



        public USER User { get => user; set => user = value; }
        public ICommand AddPolicyCommand { get => addPolicyCommand; set => addPolicyCommand = value; }
        public ObservableCollection<POLICY> PolicyList
        {
            get => policyList; set
            {
                policyList = value;
                OnPropertyChanged("PolicyList");
            }
        }

        public ICommand RemovePolicyCommand { get => removePolicyCommand; set => removePolicyCommand = value; }
    }
}
