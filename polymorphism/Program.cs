using System;

namespace polymorphism
{
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
