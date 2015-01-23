using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumericInput
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class NumberOnlyTextbox : UserControl
    {
        public NumberOnlyTextbox()
        {
            InitializeComponent();
        }

        // The dependency property definition.
        public static readonly DependencyPropertyKey IsANumberPropertyKey = DependencyProperty.RegisterReadOnly
            (
                "IsANumber", // Name of dependency property.
                typeof(bool), // Type of dependency property.
                typeof(NumberOnlyTextbox), // Type of the class who owns the dependency property.
                new FrameworkPropertyMetadata
                (
                    false
                )
            );



        public static readonly DependencyProperty IsANumberProperty = IsANumberPropertyKey.DependencyProperty;

        public bool IsANumber
        {
            get { return (bool)GetValue(IsANumberProperty); }
            private set { SetValue(IsANumberProperty, value); }
        }


        public static readonly DependencyProperty UserInputProperty =
        DependencyProperty.Register(
        "UserInput",
        typeof(string),
        typeof(NumberOnlyTextbox),
        new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
        );

        public string ItemName
        {
            get { return (string)GetValue(UserInputProperty); }
            set { SetValue(UserInputProperty, value); }
        }


    }
}
