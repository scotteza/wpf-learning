using System.Windows;

namespace DataBindingOneWay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = Employee.GetEmployee();
        }
    }
}
