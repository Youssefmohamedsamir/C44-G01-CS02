namespace Assinment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //1 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //     Example
            //     Input: 5
            //     Output: 1, 2, 3, 4, 5

            //Console.WriteLine("Enter the Number: ");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int number);

            //if (isparsed)
            //{
            //while (number >= 1)
            //{
            //    Console.WriteLine(number);
            //    number--;
            //}
            //}


            #endregion

            #region Q2
            //2 - Write a program that allows the user to insert an integer then
            //  print a multiplication table up to 12.
            //  Example
            //  Input: 5
            //  Outputs: 5 10 15 20 25 30 35 40 45 50 55 60


            //Console.WriteLine("Enter the Number: ");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int number);

            //if (isparsed)
            //{
            //    while ( number <= 60)
            //    {
            //        Console.WriteLine(number);
            //        number = number + 5;
            //    }
            //}




            #endregion

            #region Q3

            //3 - Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //    Example:
            //    Input: 15
            //    Output: 2 4 6 8 10 12 14

            //Console.WriteLine("Enter the Number: ");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int number);

            //if (isparsed )
            //{
            //    for ( int i = 2; i < number;)
            //    {
            //        Console.WriteLine(i);
            //        i = i + 2;

            //    }
            //}


            #endregion

            #region Q4

            //4 - Write a program that takes two integers then prints the power.
            //  Example:
            //  Input: 4 3
            //  Output: 64
            //  Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64

            //Console.WriteLine("Enter the First Number 1: ");
            //bool Reasult = int.TryParse(Console.ReadLine(), out int num1);

            //Console.WriteLine("Enter the First Number 2 : ");
            //bool Reasult2 = int.TryParse(Console.ReadLine(), out int num2);

            //int Reasult3 = 1;

            //for (int i = 0; i < num2; i++)
            //{
            //     Reasult3 = Reasult3 * num1;   
            //}
            //Console.WriteLine(Reasult3);
            #endregion

            #region Q5

            //5 - Write a program to enter marks of five subjects and calculate total, average and percentage.
            //    Example
            //    Input: -Enter Marks of five subjects: 95 76 58 90 89
            //    Output: Total marks = 408
            //    Average Marks = 81
            //    Percentage = 81

            //Console.WriteLine("Enter five numbers to get reasult: ");
            //int[] arr = new int[5];

            //int sum = 0;


            //for (int i = 0; i < arr.Length; i++)
            //{

            //    arr [i] = int.Parse(Console.ReadLine());
            //    sum = sum + arr[i];
            //}

            //int Average = sum / arr.Length;
            //int Persentage = sum;


            //Console.WriteLine(sum);
            //Console.WriteLine(Average);
            //Console.WriteLine(Persentage);

            #endregion

            #region Q6
            //6 - Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.WriteLine("Enter the string: ");

            //string X = Console.ReadLine();

            //Console.WriteLine(X.Reverse());



            #endregion

            #region Q7

            //7- Write a program to allow the user to enter int and print the REVERSED of it.

            Console.WriteLine("Enter the Integer Number: ");

            bool isparsed = int.TryParse(Console.ReadLine(), out int number);

            if (isparsed)
            {
                string X = Console.ReadLine();

                Console.WriteLine(X.Reverse());
            }
            else
            {
                Console.WriteLine("Not integer number");
            }





            #endregion

            #region Q8

            //8 - Write a program in C# Sharp to find prime numbers within a range of numbers.
            //    Test Data:
            //         Input starting number of ranges: 1
            //         Input ending number of range: 50

            //         Expected Output :
            //         The prime number between 1 and 50 are:
            //         2 3 5 7 11 13 17 19 23 29 31 37 41 43 47

            Console.WriteLine("Input starting number of ranges : ");
            int X = Console.Read();
            Console.WriteLine("Input ending number of range: ");
            int Y = Console.Read();

            for (int i = X; i <= Y; i++)
            {
                bool isprime = true;
                if (i <= 1)
                {
                    isprime = false;
                }
                else
                {
                    for (int j = 2; j < Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                            isprime = false;
                        break;
                    }
                }

                if (isprime)
                {
                    Console.WriteLine($"{i} is prime number ");
                }

            }






            #endregion

            #region Q9 
            //            9 - .Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Test Data:
            // Enter a number to convert: 25
            //Expected Output :
            //The Binary of 25 is 11001.

            //مش عارف احل اخر 3 اسئله

            #endregion
        }
    }
}
