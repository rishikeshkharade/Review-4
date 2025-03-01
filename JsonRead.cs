using System.Globalization;
using System.Linq.Expressions;
using Newtonsoft.Json;

class Employee
{
    string Name { get; set; }
    decimal Salary { get; set; }
    int ID { get; set; }

    public static void EmployeeMain()
    {
        var records = new List<Employee> {
    new Employee{Name = "Amol", Salary = 56200, ID = 101},
    new Employee{Name = "Asmita", Salary = 52000, ID = 102},
    new Employee{Name = "Tanmay", Salary = 56422, ID = 103}
        };

        string path = "D:/Access Meditech BridgeLabz/Review 4/Employee.json";
        //File.Create(path);

        string jsonData = JsonConvert.SerializeObject(records, Formatting.Indented);
        File.WriteAllText(path, jsonData);


        string jsonRead = File.ReadAllText(path);
        var deserializedData = JsonConvert.DeserializeObject<List<Employee>>(jsonRead);
        foreach (var emp in deserializedData)
        {
            Console.WriteLine($"Emp ID ={emp.ID}, EmpName={emp.Name}, EmpSalary={emp.Salary}");
        }
    }
}
