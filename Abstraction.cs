using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace BankSystem
    {
        // ==========================================
        // ABSTRACT CLASS - ACCOUNT
        // ==========================================
        public abstract class Account
        {
            // Propertylar
            public string OwnerName { get; set; }
            public decimal Balance { get; set; }

            // Constructor
            public Account(string ownerName, decimal balance)
            {
                OwnerName = ownerName;
                Balance = balance;
            }

            // 1. Abstract method (Child classlar majburiy override qilishi kerak)
            public abstract void Withdraw(decimal amount);

            // 2. Virtual method (Child classlar xohlasa override qiladi, xohlamasa shu holicha ishlatadi)
            public virtual void ShowBalance()
            {
                Console.WriteLine($"[ {OwnerName}] Balans: {Balance:C}");
            }

            // 3. Oddiy method
            public void Deposit(decimal amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                    Console.WriteLine($" Muvaffaqiyatli bajarildi! {amount:C} qo'shildi.");
                    Console.WriteLine($"Yangi balans: {Balance:C}");
                }
                else
                {
                    Console.WriteLine(" Xatolik: Nol yoki manfiy summa kiritib bo'lmaydi!");
                }
            }
        }

        // ==========================================
        // CHILD CLASS - SAVINGS ACCOUNT
        // ==========================================
        public class SavingsAccount : Account
        {
            // Constructor inheritance (base orqali)
            public SavingsAccount(string ownerName, decimal balance) : base(ownerName, balance)
            {
            }

            // Abstract methodni override qilish
            public override void Withdraw(decimal amount)
            {
                Console.WriteLine($" {OwnerName} - {amount:C} yechishga urunish...");

                if (amount > Balance)
                {
                    Console.WriteLine(" Not enough balance (Mablag' yetarli emas)");
                }
                else
                {
                    Balance -= amount;
                    Console.WriteLine($" Muvaffaqiyatli yechildi! Joriy balans: {Balance:C}");
                }
            }
        }

        // ==========================================
        // CHILD CLASS - CREDIT ACCOUNT
        // ==========================================
        public class CreditAccount : Account
        {
            // Kredit limiti -5000
            private const decimal CreditLimit = -5000;

            // Constructor inheritance (base orqali)
            public CreditAccount(string ownerName, decimal balance) : base(ownerName, balance)
            {
            }

            // Abstract methodni override qilish
            public override void Withdraw(decimal amount)
            {
                Console.WriteLine($" {OwnerName} - {amount:C} (Kredit hisobidan) yechishga urunish...");

                // Agar yechilgandan keyin balans -5000 dan oshib ketadigan bo'lsa
                if (Balance - amount < CreditLimit)
                {
                    Console.WriteLine(" Credit limit exceeded (Kredit limiti oshib ketdi!)");
                }
                else
                {
                    Balance -= amount;
                    Console.WriteLine($" Muvaffaqiyatli yechildi! Joriy balans: {Balance:C}");
                }
            }
        }

        // ==========================================
        // MAIN METHOD
        // ==========================================
        class Program
        {
            static void Main(string[] args)
            {
                // Konsol oynasini chiroyli qilish uchun UTF-8 va ranglar
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=== BANK TIZIMI TAYYORLANDI ===\n");
                Console.ResetColor();

                // 1. Savings Account testi
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--- SAVINGS ACCOUNT TEST ---");
                Console.ResetColor();

                SavingsAccount savings = new SavingsAccount("Alijon", 1000);
                savings.ShowBalance();          // Balans: 1000

                savings.Deposit(500);           // Deposited: 500 -> Balans: 1500
                savings.Withdraw(300);          // Withdraw: 300 -> Balans: 1200
                savings.Withdraw(2000);         // Not enough balance

                Console.WriteLine("\n---------------------------------------------\n");

                // 2. Credit Account testi
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--- CREDIT ACCOUNT TEST ---");
                Console.ResetColor();

                CreditAccount credit = new CreditAccount("Valijon", 0);
                credit.ShowBalance();           // Balans: 0

                credit.Withdraw(2000);          // Minusga ruxsat -> Balans: -2000
                credit.Withdraw(4000);          // -2000 - 4000 = -6000 (Limitdan oshib ketadi) -> Credit limit exceeded

                Console.ReadLine();


            // Ai den yordam oldim
            }
        }
    }