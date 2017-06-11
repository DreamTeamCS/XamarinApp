using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
    public partial class Statistics : ContentPage
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private async void ResultsNav_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Results());
        }

        private async void TableNav_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Table());
        } 
    
}
}
