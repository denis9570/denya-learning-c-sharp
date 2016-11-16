using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Lab3PolyOop
{
    internal interface IShape
    {
        float getArea();
        float getPerimeter();
        string getName();
    }

    class Triangle : IShape
    {
        //fields
        private float a;
        private float b;
        private float c;

        public Triangle(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }



        public float getArea()
        {
            var p = getPerimeter() / 2;
            return (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public float getPerimeter()
        {
            return a + b + c;
        }

        public string getName()
        {
            return "Triangle";
        }
    }

    class Circle : IShape
    {
        //field
        private float r;


        public Circle(float r)
        {
            this.r = r;
        }

        public float getArea()
        {
            return (float)Math.PI * r * r;
        }

        public float getPerimeter()
        {
            return (float)(2 * Math.PI * r);
        }

        public string getName()
        {
            return "Circle";
        }
    }

    class Rectangle : IShape
    {
        //fields
        private float a;
        private float b;


        public Rectangle(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public float getArea()
        {
            return a * b;
        }

        public float getPerimeter()
        {
            return (a + b) * 2;
        }

        public string getName()
        {
            return "Rectangle";
        }
    }




    internal class Program
    {
        public static void Main(string[] args)
        {
            ShowInfo(new Triangle(3,4,5));
            ShowInfo(new Circle(4));
            ShowInfo(new Rectangle(3, 3));
        }


        private static void ShowInfo(IShape shape)
        {
            Console.WriteLine("Area:" + shape.getArea());
            Console.WriteLine("Perimeter:" + shape.getPerimeter());
            Console.WriteLine("Name:" + shape.getName());
            Console.WriteLine(" ");

        }
    }


}