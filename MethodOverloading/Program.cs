namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var answer 1
            Add(2, 6);
            Console.WriteLine(Add(2, 6));

            //answer 2 
            Add(9, 7);
            Console.WriteLine(Add(9, 7));

            //answer 3 
            Add(3, 10, true);
            Console.WriteLine(Add(3, 10, true));
        }

        //add method - takes 2 parameters
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        //add method - 2 decimal paramenters
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        //add method - 2 int, 1 bool
        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;

            if (isTrue == true && num1 + num2 == 1)
            {
                return $"{num1 + num2} dollar";
            }
            else if (isTrue == true && num1 + num2 >= 1)
            {
                return $"{num1 + num2} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }

    }
}
