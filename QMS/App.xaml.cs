using Prism.DryIoc;
using Prism.Ioc;
using Prism.Regions;
using QMS.Services;
using QMS.ViewModels;
using QMS.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace QMS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App :  PrismApplication
    {
        protected override Window CreateShell() => null;

        protected override void OnInitialized()
        {

            //本地容器
            var container = ContainerLocator.Container;
            var shell = container.Resolve<object>("MainView");
            if (shell is Window view)
            {
                //更新prism的注册区域信息
                var regionManager = container.Resolve<IRegionManager>();
                RegionManager.SetRegionManager(view, regionManager);
                RegionManager.UpdateRegions();
                //初始化导航INavigationAware 接口做一个初始话操作
                if (view.DataContext is INavigationAware navigationAware)
                {
                    navigationAware.OnNavigatedTo(null);
                    App.Current.MainWindow = view;

                }
            }



            base.OnInitialized();
        }


        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

            containerRegistry.RegisterForNavigation<MainView, MainViewModel>();
            //containerRegistry.RegisterForNavigation<INavigationMenuService, NavigationMenuService>();
        }
    }

}
