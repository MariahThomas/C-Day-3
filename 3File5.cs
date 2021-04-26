using System.IO;
using System;

class Vehicle
{
    public string Brand = "Ford";
    public void honk()
    {
        Console.WriteLine("Tuut, tutt!");
    }
}
class Car : Vehicle
{
    Car (string _model)
    {
        modelName = _model;
    }
    public string modelName {get; set; }
    static void Main()
    {
        Car mycar = new car("Mustang");
        mycar.honk();
        Console.WriteLine(mycar.Brand+ " " +mycar.modelName);
        Console.ReadLine();
    }
}