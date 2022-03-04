namespace Business_Object
{
    public class EmployeeBusinessObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public decimal Tax { get; set; }

        public void PrintEmployee()
        {
            Console.WriteLine($"Name: {this.Name}\n" +
                $"Age: {this.Age}\n" +
                $"Salary: {this.Salary}\n" +
                $"Tax: {this.Tax}\n");
        }
    }
}