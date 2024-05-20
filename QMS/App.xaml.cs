using Prism.Ioc;
using Prism.Unity;
using QMS.View;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace MyProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }

}
