using System.Windows;

namespace NumericInput
{
    /// <summary>
    /// Interaction logic for NumberOnlyTextbox.xaml
    /// </summary>
    public partial class NumberOnlyTextbox
    {
        public NumberOnlyTextbox()
        {
            InitializeComponent();
        }

        public static readonly DependencyPropertyKey IsANumberPropertyKey = DependencyProperty.RegisterReadOnly
            (
                "IsANumber", 
                typeof(bool), 
                typeof(NumberOnlyTextbox), 
                new FrameworkPropertyMetadata
                (
                    false
                )
            );



        public static readonly DependencyProperty IsANumberProperty = IsANumberPropertyKey.DependencyProperty;

        public bool IsANumber
        {
            get { return (bool)GetValue(IsANumberProperty); }
        }
        
    }
}
