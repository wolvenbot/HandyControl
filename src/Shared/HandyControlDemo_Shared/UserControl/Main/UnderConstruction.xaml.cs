using System.Windows;
using HandyControl.Tools;
namespace HandyControlDemo.UserControl
{
    public partial class UnderConstruction
    {
        public UnderConstruction()
        {
            InitializeComponent();
        }

        private void Button_Light(object sender, RoutedEventArgs e)
        {
            ThemeManager themeManager = ThemeManager.Current;
            themeManager.ApplicationTheme = ApplicationTheme.Light;
        }

        private void Button_Dark(object sender, RoutedEventArgs e)
        {
            ThemeManager themeManager = ThemeManager.Current;
            themeManager.ApplicationTheme = ApplicationTheme.Dark;
        }
    }
}
