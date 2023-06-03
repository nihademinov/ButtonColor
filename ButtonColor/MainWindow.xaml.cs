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

namespace ButtonColor
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

        

        private void Click_button(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            
            var color1 = Random.Shared.Next(0, 255);
            var color2 = Random.Shared.Next(0, 255);
            var color3 = Random.Shared.Next(0, 255);
            button.Background = new SolidColorBrush()
            { Color = Color.FromRgb((byte)color1, (byte)color2, (byte)color3) };
        }

        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button button = (Button)sender;
           
            string nameButton = button.Content.ToString();
            this.Title = nameButton;
            if (button.Parent is Panel parentPanel)
            {
                parentPanel.Children.Remove(button);
            }
            
        }
    }
}
