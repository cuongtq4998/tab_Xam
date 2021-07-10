using System;
using System.Collections.Generic;
using Tabbed_Xamarin.Form.ViewModel;
using Xamarin.Forms;

namespace Tabbed_Xamarin.Form.View
{
    public partial class AnimalTabPage : ContentPage
    {
        public AnimalTabPage(string continent)
        {

            InitializeComponent();

            // Do not forget to set title for the 
            // value you are using in tab 
            Title = continent;

            BindingContext = new AnimalSecondViewModel(continent);
        }
    }
}
