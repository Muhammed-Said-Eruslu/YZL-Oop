using _17_OOP_GenericLab;

BaseService baseService = new BaseService();
baseService.Create(new Admin() { Id = 1, Name = "Said", Status = Status.Active }); baseService.Create(new Admin() { Id = 2, Name = "Muhammed", Status = Status.Active });
baseService.Create(new Employee() { Id = 3, Name = "Batuhan", Status = Status.Pasife });
baseService.Create(new Admin() { Id = 4, Name = "Said", Status = Status.Active });
baseService.Create(new Admin() { Id = 5, Name = "Eruslu", Status = Status.Pasife });

foreach (var item in baseService.GetAll())
{
    if(item.Status == Status.Active) // sadace active olanlırı yazdır
    {
        Console.WriteLine(item.Name + " ");
        item.CalculateSalary();
    }
    else if(item.Status == Status.Pasife)
    {
        Console.WriteLine(item.Name+ " ");
        item.CalculateSalary();
    }
}
