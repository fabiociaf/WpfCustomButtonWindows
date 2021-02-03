using ControlzEx.Theming;
using MahApps.Metro.Controls;
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
using System.Windows.Shapes;

namespace WpfAppCustomButtonWindows
{
    /// <summary>
    /// Lógica interna para Window2.xaml
    /// </summary>
    public partial class Window2 : MetroWindow
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void ColorPicker_DropDownClosed(object sender, EventArgs e)
        {
            SetTheme();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetTheme();
        }

        private void SetTheme()
        {
            if (CpAccent.SelectedColor is Color accent)
            {
                var theme = new Theme("MyTheme",
                                      "MyTheme",
                                      CmbBaseTheme.SelectedItem as string ?? "Light",
                                      "Custom",
                                      accent,
                                      new SolidColorBrush(accent),
                                      true,
                                      false);

                ThemeManager.Current.ChangeTheme(App.Current, theme);
            }
        }
    }
}
