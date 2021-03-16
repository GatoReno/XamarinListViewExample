using System;
using System.Collections.ObjectModel;
using ListViewExample.Models;

namespace ListViewExample.ViewModels
{
    public class MainViewModel
    {

        public ObservableCollection<Credit> Collection { get; set; }
        public MainViewModel()
        {

            Collection = new ObservableCollection<Credit>();
            LoadCollection();
        }

        public void LoadCollection()
        {
            Credit c1 = new Credit() {  Name="Credit card", Number="1234567" };
            Collection.Add(c1);

        }
    }
}
