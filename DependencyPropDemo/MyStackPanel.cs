using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DependencyPropDemo
{
    public class MyStackPanel : StackPanel
    {
        public MyStackPanel()
        {
            IsBackgroundPink = true;
        }

        public bool IsBackgroundPink
        {
            get { return (bool)GetValue(IsBackgroundPinkProperty); }
            set { SetValue(IsBackgroundPinkProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsBackgroundPinkProperty =
            DependencyProperty.Register("IsBackgroundPink", typeof(bool), typeof(MyStackPanel),
                new PropertyMetadata(false, OnIsBackgroundPinkChanged));

        private static object ValidateIsBackgroundPink(DependencyObject d, object basevalue)
        {
            var sender = (MyStackPanel) d;
            if (sender.IsBackgroundPink)
            {
                MessageBox.Show("Color is about to change to pink");
                return false;
            }
            else
            {
                MessageBox.Show("Color is about to change to orange");
                return true;
            }
        }

        private static void OnIsBackgroundPinkChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var sender = (MyStackPanel) d;
            if ((bool)e.NewValue)
            {
                sender.Background = Brushes.Pink;

            }
            else
            {
                sender.Background = Brushes.Orange;

            }
        }
    }
}
