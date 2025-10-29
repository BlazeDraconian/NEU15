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

namespace Data_Binding
{

    public partial class MainWindow : Window
    {
        public Person PersonA { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = PersonA = new Person() { FirstName = "Lucas", LastName= "Welbury", Age = 46};
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}