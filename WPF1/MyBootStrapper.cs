using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
