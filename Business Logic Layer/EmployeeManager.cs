using Business_Object;
using Data_Access_Layer;

namespace Business_Logic_Layer
{
    public class EmployeeManager
    {
        public void CalculateTax(EmployeeBusinessObject ebo)
        {
            if (ebo.Salary<=10000)
            {
                ebo.Tax=100;
            }
            else
            {
                ebo.Tax=1000;
            }

            FileHandling fh=new FileHandling();
            fh.SaveEmployee(ebo);
        }

        public void PrintAllEmployees()
        {
            FileHandling fh=new FileHandling(); 
            List<EmployeeBusinessObject> list=fh.ReadEmployeesFromFile();

            foreach (EmployeeBusinessObject ebo in list)
            {
                ebo.PrintEmployee();
            }
        }
    }
}