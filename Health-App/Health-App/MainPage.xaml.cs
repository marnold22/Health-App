using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Health_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int passout=0;
        private void Passout_Increment(object sender, EventArgs e)
        {
            passout++;
            ((Button)sender).Text = $"You have passed out {passout} times.";
            //pcounter.Text += $"{passout}";
            
        }

        private void Passout_Decrement(object sender, EventArgs e)
        {
            passout--;
            ((Button)sender).Text = $"You have passed out {passout} times.";
            //pcounter.Text += $"{passout}";
        }
    }
}
