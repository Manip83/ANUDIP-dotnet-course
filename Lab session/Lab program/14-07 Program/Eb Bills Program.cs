using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Electric Bill
{
    class ElectricBill
    {
        double totalBill;
        int totalUnit;
        string customerName;

        void GetInput()
        {
            try
            {
                Console.Write("Enter Customer Name : ");
                customerName = Console.ReadLine();
                Console.Write("Enter Consumed Unit : ");
                totalUnit = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        void Calculation()
        {
            if (totalUnit <= 100)
            {
                totalBill = totalUnit * 1.5;

            }
            else if (totalUnit <= 200 && totalUnit > 100)
            {
                totalBill = (100 * 1.5) + ((totalUnit - 100) * 2);

            }
            else if (totalUnit <= 500 && totalUnit > 200)
            {
                totalBill = (100 * 1.5) + (100 * 2) + ((totalUnit - 200) * 3);
            }
            else
            {
                totalBill = (100 * 1.5) + (100 * 2) + (300 * 3) + ((totalUnit - 500) * 5);
            }
        }
        public void ShowOut()
        {
            Console.WriteLine(" ####### Welcome To TNEB  ####### ");
            Console.WriteLine("Enter user details");
            GetInput();
            Console.WriteLine("##################################");
            Console.WriteLine();
            Calculation();
            Console.WriteLine("Customer name - {0}", customerName);
            Console.WriteLine("You have Consumed {0} units ", totalUnit);
            Console.WriteLine("You Have to Pay {0} ", totalBill);
            Console.WriteLine("Thanks For Visiting");

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            ElectricBill electricBill = new ElectricBill();
            electricBill.ShowOut();

        }
    }



}
