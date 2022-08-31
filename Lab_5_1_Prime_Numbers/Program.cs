using Pizzazz;

namespace Lab_5_1_Prime_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            { 
            string menu = "This Program will find any prime number, in order, from first prime number on! \nWhat number Prime  would you like?";
            string userinput = "";
            //flourish
            ProgName ThisProg = new ProgName("Prime Number-ator");
            int num = 0;
            while (true)
            {
                ThisProg.PrintHead(menu, out userinput);
                userinput = userinput.Trim();

                if ((int.TryParse(userinput, out num)))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Entry! Please enter a whole number! \n  Press Any Key to Continue.");
                    Console.ReadKey();
                }


            }
            int prime = PrimeNumbers.GetPrime(num);
                ThisProg.PrintHead();
            Console.WriteLine($"The number {num} prim is {prime}.");
            Thread.Sleep(700);

            string urpeat = "";
            while (true)
            {

                Console.Write("\nWould you like to find another prime number? (y/n): ");
                urpeat = Console.ReadLine();

                if ((urpeat.Trim().ToLower())[0] == 'y' || (urpeat.Trim().ToLower())[0] == 'n')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Entry!");
                    urpeat = "";
                }


            }


            if ((urpeat.Trim().ToLower())[0] == 'y'){ break;}

        }



        
       }

       




       








    }


    public class PrimeNumbers
    {

        public static int GetPrime(int _qNum)
        {
            if (_qNum >= 1)
            {
                List<int> tempPrimes = new List<int>();

                bool basenum = false;
                int index = 0;
                int checknum = 1;
                while (index < _qNum)
                {

                    checknum++;


                    int z = checknum;
                    foreach (int j in tempPrimes)
                    {
                        basenum = false;
                        int e = z % j;
                        if (e == 0)
                        {
                            basenum = true;
                            break;
                        }
                    }

                    if (!basenum)
                    {
                        tempPrimes.Add(z);
                        Console.WriteLine(z);
                        index++;
                    }




                }
                return tempPrimes[_qNum - 1];
            }
            else { return -1;}


        }



            
         
         
         


       
       
    }


    }










