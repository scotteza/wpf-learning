namespace DataBindingOneWay
{
    public class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }

        public static Employee GetEmployee()
        {
            return new Employee
            {
                Name = "Bob",
                Title = "Developer"
            };
        }
    }
}
