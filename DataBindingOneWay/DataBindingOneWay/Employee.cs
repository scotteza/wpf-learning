using DataBindingOneWay.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBindingOneWay
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

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
