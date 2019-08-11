using System.Windows;
using System.Windows.Controls;

namespace DependencyPropDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            var me = (CheckBox)sender;
            if (me.IsChecked == null) return;
            if ((bool)me.IsChecked)
            {
                StackPanel1.IsBackgroundPink = true;
            }
            else
            {
                StackPanel1.IsBackgroundPink = false;
            }
        }
    }
}
