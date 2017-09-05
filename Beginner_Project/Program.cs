using System;
using Beginner_Project.Math;

namespace Beginner_Project
{

    class Program
    {
        public static void Main(string[] args)
        {

            //variables
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string name = "Jacob";
            bool isWorking = true;


            //all of the variables can start with 'var' instead of the specific context

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(name);
            Console.WriteLine(isWorking);

            //here is how you can use placevalues
            Console.WriteLine("{0}{1}",byte.MinValue,byte.MaxValue);

            //constant declaration
            const float Pi = 3.14f;

            Console.WriteLine(Pi);

            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            //arrays
            var numbers = new int[3];
            numbers[0] = 1;
            //intial values are set to 0 or false if booleans
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "Jack", "John", "Mary" };

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

            //strings
            var firstName = "Jacob";
            var lastName = "Leatherwood";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";

            var newText = @"Hi John
              Look into the following paths
              c:\folder1\folder2
              c:\folder3\folder4";
            Console.WriteLine(text);
            Console.WriteLine(newText);

            //enums (name/value pairs) use when you have a number of related constants
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); //casting the method to an integer

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); //casting from an integer to the method

            //convert enum to a string, or string to an enum
            Console.WriteLine(method.ToString()); //Console.WriteLine ALWAYS converts to a string automatically

            var methodName = "Express";
            //parse means to change from a string to a different type
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName); //using casting in front of Enum to change from an object to the ShippingMethod
            Console.WriteLine(shippingMethod);

            //reference types vs value types

            //value types example

            var a = 10;
            var b = a;
            b++;
            //a will return 10 at this point
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            //reference type example
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]:{0} array2[0]:{1}",array1[0], array2[0]));

            //when we makes changes to either array1 or array2, the change will be made in the HEAP, which is why they are called REFERENCE TYPES


        }
    }


}


