using System.Windows;
using System.Windows.Controls;

namespace WPF_Intro
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

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                button.Content += "!";
            }
            
            //MessageBox.Show("Hello World");

            //LeftButton.Content = "Hello";
            //MyButton.HorizontalAlignment = HorizontalAlignment.Left;
        }
    }
}