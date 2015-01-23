using System.Windows;
using Caliburn.Micro;

namespace WPF1
{
        public class MyBootstrapper : BootstrapperBase
        {
            public MyBootstrapper()
            {
                Initialize();
            }

            protected override void OnStartup(object sender, StartupEventArgs e)
            {
                DisplayRootViewFor<MyDemoAppViewModel>();
            }
    }
}
