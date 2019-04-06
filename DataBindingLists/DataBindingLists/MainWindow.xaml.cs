using System.Windows;

namespace DataBindingLists
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = Employee.GetEmployees();
        }
    }
}
