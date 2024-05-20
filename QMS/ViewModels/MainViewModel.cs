using Prism.Regions;
using QMS.Core;
using QMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Xps;

namespace QMS.ViewModels
{
    public class MainViewModel: NavigationViewModel
    {
        public MainViewModel(INavigationMenuService navigationService)
        {
            NavigationService = navigationService;
        }

        public INavigationMenuService NavigationService { get; }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            NavigationService.InitMenus();
            base.OnNavigatedTo(navigationContext);
        }
    
    }
}
