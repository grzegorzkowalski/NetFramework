namespace ConsoleApp
{
    public interface ICar
    {
        int ID { get; set; }
        string Brand { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        string Color { get; set; }
        decimal Price { get; set; }
        int Quantity { get; set; }
        void AddCar();
        void RemoveCar();
        void ListCars();
        void ChangeState();
    }
}
