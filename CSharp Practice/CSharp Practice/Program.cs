// See https://aka.ms/new-console-template for more information



//This is Single line Comment   
/*This is Multiline Comment*/

/*
 Data Types in C#:
 Integer:- int xyz; --> 4 bytes
 Long:- long arpit; --> 8 bytes
 Floating point number:- float that(a); --> 4 bytes
 Double:- double arpit; --> 8 bytes
 Character:- char a = 'A'; --> 2 bytes
 Boolean(true/false):- bool isGreat = true; --> 1 bit
 String:- string inp = "Arpit"; --> 2 bytes/character
*/

// Data Types Example 
// int a = 2;
// float b = 3.1F;
// double c = 1.2; 
// bool isGreat = false;
// char d = 'a';
// string e = "This is String";
// Console.WriteLine("Hello, World!");
// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);
// Console.WriteLine(isGreat);
// Console.WriteLine(d);
// Console.WriteLine(e);
// Console.ReadLine();


/////////////////////////////////////////////////////////////////////////////////////////

/* Type Casting Example:
 [Two Types:]
 1.Implicit Casting :
  -->char to int to long to float to double 
 2.Explicit Casting:
  -->int a = (int) 2.9;
*/


// int f = (int)2.9; //This is Explicit Casting
// int x = 1;
// double y = x;
// float z = 'a';
// float var = Convert.ToInt64(8.54);
// Console.WriteLine(x);
// Console.WriteLine(y);
// Console.WriteLine(z);
// Console.WriteLine(f);
// Console.WriteLine(var);
// Console.ReadLine();




// Console.WriteLine("Enter Your Name");
// string name = Console.ReadLine();
// Console.WriteLine("Hey Hellow " + name);

// Console.WriteLine("How Much Money do you want?");
// string money = Console.ReadLine();
// Console.WriteLine("You Will Get 10 more rupees:" + (Convert.ToInt64(money) + 5));//Brackets Priority First
// Console.ReadLine(); 

/////////////////////////////////////////////////////////////////////////////////////////
/*
 Operators in C#:
  1.Arithmetic Operators[+,-,/,*]
  2.Assignment Operators[Assign number to another number]
  3.Logical Operators[AND,OR,etc]
  4.Comparison Operators[Compare with >,<,<=,>=]
 */

//Arithmetic Operators:
// int a = 8;
// int b = 4;
// Console.WriteLine("The Value of a + b is: " + (a + b));
// Console.WriteLine("The Value of a - b is: " + (a - b));
// Console.WriteLine("The Value of a / b is: " + (a / b));
// Console.WriteLine("The Value of a * b is: " + (a * b));
// Console.ReadLine(); 

//Assignment Operators:
// int a = 10;
// int b = a;
// b += 6;
// b -= 6;
// b /= 5;
// b *= 2;
// Console.WriteLine(b);
// Console.ReadLine();

//Logical Operators 
//AND Operators
//Console.WriteLine(true && false);
//Console.WriteLine(true && true);
//Console.WriteLine(false && false);

//OR Operators
//Console.WriteLine(true || false);
//Console.WriteLine(true || true);
//Console.WriteLine(false || false);

//NOT Operators 
//Console.WriteLine(!true);
//Console.WriteLine(!false);

//Comparison Operators
//Console.WriteLine(10 > 5);
//Console.WriteLine(10 >= 5);
//Console.WriteLine(10 <= 5);
//Console.WriteLine(10 != 5);
//Console.WriteLine(10 == 5);
//Console.ReadLine(); 

/////////////////////////////////////////////////////////////////////////////////////////

//Math Class in C#

//int a = Math.Max(10,15);
//int b = Math.Min(10, 15);
//int c = Math.Abs(+38);
//double d = 12.89898;
//Console.WriteLine(Math.Sqrt(36));
//Console.WriteLine(a);   
//Console.WriteLine(b);
//Console.WriteLine(c);
//Console.WriteLine(Math.Round(d));

/////////////////////////////////////////////////////////////////////////////////////////

//String Methods:

//string hello = "Hello World this is Arpit";
//Console.WriteLine(hello.Length);
//Console.WriteLine(hello.ToUpper());
//Console.WriteLine(hello.ToLower());
//Console.WriteLine(hello + "You Are Nice");
//Console.WriteLine(string.Concat(hello, "You Are Nice"));

//String Interpolation:
//string name = Console.ReadLine();
//string candies = Console.ReadLine();
//Console.WriteLine($"Your Name is {name}. You Will get {candies} candies");

//Escape Sequence Character:
//string hello = "Hello World this is Arpit";
//string hello1 = "Hello World this  is \"Arpit\""; // \"'? any
//string hello2 = "Hello World this \n is Arpit";  // \n for new line
//Console.WriteLine(hello[6]);
//Console.WriteLine(hello.IndexOf("Hello")); //for index number
//Console.WriteLine(hello.IndexOf("Ar"));
//Console.WriteLine(hello.Substring(8));  //ex:1,2 will start from string
//Console.WriteLine(hello1);
//Console.WriteLine(hello2);
//Console.WriteLine(hello.Replace("Arpit","Patel"));

/////////////////////////////////////////////////////////////////////////////////////////

//If,Else-If,Else Condition:
// Console.WriteLine("Enter Your Age");
//string ageStr = Console.ReadLine();
// int age = Convert.ToInt32(ageStr);
// bool isActive = false;
////if (age > 18 && isActive)
////{
////    Console.WriteLine("You Can Drive");
////}
////else if (age <2)
// if(age < 2 && isActive)
// {
//    Console.WriteLine("You Are Just Born and active");
// }
// else if(age <16 || isActive)
// {
//     Console.WriteLine("You Are Below 18 or active");
// }
// else if(age < 75)
// {
//     Console.WriteLine("You Can Drive");
// }
// else
// {
//     Console.WriteLine("You CanNot Drive");
// }


/*  Ternary(Conditional) Operator:
    It is Short Form Of if-else Statement
*/

//int x = 20;
//int y = 10;

//var result = x > y ? "x is greater than y" : "x is less than or equal to y";
//Console.WriteLine(result);

//if (x > y)
//{
//    Console.WriteLine("x is greater than y");
//}
//else
//{
//    Console.WriteLine("x is less than or equal to y");
//}

//Switch-Case Statement:

//int age = 24;

//switch(age)
//{
//    case 12:
//        Console.WriteLine("You are not eligible");
//        break;
//    case 24:
//        Console.WriteLine("You are eligible and enjoy");
//        break ;

//    default:
//        Console.WriteLine("Enjoy..!!");
//        break;

//}

/////////////////////////////////////////////////////////////////////////////////////////


/* Loops In C#
   Loops are used to execute one or more statements
   multiple times until a specified condition is fulfilled.
*/

/* [While Loop]:
    while loop is an Entry Controlled Loop in C#. 
    The test condition is given in the beginning of 
    the loop and all statements are executed till the 
    given boolean condition satisfies, when the condition 
    becomes false, the control will be out from the while loop
 */

//int x = 0;
//while(x < 10)
//{
//    Console.WriteLine(x);//Console.Writeline(x+1);
//    x++;
//}

//[Do-While Loop]:
// do-while means that one time giving output after that condition will check.

//int x = 0;
//do
//{
//    Console.WriteLine(x+1);//Console.Writeline(x+1);
//    x++;
//}
//while (x > 10);


/*[For Loop]:
    The for loop executes one or more statements multiple 
    times as long as the loop condition is satisfied. If the 
    loop condition is true, the body of the for loop is executed. 
    Otherwise, the control flow jumps to the next statement after the for loop.
*/

//for(int x = 0; x < 10; x++)
//{
//    Console.WriteLine(x+1);
//}


/* Break and Continue 
 Break:-Leave this loop forever
 Continue:-Leave this particular iteration of the loop.
 We Can Use this in All Loops.
 */


//for (int x = 0; x < 10; x++)
//{
//    if(x == 0)
//    {
//        continue;//to leave particular iteration.
//    }
//    Console.WriteLine(x + 1);
//    break; //to leave the loop.
//}
/////////////////////////////////////////////////////////////////////////////////////////

/* Array in C#:
  -->It is a Variable which helps to store multiple elements
     of the same type.
    *Array Types:
     1.1D Array.
     2.2D Array(Multidimensional).

    Create an array of four elements, and add values later
    string[] cars = new string[4];

    Create an array of four elements and add values right away 
    string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

    Create an array of four elements without specifying the size 
    string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

    Create an array of four elements, omitting the new keyword, and without specifying the size
    string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
 */

//  int[] a = {10,20,30,40,50 };
//  string[] cars = new string[4] {"Maruti", "Kia", "BMW" , "Audi" };

//  //for(int i = 0; i < cars.Length; i++)
//  //{
//  //    Console.WriteLine(cars[i]);
//  //}

//  foreach (string car in cars)
//  {
//      Console.WriteLine(car);

//  }



/////////////////////////////////////////////////////////////////////////////////////////

/*List in C#:
 It Is same as Array used to store multiple
 values in single varialble.
 Syntax: List<datatype> name of list = new >List<datatype>();
 */


//List<string> cars = new List<string>();
//cars.Add("Maruti");
//cars.Add("Kia");
//cars.Add("BMW");
//cars.Add("Audi");

////for(int i = 0; i < cars.Count; i++)
////{
////    Console.WriteLine(cars[i]); 
////}

//foreach(string car in cars)
//{
//    Console.WriteLine(car);
//}



/////////////////////////////////////////////////////////////////////////////////////////

/*Methods in C#:
    A method is a block of code which only runs when it is called.
    You can pass data, known as parameters, into a method.
    Methods are used to perform certain actions, and they are also known as functions
*/
/////////////////////////////////////////////////////////////////////////////////////////

//OOPs: Classes And Objects 



//using CSharp_Practice;

//Test name = new Test();
//Console.WriteLine(name.getHealth());
//name.setHealth(45);
//Console.WriteLine(name.getHealth());


//using CSharp_Practice;

//Test obj = new Test();
//obj.num1 = 30;
//obj.num2 = 80;
//obj.Addition();
//obj.Substract();
//obj.Multiplication();
//obj.Division();

//Test obj2 = new Test();
//obj2.num1 = 40;
//obj2.num2 = 90;
//obj2.Addition();
//obj2.Substract();
//obj2.Multiplication();
//obj2.Division();


/////////////////////////////////////////////////////////////////////////////////////////


//Methods:

//using CSharp_Practice;

//int a = 10;
//int b = 23;
//Test Object = new Test();
//int c = Object.MaxValue(a,b);
//Console.WriteLine("MaxValue is:" + c);
//Object.Printmsg();
//Object.Sum(a,b);
//int result = Object.Factorial();
//Console.WriteLine("Factorial is:" + result); 
//Console.ReadLine(); 


/////////////////////////////////////////////////////////////////////////////////////////

//Inheritance:Process of inherit the properties and behavior of class into new class.

//using static CSharp_Practice.Test;

//Maruti Object = new Maruti();
//Object.model = "Alto";
//Object.color = "Black";
//Object.price = 200000;
//Object.speed = 1000;
//Object.mileage = 22.47f;
//Object.PrintCar();
//Object.DisplayMileage();
//Object.DisplaySpeed();



/////////////////////////////////////////////////////////////////////////////////////////

// Polymorphism:
// Method Overloading  :

//using CSharp_Practice;

//Test Object = new Test();
//Object.Add(10,20);
//Object.Add(20.121f ,30.5454f);
//Object.Add("Arp" , "it");


/////////////////////////////////////////////////////////////////////////////////////////

//Encapusulation:

using CSharp_Practice;
using System.Runtime.InteropServices;

Account Object = new Account();
Object.SetBalance(-12);
Object.GetBalance();


