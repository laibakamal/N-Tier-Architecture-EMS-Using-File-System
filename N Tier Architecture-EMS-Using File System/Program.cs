using System;
using Presentation_Layer;
namespace EmployeeManagementSystem
{
    public class EMS
    {
        public static void Main(string[]args)
        {
            EmployeeView ev=new EmployeeView();
            ev.InputData();
        }
    }
}
