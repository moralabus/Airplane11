using System;

public class PassengerAirplane : Airplane, IFuelCapacity
{
    public int PassengerCapacity { get; set; }
    public bool HasBusinessClass { get; set; }

    // Конструктор для инициализации
    public PassengerAirplane(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate, string foto, int passengerCapacity, bool hasBusinessClass)
        : base(name, model, range, fuelConsumption, manufactureDate, foto)
    {
        PassengerCapacity = passengerCapacity;
        HasBusinessClass = hasBusinessClass;
    }

    // Реализация метода Refuel интерфейса IFuelCapacity
    public void Refuel(decimal amount)
    {
        FuelConsumption += amount;  // Увеличиваем расход топлива как пример
    }

    // Переопределение GetInfo, если нужно добавить дополнительную информацию
    public override string GetInfo()
    {
        return base.GetInfo() + $"\nВместимость пассажиров: {PassengerCapacity}\nНаличие бизнес-класса: {(HasBusinessClass ? "Да" : "Нет")}";
    }
}
