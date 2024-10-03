using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal interface ITestInterface
    {
        //method declaration
        void MakePayment(decimal amount);
        void RefundPayment(decimal amount);
        
        //public ITestInterface()
        //{

        //}

    }

    interface ITestInterface1
    {
        void UpiPayment(decimal amount);
    }
    public class CreditCardPayment : ITestInterface , ITestInterface1
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($" Credit Card Payment of {amount} has been made");
        }
        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($" Credit Card Refund of {amount} has been made");
        }
        public void UpiPayment(decimal amount)
        {
            Console.WriteLine($" Upi Payment Refund of {amount} has been made");

        }
    }

    public class PaypalPayment:ITestInterface
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($" Paypal Payment of {amount} has been made");
        }
        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($" Paypal Refund of {amount} has been made");
        }

    }
   

    public class TestInterface
    {
        static void Main()
        {
            //credit card payment class
            ITestInterface credit = new CreditCardPayment();
            credit.MakePayment(100.50m);
            credit.RefundPayment(50.50m);

            ITestInterface1 credit1 = new CreditCardPayment();
            credit1.UpiPayment(100.58m);

            //paypal class
            ITestInterface paypal = new PaypalPayment();
            paypal.MakePayment(60.52m);
            paypal.RefundPayment(20.5m);

        }
    }
}
