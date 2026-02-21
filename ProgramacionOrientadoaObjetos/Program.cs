
var Cerveza = new Beer()
{
    Name = "Corona",
    Price = 1.99m
};
Console.WriteLine(Cerveza.Name+"; $"+Cerveza.Price);

Console.WriteLine(Cerveza.GetInfo());
var auto = new Car(4, "Rojo", "Sedan");
Console.WriteLine(auto.Modelo);

public class Beer{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public string GetInfo(){
        return $"{Name}; ${Price}";
    }

}


public class Car
{
    public int NumeroLlantas { get; set; }
    public string Color { get; set; }
    public string Modelo { get; set; }
    public Car(int numeroLlantas, string color, string modelo)
    {
        NumeroLlantas = numeroLlantas;
        Color = color;
        Modelo = modelo;
    }
}