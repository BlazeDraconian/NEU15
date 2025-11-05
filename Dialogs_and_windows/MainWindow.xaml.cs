using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
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

namespace Dialogs_and_windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is a message");
        }

        private void Add_Character_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to add a character to the button text?", "Update button text?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Add_Character_Button.Content += "?";
            }
        }

        private void Disable_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to disable this button?", "Disable button?", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            if (result == MessageBoxResult.OK)
            {
                Disable_Button.IsEnabled = false;
            }
        }

        private void OpenFileDialogButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.ShowHiddenItems = true;
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //dialog.FileName = @"C:\Windows";
            if (dialog.ShowDialog() == true)
            {
                OpenFileDialogButton.Content=dialog.FileName;
             }

        }

        private void SaveFileDialog_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog();

            dialog.ShowHiddenItems = true;
            dialog.FileName = "SaveFileCSharpDemo.txt";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //dialog.FileName = @"C:\Windows";
            dialog.OverwritePrompt = true;
            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, Add_Character_Button.Content.ToString());
             }

        }

        private void AddUserDialogButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new AddUserDialog();
            if (dialog.ShowDialog() == true)
            {
               
                Users.Add(new User() { FirstName = dialog.FirstName, LastName = dialog.LastName });
            }
            

        }
    }
}