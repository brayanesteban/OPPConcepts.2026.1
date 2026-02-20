using OppConcepts.Backend;

    try
{
    var employee1 = new SalaryEmployee("John", 1010, true, "Doe", new Date(1990, 5, 15), new Date(2020, 1, 1), 2500000);
    Console.WriteLine(employee1);

}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);  
}
