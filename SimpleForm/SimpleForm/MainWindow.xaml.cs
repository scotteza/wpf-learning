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

namespace SimpleForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _selectedJob = "(None)";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonSave_OnClick(object sender, RoutedEventArgs e)
        {
            var sb = new StringBuilder();

            sb.Append("Full Name: ");
            sb.AppendLine(!string.IsNullOrWhiteSpace(TextBoxFullName.Text) ? TextBoxFullName.Text : "(None)");

            sb.Append("Sex: ");
            sb.AppendLine(RadioButtonSexMale.IsChecked != null && RadioButtonSexMale.IsChecked.Value ? "Male" : "Female");

            sb.Append("Computer(s): ");
            sb.Append(CheckBoxDesktop.IsChecked != null && CheckBoxDesktop.IsChecked.Value ? "Desktop" : "No Desktop");
            sb.Append(", ");
            sb.Append(CheckBoxLaptop.IsChecked != null && CheckBoxLaptop.IsChecked.Value ? "Laptop" : "No Laptop");
            sb.Append(", ");
            sb.AppendLine(CheckBoxTablet.IsChecked != null && CheckBoxTablet.IsChecked.Value ? "Tablet" : "No Tablet");

            sb.Append("Job: ");
            sb.AppendLine(_selectedJob);

            sb.Append("Delivery Date: ");
            sb.Append(CalendarPromisedDeliveryDate.SelectedDate != null
                ? CalendarPromisedDeliveryDate.SelectedDate.Value.ToString("yyyy/MM/dd")
                : "(None)");

            MessageBox.Show(sb.ToString());
        }

        private void ComboBoxJob_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var addedItem in e.AddedItems)
            {
                SelectJobIfValidComboBoxItem(addedItem);
            }
        }

        private void SelectJobIfValidComboBoxItem(object addedItem)
        {
            if (addedItem is ComboBoxItem item)
            {
                _selectedJob = item.Content.ToString();
            }
        }
    }
}
