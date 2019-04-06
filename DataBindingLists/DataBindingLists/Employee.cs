using System.Collections.ObjectModel;
using DataBindingLists.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBindingLists
{
    public class Employee : INotifyPropertyChanged
    {
        private string _name;
        private string _title;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public static Employee GetEmployee()
        {
            return new Employee
            {
                Name = "Bob",
                Title = "Developer"
            };
        }

        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>
            {
                new Employee {Name = "Person 1", Title = "Title 1"},
                new Employee {Name = "Person 2", Title = "Title 2"},
                new Employee {Name = "Person 3", Title = "Title 3"},
                new Employee {Name = "Person 4", Title = "Title 4"},
                new Employee {Name = "Person 5", Title = "Title 5"},
                new Employee {Name = "Person 6", Title = "Title 6"}
            };
            return employees;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
