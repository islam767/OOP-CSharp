using System;

namespace oop
{

    /* public class Car
     {
         public string brand;
         public string model;
         public int year;
         public double fuelLevel;

         public void ShowInfo()
         {
             Console.WriteLine("---------------------------");
             Console.WriteLine($"Marka: {brand}");
             Console.WriteLine($"Model: {model}");
             Console.WriteLine($"Yıl: {year}");
             Console.WriteLine($"benzin level: %{fuelLevel}");
             Console.WriteLine("---------------------------");
         }

         public void Drive(double distance)
         {
             double requiredFuel = distance / 10;

             if (fuelLevel >= requiredFuel)
             {
                 fuelLevel -= requiredFuel;
                 Console.WriteLine($"{distance} km yol yurildi. ishlatılgan benzin: %{requiredFuel}");
             }
             else
             {
                 Console.WriteLine("ogohlantiruvchı: kerakli benzın yoq! (Not enough fuel!)");
             }
         }

         public void Refuel(double amount)
         {
             fuelLevel += amount;

             if (fuelLevel > 100)
             {
                 fuelLevel = 100;
                 Console.WriteLine(" benzın tola (%100).");
             }
             else
             {
                 Console.WriteLine($"%{amount} benzın quyilgan level: %{fuelLevel}");
             }
         }



         class Program
         {
             static void Main(string[] args)
             {

                 Car car1 = new Car();
                 car1.brand = "Toyota";
                 car1.model = "Corolla";
                 car1.year = 2022;
                 car1.fuelLevel = 50;


                 Car car2 = new Car();
                 car2.brand = "RangeRover";
                 car2.model = "Model 3";
                 car2.year = 2024;
                 car2.fuelLevel = 40;


                 Console.WriteLine("1. CAR HOLATI:");
                 car1.ShowInfo();
                 car1.Drive(150);
                 car1.Refuel(30);
                 car1.ShowInfo();

                 Console.WriteLine("\n2. CAR HOLATI:");
                 car2.ShowInfo();
                 car2.Drive(500);
                 Console.ReadLine();
             }
         }
     }*/
    /*

    using System;

    class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking");
        }
    }

    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{Name} is meowing");
        }
    }

    // Program ichida ishlatilishi:
    // Dog rex = new Dog() { Name = "Rex" };
    // rex.Eat();
    // rex.Bark();

    class Transport
    {
        public string Brand { get; set; }

        public void Move()
        {
            Console.WriteLine($"{Brand} is moving.");
        }
    }

    class Car : Transport
    {
        public void Drive()
        {
            Console.WriteLine($"{Brand} car is being driven.");
        }
    }

    class Bike : Transport
    {
        public void Ride()
        {
            Console.WriteLine($"{Brand} bike is being ridden.");
        }
    }

    class Train : Transport
    {
        public void CarryPassengers()
        {
            Console.WriteLine($"{Brand} train is carrying passengers.");
        }
    }
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public void Work()
        {
            Console.WriteLine($"{Name} is working.");
        }
    }

    class Developer : Employee
    {
        public void Code()
        {
            Console.WriteLine($"{Name} is writing C# code.");
        }
    }

    class Teacher : Employee
    {
        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching students.");
        }
    }

    class Designer : Employee
    {
        public void Design()
        {
            Console.WriteLine($"{Name} is creating UI/UX designs.");
        }
    }
    class Person
    {
        public string Name { get; set; }

        // Otasining konstruktori
        public Person(string name)
        {
            Name = name;
        }
    }

    class Student : Person
    {
        public int Grade { get; set; }

        // base(name) orqali ism ota klassga o'tib ketadi
        public Student(string name, int grade) : base(name)
        {
            Grade = grade;
        }
    }

    class TeacherPerson : Person // Ismini adashtirib yubormaslik uchun TeacherPerson qildik
    {
        public string Subject { get; set; }

        public TeacherPerson(string name, string subject) : base(name)
        {
            Subject = subject;
        }
    }
    class ProtectedAnimal
    {
        // Faqat o'zi va bolalari ko'ra oladi
        protected int Age;
    }

    class GuardDog : ProtectedAnimal
    {
        public void SetAge(int age)
        {
            Age = age; // Voris bo'lgani uchun Age'ga ruxsat bor
        }

        public void ShowAge()
        {
            Console.WriteLine($"Dog's age is: {Age}");
        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public void Attack()
        {
            Console.WriteLine($"{Name} attacks!");
        }
    }

    class Warrior : Character
    {
        public void SwordAttack()
        {
            Console.WriteLine($"{Name} slashes with a sword!");
        }
    }

    class Archer : Character
    {
        public void ShootArrow()
        {
            Console.WriteLine($"{Name} shoots a deadly arrow!");
        }
    }

    class Mage : Character
    {
        public void CastSpell()
        {
            Console.WriteLine($"{Name} casts a powerful fireball spell!");
        }
    }
    class Account
    {
        // Balans tashqaridan to'g'ridan-to'g'ri o'zgartirilmasligi uchun protected qildik
        public double Balance { get; protected set; }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Depozit summasi musbat bo'lishi kerak!");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Joriy balans: {Balance} USD");
        }
    }

    class SavingsAccount : Account
    {
        public void AddInterest(double rate)
        {
            double interest = Balance * (rate / 100);
            Balance += interest; // protected bo'lgani uchun o'zgartira oladi
            Console.WriteLine($"Foiz qo'shildi: {interest} USD");
        }
    }

    class CreditAccount : Account
    {
        public void TakeCredit(double amount)
        {
            // Kredit hisobida balans minusga kirishi mumkin bo'lsa, shartni shunga moslaymiz.
            // Lekin vazifada "Balance manfiy bo'lmasin" deyilgani uchun qat'iy tekshiramiz:
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount} USD kredit olindi.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1-Task testi
            Dog dog = new Dog { Name = "Rex" };
            dog.Eat();
            dog.Bark();
            Console.WriteLine();

            Cat cat = new Cat { Name = "Murka" };
            cat.Eat();
            cat.Meow();
            Console.WriteLine("-------------------------");

            // 4-Task testi
            Student student = new Student("Ali", 5);
            Console.WriteLine($"Name: {student.Name}\nGrade: {student.Grade}\n");

            TeacherPerson teacher = new TeacherPerson("Hasan", "Math");
            Console.WriteLine($"Name: {teacher.Name}\nSubject: {teacher.Subject}");
            Console.WriteLine("-------------------------");

            // 7-Task testi
            SavingsAccount myAcc = new SavingsAccount();
            myAcc.Deposit(1000);
            myAcc.AddInterest(5); // 5% foiz qo'shadi
            myAcc.ShowBalance();

            Console.ReadLine();
        }
    }*/


    using System;

    class Shape
    {
        // Virtual metod — bola klasslar buni o'zgartira olishi uchun
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a generic shape");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Triangle");
        }
    }
    class Notification
    {
        public virtual void Send()
        {
            Console.WriteLine("Sending a generic notification");
        }
    }

    class EmailNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine("Notification sent via Email");
        }
    }

    class SmsNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine("Notification sent via SMS");
        }
    }

    class TelegramNotification : Notification
    {
        public override void Send()
        {
            Console.WriteLine("Notification sent via Telegram");
        }
    }
    class Payment
    {
        public virtual void Pay()
        {
            Console.WriteLine("Processing payment...");
        }
    }

    class ClickPayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("Paid with Click");
        }
    }

    class PaymePayment : Payment
    {
        public override void Pay()
        {
            Console.WriteLine("Paid with Payme");
        }
    }

    class CashPayment : Payment
    {
        public override void Pay()
        {

            Console.WriteLine("Paid with Cash");
        }
    }
    class Character
    {
        public string Name { get; set; }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name} performs a basic attack");
        }
    }

    class Warrior : Character
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with sword");
        }
    }

    class Archer : Character
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} shoots arrow");
        }
    }

    class Mage : Character
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} casts spell");
        }
    }
    class Device
    {
        public virtual void TurnOn()
        {
            Console.WriteLine("Device is powering on...");
        }
    }

    class Phone : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Phone is turning on");
        }
    }

    class Laptop : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Laptop is turning on");
        }
    }

    class TV : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("TV is turning on");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 1-TASK: SHAPES ===");
            Shape s1 = new Circle();
            Shape s2 = new Rectangle();
            Shape s3 = new Triangle();

            s1.Draw();
            s2.Draw();
            s3.Draw();

            Console.WriteLine("\n=== 2-TASK: NOTIFICATIONS ===");
            Notification n1 = new EmailNotification();
            Notification n2 = new SmsNotification();
            Notification n3 = new TelegramNotification();

            n1.Send();
            n2.Send();
            n3.Send();

            Console.WriteLine("\n=== 3-TASK: PAYMENTS ===");
            Payment p1 = new ClickPayment();
            Payment p2 = new PaymePayment();
            Payment p3 = new CashPayment();

            p1.Pay();
            p2.Pay();
            p3.Pay();

            Console.WriteLine("\n=== 4-TASK: CHARACTERS ===");
            Character c1 = new Warrior() { Name = "Viking" };
            Character c2 = new Archer() { Name = "Legolas" };
            Character c3 = new Mage() { Name = "Gandalf" };

            c1.Attack();
            c2.Attack();
            c3.Attack();

            Console.WriteLine("\n=== 5-TASK: DEVICES ===");
            Device d1 = new Phone();
            Device d2 = new Laptop();
            Device d3 = new TV();

            d1.TurnOn();
            d2.TurnOn();
            d3.TurnOn();

            Console.ReadLine();
        }
    }

}