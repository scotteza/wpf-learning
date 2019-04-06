using System.Windows;

namespace DataBindingTwoWay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Employee _employee;

        public MainWindow()
        {
            InitializeComponent();
            _employee = new Employee
            {
                Name = "Scott",
                Title = "Owner"
            };
            DataContext = _employee;
        }
    }
}
