using Business_Logic_Layer;
using Business_Object;
using Data_Access_Layer;

namespace Presentation_Layer
{
    public class EmployeeView
    {
        public void InputData()
        {
            string name;
            int age;
            decimal salary;
            Console.WriteLine("Enter the employee info you wanna save to the file.\n");
            Console.Write("Name: ");
            name=Console.ReadLine();
            Console.Write("Age: ");
            age=int.Parse(Console.ReadLine());
            Console.Write("Salary: ");
            salary=decimal.Parse(Console.ReadLine());

            EmployeeBusinessObject ebo = new EmployeeBusinessObject();
            ebo.Name=name;
            ebo.Age=age;
            ebo.Salary=salary;

            EmployeeManager em = new EmployeeManager();
            em.CalculateTax(ebo);

            Console.WriteLine("\n\nThe information of employees stored so far in the file is:\n");
            em.PrintAllEmployees();
        }
    }
}