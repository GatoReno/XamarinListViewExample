using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListViewExample.Models;
using ListViewExample.ViewModels;
using Xamarin.Forms;

namespace ListViewExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        void ListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var item = (Credit)e.Item;
             DisplayAlert($"{item.Name}", $"{item.Name} {item.Number}", "ok");
        }
    }
}
