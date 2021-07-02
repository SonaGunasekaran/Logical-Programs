using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class CouponNumber
    {

        Random random = new Random();


        //private non-static method for generating random number
        private static int GenerateNumber(int start, int end)
        {
            int random = random.Next(start, end);
            return random;
        }
        public static void GenerateCoupon()
        {
            int Coupon = 0,

            int Count = 0;

            Console.WriteLine("Enter  starting coupon number");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Ending coupon number");
            int end = Convert.ToInt32(Console.ReadLine());



            //Creating objects
            CouponNumber num = new CouponNumber();


            while (start - end > 0)
            {
                coupon[numOfCoupons] = Coupon;
                Count++;

            }

            //print coupon

            foreach (int i in Coupon)
            {
                Console.Write(i + ", ");
            }

            //generating random coupons
            Console.WriteLine(" Random number to generate coupons are", Count);


        }
    }
}
