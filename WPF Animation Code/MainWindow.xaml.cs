using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WPF_Animation_Code
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

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            var widthAnimation = new DoubleAnimation() { To = 130, Duration = TimeSpan.FromSeconds(0.2) };
            var heightAnimation = new DoubleAnimation() { To = 150, Duration = TimeSpan.FromSeconds(0.2) };
            var borderThickness = new ThicknessAnimation() { To = new Thickness(10), Duration = TimeSpan.FromSeconds(0.2)};
            var color = new ColorAnimation() { To = Colors.Coral, Duration = TimeSpan.FromSeconds(0.2)};

            button.BeginAnimation(Button.WidthProperty, widthAnimation);
            button.BeginAnimation(Button.HeightProperty, heightAnimation);
            button.BeginAnimation(Button.BorderThicknessProperty, borderThickness);

            button.Background = new SolidColorBrush(Colors.Coral); //have to assign a mutable SolidColorBrush
            button.Background.BeginAnimation(SolidColorBrush.ColorProperty, color);
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {

            var button = sender as Button;
            var widthAnimation = new DoubleAnimation() { To = 100, Duration = TimeSpan.FromSeconds(0.3) };
            var heightAnimation = new DoubleAnimation() { To = 120, Duration = TimeSpan.FromSeconds(0.3) };
            var borderThickness = new ThicknessAnimation() { To = new Thickness(3), Duration = TimeSpan.FromSeconds(0.2) };
            var color = new ColorAnimation() { To = Colors.White, Duration = TimeSpan.FromSeconds(0.2) };

            button.BeginAnimation(Button.WidthProperty, widthAnimation);
            button.BeginAnimation(Button.HeightProperty, heightAnimation);
            button.BeginAnimation(Button.BorderThicknessProperty, borderThickness);

            button.Background = new SolidColorBrush(Colors.White); //have to assign a mutable SolidColorBrush
            button.Background.BeginAnimation(SolidColorBrush.ColorProperty, color);
        }
    }
}
