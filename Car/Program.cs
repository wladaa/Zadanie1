using System;

namespace Car

{


    class Car
    {
        String brand;
        String model;
        int year;
        String color;
        double price;

        public Car(String brand, String model, int year, String color, double price)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.color = color;
            this.price = price;
        }
        public void info()
        {
            Console.WriteLine($"Brand:{brand}, Model:{model}, Year:{year}, Color:{color}, Price:{price} PLN");
        }
        static void Main(string[] arg)
        {
            Car car1 = new Car("Kia", "Rio", 2019, "blue", 49000);
            car1.info();
            Car car2 = new Car("Toyota", "Corolla", 2021, "white", 80000);
            car2.info();
        }
    }

}
