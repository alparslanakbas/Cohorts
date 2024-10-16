using Week_4_3;

Car invalidCar = new()
{
    Mark = "Fiat Egea Cross",
    Model = "Street",
    Color = "Metal beyaz",
    DoorCount = 3
};
invalidCar.GetInfo();

Console.WriteLine();

Car car = new()
{
    Mark = "Fiat Egea Cross",
    Model = "Street",
    Color = "Metal beyaz",
    DoorCount = 4
};
car.GetInfo();  