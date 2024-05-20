using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMS.Models
{
    public class NavigationItem : BindableBase
    {

        public NavigationItem(string icon, string name, string pageName, ObservableCollection<NavigationItem> items = null)
        {
            Icon = icon;
            Name = name;
            PageName = pageName;
            Items = items;
        }
        private string _name;
        private string _icon;
        private string _pageName;
        private ObservableCollection<NavigationItem> _items = new ObservableCollection<NavigationItem>();

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public string PageName
        {
            get => _pageName;
            set => SetProperty(ref _pageName, value);
        }

        public string Icon
        {
            get => _icon;
            set => SetProperty(ref _icon, value);
        }

        public ObservableCollection<NavigationItem> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }




    }
}
