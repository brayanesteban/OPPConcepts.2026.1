using OppConcepts.Backend;

    try
{
    var employees = new List<Employee>();
    decimal payroll = 0;    
    var employee1 = new SalaryEmployee("John", 1010, true, "Doe", new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000);
    employees.Add(employee1);
    var employee2 = new SalaryEmployee("Mary", 2020, true, "Johnson", new Date(1985, 3, 10), new Date(2019, 1, 1), 10400000);
    employees.Add(employee2);
    var employee3 = new HourlyEmployee("Jane", 3030, true, "Smith", new Date(1995, 8, 20), new Date(2021, 1, 1), 15000, 160);
    employees.Add(employee3);
    var employee4 = new HourlyEmployee("Bob", 4040, true, "Brown", new Date(1988, 12, 5), new Date(2018, 1, 1), 12000, 120);
    employees.Add(employee4);
    var employee5 = new CommisionEmployee("Alice", 5050, true, "Davis", new Date(1992, 7, 25), new Date(2022, 1, 1), 500000000, 0.03f);
    employees.Add(employee5);
    var employee6 = new CommisionEmployee("Charlie", 6060, true, "Wilson", new Date(1980, 11, 30), new Date(2017, 1, 1), 200000000, 0.03f);
    employees.Add(employee6);
    var employee7 = new BaseCommisionEmployee("Eve", 7070, true, "Taylor", new Date(1998, 4, 5), new Date(2023, 1, 1), 30000000, 0.015f, 500000);
    employees.Add(employee7);
    var employee8 = new BaseCommisionEmployee("Frank", 8080, true, "Anderson", new Date(1985, 9, 15), new Date(2016, 1, 1), 0, 0.015f, 500000);
    employees.Add(employee8);   
    foreach (var employee in employees)
    {
        Console.WriteLine(new string('-', 43));
        Console.WriteLine(employee);
        payroll += employee.GetValueToPay();
    }
    Console.WriteLine(new string('-', 43));
    Console.WriteLine($"payroll..............:{payroll,20:C2}");

}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);  
}
