public interface IFuelCapacity
{
    decimal FuelConsumption { get; set; }  // Расход топлива
    void Refuel(decimal amount);            // Метод для заправки самолета
}
