using System;
using System.Collections.Generic;
using Tabbed_Xamarin.Form.ViewModel;
using Xamarin.Forms;

namespace Tabbed_Xamarin.Form.View
{
    public partial class AnimalPage : ContentPage
    {
        public AnimalPage()
        {
            InitializeComponent();
            BindingContext = new AnimalViewModel();
        }
    }
}
