using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleRe.ViewModels;
using Xamarin.Forms;

namespace SampleRe
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            (this.BindingContext as MainPageViewModel).GetStudentsMarks();
        }
    }
}
