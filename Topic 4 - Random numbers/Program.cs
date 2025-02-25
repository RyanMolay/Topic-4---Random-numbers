using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Topic_4___Random_numbers
{
    internal class Program
    {
        private static bool boolean;

        static void Main(string[] args)
        {//1 
            /*  Random numGen = new Random();
               int minNumber, maxNumber;
               Console.WriteLine("Enter a minumum and a maximum that 5 numbers will generate in");
               Console.WriteLine("Enter a low number:");
               minNumber = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Now enter a high number");
               maxNumber = Convert.ToInt32(Console.ReadLine());
               if (maxNumber < minNumber) 
               {
                   Console.WriteLine("Huh!? Your trying to wreck the program? BEGONE!!!");
                   boolean = true;
               }
               Console.WriteLine($"You have selected {minNumber} and {maxNumber}");
               Console.WriteLine("If you generate 5 random numbers in between those two numbers they would be...");
               Console.WriteLine(numGen.Next(minNumber,(maxNumber+1)));
               Console.WriteLine(numGen.Next(minNumber, (maxNumber + 1)));
               Console.WriteLine(numGen.Next(minNumber, (maxNumber + 1)));
               Console.WriteLine(numGen.Next(minNumber, (maxNumber + 1))); 
               Console.WriteLine(numGen.Next(minNumber, (maxNumber + 1)));*/



            //2
            /*  int num1, num2;

              Random numGen = new Random();
              num1 = numGen.Next(1,7);
              num2 = numGen.Next(1, 7);
              Console.WriteLine($"Your two number are {num1} and {num2}");
              Console.WriteLine();
              Console.WriteLine($"If you add them together they would be... {num1+num2}");*/

            
            int minNum,maxNum,num1,num2,num3,fixNum ,fixNum2;
            Double dec1, dec2, dec3;
            Random randNum = new Random();

            
            Console.WriteLine("Enter a minumum and a maximum that 3 decimal numbers will generate in");
            Console.WriteLine("Enter a low number (NO DECIMAlS!):");
            

            minNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now Enter a high number (NO DECIMALS!)");
            maxNum = Convert.ToInt32(Console.ReadLine());

            if (maxNum < minNum) 
            {
              fixNum = minNum;
              fixNum2 = maxNum; 
              maxNum = fixNum;
              minNum = fixNum2;
            }
           
           
           
            Console.WriteLine($"You have selected {minNum} and {maxNum}");  
            num1 = randNum.Next(minNum, maxNum);
            num2 = randNum.Next(minNum, maxNum);
            num3 = randNum.Next(minNum, maxNum);
            dec1 = (num1 + randNum.NextDouble());
            dec2 = (num2 + randNum.NextDouble());
            dec3 = (num3 + randNum.NextDouble());
            Console.WriteLine("If you generate 3 random decimal numbers in between those two numbers they would be...");
            Console.WriteLine(dec1);
            Console.WriteLine(dec2);
            Console.WriteLine(dec3);
            




















        }

        
    }
}
