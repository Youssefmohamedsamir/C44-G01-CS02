using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Evolution of switch in C#
            //object number = 11.11; //Boxing
            #region Example C# 7.0 01 [Pattern matching on types]



            // No created Jump table
            //switch (number) {

            //    case int value://Un Boxing
            //        Console.WriteLine("integer");
            //        break;

            //    case decimal value:
            //        Console.WriteLine("decimal");
            //        break;

            //    case float value:
            //        Console.WriteLine("Float");
            //        break;

            //    case double value:
            //        Console.WriteLine("Double");
            //        break;

            //    default: Console.WriteLine("Not have Type");
            //        break;

            //}

            #endregion

            #region C# 7.0 Example02 [Cadse Guards (When)]

            //switch (number)
            //{

            //    case int value when value < 10:
            //        Console.WriteLine("integer");
            //        break;

            //    case decimal value:
            //        Console.WriteLine("decimal");
            //        break;

            //    case float value:
            //        Console.WriteLine("Float");
            //        break;

            //    case double value when value > 5.5 && value < 10.10:
            //        Console.WriteLine("Double Between 5.5 and 10.10");
            //        break;

            //    default:
            //        Console.WriteLine("Not have Type");
            //        break;

            //}


            #endregion

            #region C# 7.0 Example 03 [User_Defined Data Type]

            //object input = new Person() { id = 15, name = "Youssef", age = 20 };

            //    switch (input)
            //{
            //    case int value when value > 10:
            //        Console.WriteLine("Int Value Greater than 10");
            //        break;

            //    case Person value when value.id == 10 && value.age == 20:
            //        Console.WriteLine("Person");
            //        break;
            //    case string value:
            //        Console.WriteLine("String");
            //        break;
            //    default: Console.WriteLine("No matching");
            //        break;
            //}


            #endregion

            #endregion

            #region in C# 8.0 Switch Expression [Syntax easy Without alies name and deal with nullable type]


            #region Example01 - Pattern matching without alias name

            //object number = 5.6;

            //switch (number)
            //{
            //    case int  when (int)number > 5.5 && (int)number < 10.10 :
            //        Console.WriteLine("integer");
            //        break;
            //    case double :
            //        Console.WriteLine("Double");
            //        break;

            //    case float :
            //        Console.WriteLine("float");
            //        break;

            //    default: Console.WriteLine("No matching");
            //        break;
            //}

            #endregion

            #region Switch case Before Switch Expression
            //string option = Console.ReadLine() ?? "0";
            //string message;

            //switch (option)
            //{
            //    case "1":
            //        //Console.WriteLine("Option 01");
            //        message = "option 01";
            //        break;

            //    case "2":
            //        //Console.WriteLine("Option 02");
            //        message = "Option 02";
            //        break;

            //    case "3":
            //        //Console.WriteLine("Option 03");
            //        message = "Option 03";
            //        break;
            //    default:
            //        //Console.WriteLine("Invalid Option");
            //        message = "Invalid Option";
            //        break;
            //}

            //Console.WriteLine(message);

            #endregion

            #region After Switch Expression and it [return]
            //Console.WriteLine("Enter Your Number: ");

            //string Option = Console.ReadLine() ?? "0";

            //string message;

            //message = Option switch
            //{
            //    "1" => "Option 01 ",
            //    "2" => "Option 02" ,
            //    "3" => "Option 03",
            //    _ => "No Matching"

            //};
            //Console.WriteLine(message);

            #endregion

            #region Example 2 [Property Pattern]
            //Person person = new Person() { id = 20 , name = "Youssef" , age = 50 };

            //string message = person switch
            //{
            //    { name : "Ahmed" , age : 10  } => "Hello Ahmed",
            //    { name : "Youssef" , age : 20 } => "Hello Handassa",
            //    { name : "Abdo" , age : 10 } => "Hello Doctor",
            //    _ => "Enter Ahmed or Abdo or Youssef"//discard

            //};

            //Console.WriteLine(message);


            #endregion

            #region Example 03 [Nullable Type - Relational Patterns [Partially]]

            //number = null => Nullable type
            // num = 10 => positive type
            // num = -10 => negative type
            // num = 0 => Zero


            //int? num = 10;
            //string Reasult = num switch
            //{
            //    null => "Nullable type",
            //    int X when X > 0 => "positive number",
            //    int X when X < 0 => "Negative number",
            //    0 => "Zero"

            //};

            //Console.WriteLine(Reasult);

            #endregion


            #endregion

            #region in C# 9.0 [Switch Expression With Relational Pattern - logical Patterns - Enhanced Property]

            #region Example 01 [Relational Patterns]
            //Number Less than 10
            //Number between 10 and 20
            //Number Greater than 20

            //int number = 20;
            //string Reasult = number switch
            //{

            //    < 10 => "Less than 10",
            //    >= 10 and <= 20 => "Greater than 10",
            //    >20 => "Nuber is Between 10 and 20"

            //};






            #endregion

            #region Example 02 [ Logical Patterns (and , or )]
            //Number Between 1 and 9
            //Number Between 10 and 20
            // Number is Zero
            //Number OutSide the range

            //int number = 10;
            //string Reasult = number switch
            //{
            //    > 0 and < 10 => "Number is between 1 and 9",
            //    >=10 and <= 20 => "Number is Between 10 and 20",
            //    0 => "Number is Zero",
            //    _ => "Number out side The Range"
            //};

            //Console.WriteLine(Reasult);




            #endregion

            #region Examle 03 [Enhanced Property Matching]

            //Person is Samy and His Age is Greater Than 10
            //Person is Youssef and His Age is Between Than 20 and 30
            //Person is Age is Between 50 and 60
            //Any One Else [Sorry But We Don't Know You ]

            //Person person = new Person() { id = 10, name = "Youssef", age = 21 };

            //string Result = person switch
            //{
            //    { name: "Samy", age: > 10 } => "Hello Samy",
            //    { name: "Youssef", age: >= 20 and <= 30 } => "Hello Handassa",
            //    { age: > 50 or < 60 } => "Hello olde Man",
            //    _ => "Sorry We Dont Know You "


            //};




            #endregion

            #endregion

            #region Looping [Iteration]

            // Code large size (Il) large
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);
            //10 Steps and it Using Memory and it effect in Run time and it hard to maintain


            #region Using For Loop
            //int[] numbers = { 1, 2, 3, 4, 5 };

            ////easy optimized less memory  avoid duplication in Code
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            ////32 steps and it easy to mantenance and you can access in iteration index in array and you can modifiy in array

            //for (int i = 0; i <= numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
        }
        // for is fater than foreach not need to call function  and it not safe

        #endregion


        #region Using Foreach Loop

        //Using get eliminator the number that in order and it take copy of array and not have index of array
        //is slower than for and cant modifiy during iteration and it safe
        //foreach (int var in numbers)
        //{
        //    Console.WriteLine(var);
        //}

        #endregion

        #endregion

        #region while and do while
        //int number;
        //bool isParsed;
        //do
        //{
        //    Console.WriteLine("Please Enter a Even Number : ");
        //      isParsed = int.TryParse(Console.ReadLine(), out  number); 

        //} while (!isParsed || number % 2 == 1 );

        //Console.WriteLine($"{number} is an Even number");


        //Take a number from user and print
        //a sequance of number from Entered number to 10

        //Console.WriteLine("Enter a Number : ");
        //bool isParsed = int.TryParse(Console.ReadLine(), out int number);
        //if (isParsed)
        //{
        //    while (number <= 10)
        //    {
        //        Console.WriteLine(number);
        //        number++;
        //    }
        //}


        #endregion

        #region String 

        ////it is referance data type and it is immutable type
        //// any modifiy in string it lead to consume memory
        //// Each character in the string corresponds to a single char

        //string name;
        ////Declar For Referance string 'name'
        ////Referance 'name' is refereing to default Value of Referance typr [Null]
        ////CLR Will Allocate 4 Byte At Stack From Referance 'name'
        ////0 Byte Allocateed at Heap

        //name = new string("Route");
        ////Allocate Required bytes At Heap [10 Bytes]
        ////Initialize Allocateed Bytes
        ////Call user defined Constractor
        ////Assign Referance 'name' With Address of Allocated Object

        //Console.WriteLine($"Name {name}");
        //Console.WriteLine($"HashCode Name {name.GetHashCode()}");

        //string name2 = "Route";//string litteral
        ////CLR Will Checks if The String 'Route' is Already Exists
        ////in string Pool
        ////If is not exist => Add new String in Pool
        ////IF IT IS Exist => Reuse same Memory Location

        //Console.WriteLine($"name02 {name2}");//Route
        //Console.WriteLine($"Hashname02 {name2.GetHashCode()}");


        //char X = 'Y';
        //Console.WriteLine((int)X);// default /0 ==> space if (int) ==> "0"

        //string name01 = "Raneem"; // 2 Referances (name01 , name02)
        //string name02 = "Youssef";// Unreachable Object

        //Console.WriteLine($"name01 : {name01}");
        //Console.WriteLine($"HashCode Of name01 : {name01.GetHashCode()}");
        //Console.WriteLine($"name02 : {name02}");
        //Console.WriteLine($"HashCode Of name02 : {name02.GetHashCode()}");


        //Console.WriteLine($"HashCode Of name01 : {name01.GetHashCode()}");

        //name02 = name01;
        //Console.WriteLine("After Changes");

        //Console.WriteLine($"HashCode Of name02 : {name02.GetHashCode()}");

        #endregion

        #region String Builder
        //mutable datatype and it stored as linked list in memory alot of nodes liked with them
        StringBuilder message;
        //Declar Referance From Type stringBuilder 'Message'
        //Referance 'Message' is refere to Null
        //CLR Will Allocate 4 Types At stack as address For Referance 'Message'
        //0 Bytes Allocated at heap

        //message = new StringBuilder("Hello");

        //Console.WriteLine(message);
        //Console.WriteLine(message.GetHashCode());

        //message.Clear();
        //message.Append("Route");
        //Console.WriteLine("After Changing Message");
        //Console.WriteLine(message);
        //Console.WriteLine(message.GetHashCode());

        //message.Append("Academy");

        //Console.WriteLine(message);
        //Console.WriteLine(message.GetHashCode());

        //Referance the same place
        //we use string without stringBuilder Beacause it easy to use 
        // array(String) it easy to deal with linked list(StringBuilder)




        #endregion
    }
}
}
