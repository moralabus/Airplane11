using System;

public class Airplane : IAircraft
{
    public string Name { get; set; }
    public string Model { get; set; }
    public int Range { get; set; }
    public decimal FuelConsumption { get; set; }
    public DateTime ManufactureDate { get; set; }
    public string Foto { get; set; }
    public Guid ID { get; set; }

    // Конструктор для создания нового самолета
    public Airplane(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate, string foto)
    {
        ID = Guid.NewGuid(); // Генерация уникального идентификатора
        Name = name;
        Model = model;
        Range = range;
        FuelConsumption = fuelConsumption;
        ManufactureDate = manufactureDate;
        Foto = foto;
    }

    // Реализация метода интерфейса IAircraft
    public virtual string GetInfo()
    {
        return $"ID: {ID}\nИмя: {Name}\nМодель: {Model}\nДиапазон: {Range} км\nРасход топлива: {FuelConsumption} л/ч\nДата производства: {ManufactureDate.ToShortDateString()}";
    }
}
