using System;

namespace FactoryMethodExample
{
    // Интерфейс автомобиля
    public interface ICar
    {
        void Drive();
    }

    // Конкретные классы автомобилей
    public class Sedan : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Едем на седане.");
        }
    }

    public class SUV : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Едем на внедорожнике.");
        }
    }

    public class Hatchback : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Едем на хэтчбеке.");
        }
    }

    public class Coupe : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Едем на купе.");
        }
    }

    public class Convertible : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Едем на кабриолете.");
        }
    }

    public class Pickup : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Едем на пикапе.");
        }
    }

    // Абстрактная фабрика автомобилей
    public abstract class CarFactory
    {
        public abstract ICar CreateCar();

        public void StartDrive()
        {
            var car = CreateCar();
            car.Drive();
        }
    }

    // Конкретные фабрики для каждого типа автомобилей
    public class SedanFactory : CarFactory
    {
        public override ICar CreateCar()
        {
            return new Sedan();
        }
    }

    public class SUVFactory : CarFactory
    {
        public override ICar CreateCar()
        {
            return new SUV();
        }
    }

    public class HatchbackFactory : CarFactory
    {
        public override ICar CreateCar()
        {
            return new Hatchback();
        }
    }

    public class CoupeFactory : CarFactory
    {
        public override ICar CreateCar()
        {
            return new Coupe();
        }
    }

    public class ConvertibleFactory : CarFactory
    {
        public override ICar CreateCar()
        {
            return new Convertible();
        }
    }

    public class PickupFactory : CarFactory
    {
        public override ICar CreateCar()
        {
            return new Pickup();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите тип кузова автомобиля:");
                Console.WriteLine("a - Sedan");
                Console.WriteLine("b - SUV");
                Console.WriteLine("c - Hatchback");
                Console.WriteLine("d - Coupe");
                Console.WriteLine("e - Convertible");
                Console.WriteLine("f - Pickup");
                Console.WriteLine("Введите букву для выбора автомобиля, или q для выхода:");

                string choice = Console.ReadLine().ToLower();

                if (choice == "q")
                {
                    break; // Выход из программы
                }

                CarFactory carFactory = null;

                // Выбор типа кузова по введенной букве
                switch (choice)
                {
                    case "a":
                        carFactory = new SedanFactory();
                        break;
                    case "b":
                        carFactory = new SUVFactory();
                        break;
                    case "c":
                        carFactory = new HatchbackFactory();
                        break;
                    case "d":
                        carFactory = new CoupeFactory();
                        break;
                    case "e":
                        carFactory = new ConvertibleFactory();
                        break;
                    case "f":
                        carFactory = new PickupFactory();
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        continue; // Повторить цикл при неверном вводе
                }

                // Запуск вождения выбранного автомобиля
                if (carFactory != null)
                {
                    carFactory.StartDrive();
                }
            }
        }
    }
}