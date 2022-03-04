using Business_Object;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Data_Access_Layer
{
    public class FileHandling
    {
        public void SaveEmployee(EmployeeBusinessObject ebo)
        {
            string jsonOutput = JsonSerializer.Serialize(ebo);
            FileStream f = new FileStream("MyFile.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(f);
            sw.WriteLine(jsonOutput);
            sw.Close();
            f.Close();
        }
        public List<EmployeeBusinessObject> ReadEmployeesFromFile()
        {
            List<EmployeeBusinessObject> employees = new List<EmployeeBusinessObject>();
            FileStream f = new FileStream("MyFile.txt", FileMode.Open);
            StreamReader sr = new StreamReader(f);
            string jsonString = sr.ReadLine();
            while (jsonString!=null)
            {
                EmployeeBusinessObject ebo = JsonSerializer.Deserialize<EmployeeBusinessObject>(jsonString);
                employees.Add(ebo);
                jsonString = sr.ReadLine();
            }

            return employees;
        }
    }
}