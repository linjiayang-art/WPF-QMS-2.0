using Prism.Mvvm;
using QMS.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMS.Services
{
   public class NavigationMenuService : BindableBase, INavigationMenuService
    {

        public NavigationMenuService()
        {
            Items = new ObservableCollection<NavigationItem>();
        }

        private ObservableCollection<NavigationItem> _items;

        public ObservableCollection<NavigationItem> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);

        }


        public void InitMenus()
        {

            Items.Clear();
            Items.Add(new NavigationItem("MainView", "首页", ""));

  
        }
    }
}
