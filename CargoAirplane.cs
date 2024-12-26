using System;

public class CargoAirplane : Airplane, IFuelCapacity
{
    public int CargoCapacity { get; set; }
    public string CargoType { get; set; }

    // Конструктор для инициализации
    public CargoAirplane(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate, string foto, int cargoCapacity, string cargoType)
        : base(name, model, range, fuelConsumption, manufactureDate, foto)
    {
        CargoCapacity = cargoCapacity;
        CargoType = cargoType;
    }

    // Реализация метода Refuel интерфейса IFuelCapacity
    public void Refuel(decimal amount)
    {
        FuelConsumption += amount;  // Увеличиваем расход топлива как пример
    }

    // Переопределение GetInfo, если нужно добавить дополнительную информацию
    public override string GetInfo()
    {
        return base.GetInfo() + $"\nГрузоподъемность: {CargoCapacity} кг\nТип груза: {CargoType}";
    }
}
