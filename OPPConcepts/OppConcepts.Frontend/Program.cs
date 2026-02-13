using OppConcepts.Backend;

    try
{
    var date1 = new Date();
    var date2 = new Date(2028, 2, 29);
    var date3 = new Date(2012, 11, 21);

    Console.WriteLine(date1);
    Console.WriteLine(date2);
    Console.WriteLine(date3);

}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);  
}
