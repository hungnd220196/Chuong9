using Math;

using System;
using Play = Sony.Player.DvdPlayer;

namespace Chuong9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khai bao ban kinh
            double r = 10;
            double a = 2, b = 3;
            Console.WriteLine($"dien tich hinh tron: {Circle.Area(r)}");
            Console.WriteLine($"dien tich hinh chu nhat: {Rectangle.Area(a, b)}");

            //demo2
            test.Car car = new test.Car("toyota");
            car.print();

            //bt1
            //class player de public thi moi truy cap duoc
            Sony.Laptops objSonyLaptop = new Sony.Laptops();

            //bt2 

            //su dung using sai using Play = Sony.Players.DvdPlayer; khong co class Players
            Play objPlayer = new Play();
        }
    }
}

namespace Math
{
    class Circle
    {
        public static double Area(double radius)
        {
            return (3.14 * radius * radius);
        }

    }
}

namespace Math
{
    class Rectangle
    {
        public static double Area(double a, double b)
        {
            return a * b;
        }
    }

}

//bt1


namespace Sony
{
    class Laptops
    {
        public Laptops()
        {
            Console.WriteLine("Manufactures Laptops of different configuarations");
        }
         class Player
        {
            public Player()
            {
                Console.WriteLine("CD as well as DVD players are manufactures");
            }
        }
    }
}


namespace Sony
{
    namespace Player
    {
        class CdPlayer
        {
            public CdPlayer()
            {
                Console.WriteLine("CD-R as well as CD-RW are available");
            }
        }
        public class DvdPlayer
        {
            public DvdPlayer()
            {
                Console.WriteLine("DVD-R as well as DVD-RW are available");
            }
        }
    }
}


