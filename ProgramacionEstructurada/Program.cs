using ProgramacionEstructurada.Business;
using System.Threading.Channels;
var cerveza = new ExpiringBeer("Corona", 20.5m, 4.5m, new DateTime(2024, 12, 31),1000);
var erdingBeer = new Beer("Erdinger", 30.0m, 5.5m,1000);
var delirium = new ExpiringBeer("Delirium Tremens", 50.0m, 8.5m, new DateTime(2025, 1, 1),330);
Console.WriteLine(delirium.GetCantegoria());

/// Aunque sea el mismo metodo el comportamiento es distinto
/// </summary>
Console.WriteLine(erdingBeer.GetInfo());
Console.WriteLine(delirium.GetInfo());
///<summary>
///Los metodos que invoque con la clase hija y que pertenezcan a la clase padre son modificados 
///por el virtual y el override , lo que hace que el comportamiento sea distinto 
///dependiendo de la clase que se este utilizando,
///</summary>
Console.WriteLine(delirium.GetInfo(5));
Console.WriteLine(delirium.GetInfo("El metodo con parametro tambien se puede usar para una sobreecritura, pero debe mantener sus parametros"));

Drink drink = new Wine(750);
Show(drink);
drink = new Beer("Heineken", 25.0m, 5.0m,1000);
Show(drink);
void Show(Drink drink)=> Console.WriteLine(drink.GetCantegoria());

SendSome(erdingBeer);
void SendSome(ISend send)
{
    Console.WriteLine("Hace algo");
    send.Send();
    Console.WriteLine("Hace algo");
}
var service = new Service(100, 21);
Console.WriteLine(service.GetInfo());
ShowInfo(service);

void ShowInfo(ISend salable)
{
    Console.WriteLine("Mostrando informacion...");
    salable.Send();
    Console.WriteLine("Informacion mostrada");
}