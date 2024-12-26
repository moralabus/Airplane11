using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private List<IAircraft> airplanes = new List<IAircraft>();

    public Form1()
    {
        InitializeComponent();

        // Пример добавления самолетов
        IAircraft cargoAirplane = new CargoAirplane("Грузовой самолет", "CargoAirplane", 5000, 1000m, DateTime.Now, "foto.jpg", 20000, "Товары");
        IAircraft passengerAirplane = new PassengerAirplane("Пассажирский самолет", "PassengerAirplane", 6000, 800m, DateTime.Now, "foto.jpg", 180, true);

        airplanes.Add(cargoAirplane);
        airplanes.Add(passengerAirplane);

        // Отображаем информацию о самолетах в ListBox
        foreach (var airplane in airplanes)
        {
            listBoxAirplanes.Items.Add(airplane.GetInfo());
        }

        // Заполнение ComboBox с моделями (например, для выбора типа самолета)
        comboBoxModel.Items.Add("CargoAirplane");
        comboBoxModel.Items.Add("PassengerAirplane");
    }

    // Обработчик для кнопки добавления нового самолета
    private void buttonAddAirplane_Click(object sender, EventArgs e)
    {
        // Добавляем новый самолет на основе значений в TextBox и NumericUpDown
        string airplaneName = textBoxAirplaneName.Text;
        string model = comboBoxModel.SelectedItem?.ToString();
        int range = (int)numericUpDownRange.Value;
        decimal fuelConsumption = numericUpDownFuelConsumption.Value;

        if (model == "CargoAirplane")
        {
            IAircraft newAirplane = new CargoAirplane(airplaneName, model, range, fuelConsumption, DateTime.Now, "new_foto.jpg", 20000, "Товары");
            airplanes.Add(newAirplane);
        }
        else if (model == "PassengerAirplane")
        {
            IAircraft newAirplane = new PassengerAirplane(airplaneName, model, range, fuelConsumption, DateTime.Now, "new_foto.jpg", 250, true);
            airplanes.Add(newAirplane);
        }

        // Обновляем ListBox с информацией о самолетах
        listBoxAirplanes.Items.Clear();
        foreach (var airplane in airplanes)
        {
            listBoxAirplanes.Items.Add(airplane.GetInfo());
        }
    }

    // Обработчик для кнопки заправки самолета
    private void buttonRefuel_Click(object sender, EventArgs e)
    {
        if (listBoxAirplanes.SelectedItem != null)
        {
            var selectedAirplane = airplanes.FirstOrDefault(a => a.GetInfo() == listBoxAirplanes.SelectedItem.ToString());
            if (selectedAirplane is IFuelCapacity fuelAirplane)
            {
                fuelAirplane.Refuel(100);  // Заправляем самолет на 100 литров
                MessageBox.Show($"Самолет заправлен. Текущий расход топлива: {fuelAirplane.FuelConsumption} л/ч");
            }
        }
    }

    // Обработчик для выбора модели самолета из ComboBox
    private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Можете добавить дополнительную логику при изменении модели самолета
    }

    // Обработчик для выбора шрифта
    private void buttonChooseFont_Click(object sender, EventArgs e)
    {
        // Добавить логику для выбора шрифта, например, используя FontDialog
        FontDialog fontDialog = new FontDialog();
        if (fontDialog.ShowDialog() == DialogResult.OK)
        {
            textBoxAirplaneName.Font = fontDialog.Font;
        }
    }

    // Обработчик для выбора цвета
    private void buttonChooseColor_Click(object sender, EventArgs e)
    {
        // Добавить логику для выбора цвета, например, используя ColorDialog
        ColorDialog colorDialog = new ColorDialog();
        if (colorDialog.ShowDialog() == DialogResult.OK)
        {
            textBoxAirplaneName.ForeColor = colorDialog.Color;
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}
