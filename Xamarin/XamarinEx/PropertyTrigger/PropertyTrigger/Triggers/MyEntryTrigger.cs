using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace PropertyTrigger.Triggers
{
    public class MyEntryTrigger : TriggerAction<Entry>
    {
        Button mybutton;

        public Button Mybutton { get => mybutton; set => mybutton = value; }

        protected override void Invoke(Entry sender)
        {
            if (sender.Placeholder == "Password")
            {
                sender.Text = RemoveDigits(sender.Text);
                if (sender.Text.Length<8)
                {
                    mybutton.IsEnabled = false;
                }
                else
                {
                    mybutton.IsEnabled = true;
                }
            }
        }

        public static string RemoveDigits(string key)
        {
            return Regex.Replace(key,@"\d","");
        }
    }
}
