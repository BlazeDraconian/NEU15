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

namespace Dialogs_and_windows
{
    
    public partial class AddUserDialog : Window
    {
        public string FirstName
        {
            get => firstNameTextBox.Text;
            set => firstNameTextBox.Text=value;
        }

        public string LastName
        {
            get => lastNameTextBox.Text;
            set => lastNameTextBox.Text =value;
        }
        public AddUserDialog()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {  
           
            this.DialogResult= true;
            this.Close();
        }
    }
}
