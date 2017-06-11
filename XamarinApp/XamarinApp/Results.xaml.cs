using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinApp
{
    public partial class Results : ContentPage
    {
        public Results()
        {
            InitializeComponent();
        }

        private async void StatNav_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Statistics());
        }

        private async void TableNav_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Table());
        }
    }
}
