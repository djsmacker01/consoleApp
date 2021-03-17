using System;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)

        {


            /*Questions 1. Create an application which accepts the name and the last name,space separated,as
             * input then prints out the name in one row and last name in another row
             

             */

            Console.WriteLine("Enter your full name, blank space separated");
            string fullName = Console.ReadLine();

            int blankPosition = fullName.IndexOf(' ');
            string name = fullName.Substring(0, blankPosition);
            string lastName = fullName.Substring(blankPosition + 1);

            Console.WriteLine(name);
            Console.WriteLine(lastName);










            // Working with String
            /* 
              *Substring, IndexOf, LastIndexOf
              *Contains, StartsWith, EndsWith
              *Remove, Insert
              *ToLower, ToUpper
             */
            //Substring

            //Example 2. write an application that for two provided inputs (name and lastname) print out the full name with spacebar

            //Console.WriteLine("What is your first name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("What is your last name?");
            //string lastName = Console.ReadLine();

            //string fullName = name + " " + lastName;
            //Console.WriteLine($"Your full name is {fullName}");

            //Console.ReadLine();

            //TYPE CONVERSION

            //IMPLICIT CONVERSION

            //double b = 12.87;
            //int a = 4;
            //b = b + a;
            // the compiler can stores the result as a variable

            //int x = 21;
            //int y = 5;
            //double p = (double) x / y;

            //using the convert class

            //int a = 15;
            //string s = a; // this is not allow, cannot implicittly convert string to int. to do that we need to introduced;

            //int c = 15;
            //string s1 = Convert.ToString(c); // or string s2 = c.ToString();
            //Console.WriteLine($" The result of p is now {s1}");

            //Console.ReadLine();




            //Console.WriteLine("Enter The First Interger");
            //int first = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter The Second Interger");
            //int second = Convert.ToInt32(Console.ReadLine());

            //int result = first + second;
            //Console.WriteLine($"The result is {result}");

            //Console.ReadKey();

            // working with substring

            //string testString = "HEllo guys, im learnig C#. wow, it was awesome";

            //string partWithLength = testString.Substring(7, 10);
            //string partWithoutLength = testString.Substring(10);
            //int charPosition = testString.IndexOf("l");
            //int stringPosition = testString.IndexOf("some");
            //int charPosWithStartIndex = testString.IndexOf('s', 10);
            //int stringPosWithStartIndex = testString.IndexOf("some", 10);
            //int lastPosition = testString.LastIndexOf('E');
            //int stringLastPosition = testString.LastIndexOf("is");
            //bool containResult = testString.Contains("some");
            //bool startsWithResult = testString.StartsWith("guys");
            //bool endsWithResult = testString.EndsWith("awesome");
            //string loweredString = testString.Remove(10);
            //string loweredStringWithCount = testString.Remove(10, 9);
            //string stringWithInsert = testString.Insert(46, "UPDATED");
            //string toLowerCase = testString.ToLower();
            //string toUpperCase = testString.ToUpper();

            //Console.WriteLine(toUpperCase);
            //Console.WriteLine(partWithLength);
            // Console.WriteLine(partWithoutLength);
            //Console.WriteLine(charPosition);
            //Console.WriteLine(stringPosition);
            //Console.WriteLine(charPosWithStartIndex);
            //Console.WriteLine(stringPosWithStartIndex);
            //Console.WriteLine(lastPosition);
            //Console.WriteLine(stringLastPosition);
            //Console.WriteLine(containResult);
            //Console.WriteLine(startsWithResult);
            //Console.WriteLine(endsWithResult);
            //Console.WriteLine(loweredString);
            //Console.WriteLine(loweredStringWithCount);
            //Console.WriteLine(stringWithInsert);
            //Console.WriteLine(toLowerCase);


            Console.ReadKey();
        }
    }
}
