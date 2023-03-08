using Prism.Ioc;
using Prism.Unity;
using System.Windows;

namespace WpfApp1
{
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}
