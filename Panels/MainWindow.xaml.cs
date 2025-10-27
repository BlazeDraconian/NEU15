using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Panels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int stackPanelButtonCount = 1;
        int WrapPanelButtonCount = 1;
        public MainWindow()
        {
            InitializeComponent();
            //myButton.Width = 200;
        }

        

        private void StackPanelButton_Click(Object sender, RoutedEventArgs e)
        {
            Button newButton = new Button()
            {
                Content = ++stackPanelButtonCount,
                HorizontalAlignment = HorizontalAlignment.Left,
                Width = 20,
                Margin = new Thickness(10, 10, 0, 0),
            };
            newButton.Click += StackPanelButton_Click;
            stackpanel.Children.Add(newButton);
        }

        private void WrapPanelButton_Click(Object sender, RoutedEventArgs e)
        {
            Button newButton = new Button()
            {
                Content = ++WrapPanelButtonCount,
                HorizontalAlignment = HorizontalAlignment.Left,
                Width = 20,
                Margin = new Thickness(10, 10, 0, 0),
            };
            newButton.Click += WrapPanelButton_Click;
            Wrappanel.Children.Add(newButton);
        }
    }
}
