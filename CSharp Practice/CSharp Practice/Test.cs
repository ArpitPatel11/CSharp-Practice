using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    public class Test
    {
        //public string name = "Arpit";
        //private int health = 98;

        //public int getHealth()
        //{
        //    return health;
        //}
        //public void setHealth(int h)
        //{
        //    health = h;
        //}


        public int num1;
        public int num2;
        public int result;

        public void Addition()
        {
            result = num1 + num2;
            DisplayResult();
        }

        public void Substract()
        {
            result = num1 - num2;
            DisplayResult();
        }
        public void Multiplication()
        {
            result = num1 * num2;
            DisplayResult();
        }
        public void Division()
        {
            result = num1 / num2;
            DisplayResult();
        }

        public void DisplayResult()
        {
            Console.WriteLine("Result is:" + result);
        }



        //Methods:

        //1.Method With Argument and return value:
        public int MaxValue(int a, int b)
        {
            int result;
            if (a > b)
            {
                result = a;
            }
            else
            {
                result = b;
            }
            return result;
        }
        //2.Method with no argument no return value:
        public void Printmsg()
        {
            Console.WriteLine("Hello World");
        }

        //3.Method with argument but no return value:
        public void Sum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Result is:" + result);
        }

        //4.Method with no argument but return value:

        public int Factorial()
        {
            int num = 4;
            int fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;

            
        }


        //Inheritance Example:

        //Single Inheritance,Multilevel Inheritance,Hierarchical Inheritance:
        public class car
        {
            public string model;
            public string color;
            public int price;

            public void PrintCar()
            {
                Console.WriteLine("Model:" + model);
                Console.WriteLine("Color:" + color);
                Console.WriteLine("Price:" + price);
            }
        }
        public class Ferrari:car
        {
            public int speed;

            public void DisplaySpeed()
            {
                Console.WriteLine("Speed:" + speed);
            }
        }
        public class Maruti : Ferrari
        {
            public float mileage;

            public void DisplayMileage()
            {
                Console.WriteLine("Mileage:" + mileage);
            }

            /*Method OverLoading  
              class can have multiple methods having same name
              Same Name,Same Class,Different Parameter,Sequence Of Parameters
            */


          
        }
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(float a, float b)
        {
            Console.WriteLine(a + b);
        }

        public void Add(string a , string b)
        {
            Console.WriteLine(a + b);
        }



        /*Method Overriding:
          We Can Overide the method of parent class with same name method of childclass
          Same Name,Different Class,Same Parameter,Sequence Of Parameter
         */

       public class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal is Eating");
            }
        }
       public class Dog:Animal
        {
            public void Eat()
            {
                Console.WriteLine("Dog is Eating");
            }

            public static void Main(string[] args)
            {
                Dog Object = new Dog();
                Object.Eat();
                               
            }
        }

      
    }

    //EnCapusulation Example:
    public class Account
    {
        int accountBalance = 1000;
        public void SetBalance(int amount)
        {
            if(amount < 0)
            {
                Console.WriteLine("You Can Not Pass Negative Values");
            }
            else
            {
                accountBalance = amount;
            }
            
        }

        public void GetBalance()
        {
            Console.WriteLine("Your Account Balance is:" + accountBalance);
        }
    }
}
