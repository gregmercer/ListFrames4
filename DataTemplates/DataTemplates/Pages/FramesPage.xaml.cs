using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DataTemplates.Pages
{
    public partial class FramesPage : ContentPage
    {
        public FramesPage()
        {
            Title = "Frames";
            Icon = "csharp.png";

            InitializeComponent();

            BindingContext = App.RoomsViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            App.RoomsViewModel.GetRoomsCommand.Execute(null);
        }
    }
}
