using System;

namespace WemaBankTeller
{
    class Program
    {
        static void Main(string[] args)
        {

            var accountUserType = new AccountUser();
            accountUserType.accountDetails();
            accountUserType.Saving();
            double interestm;
            interestm = accountUserType.Interest();
            double total = 0;
            total = accountUserType.Duration6(interestm);
            Console.WriteLine("your reward is");
            Console.WriteLine(total);
            total= accountUserType.Duration12(interestm);
            Console.WriteLine("your reward is");
            Console.WriteLine(total);
            total = accountUserType.Duration24(interestm);
            Console.WriteLine("your reward is");
            Console.WriteLine(total);
            total = accountUserType.Duration60(interestm);
            Console.WriteLine("your reward is");
            Console.WriteLine(total);

        }
    }


    class AccountUser
    {
        public double savings;
        public string accountType;
        public double interest = 0;
        public int duration = 0;
        public void accountDetails()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Please Enter your Account Name");
            string accountName = Console.ReadLine();
            Console.WriteLine("Please Enter your Account Number");
            double accountNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter your Account type either Savings,Current,Virtual and Fixed Deposit");
            accountType = Console.ReadLine();

        }

        public void Saving()
        {
            Console.WriteLine("Enter the amount:");
            savings = double.Parse(Console.ReadLine());

        }

        public double Interest()

        {
            double interesti = 0;
            switch (accountType)
            {
                case "savings":
                    interesti = savings * 10;
                    return interesti;
                case "current":
                    interesti = savings * 20 / 100;
                    return interesti;
                case "virtual":
                    interesti = savings * 30 / 100;
                    return interesti;
                case "fixed deposit account":
                    interesti = savings * 40 / 100;
                    return interesti;
            }
            return interesti;
        }

        public double Duration6(double interest6)
        {
            double interest = interest6 * 6;

            return interest;
        }
        public double Duration12(double interest12)
        {
            double interest = interest12 * 12;

            return interest;

        }

        public double Duration24(double interest24)
        {
            double interest = interest24 * 24;

            return interest;
        }
        public double Duration60(double interest60)
        {

            double interest = interest60 * 60;

            return interest;
        }
    }
    }

