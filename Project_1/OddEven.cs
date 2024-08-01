namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number;
            Console.WriteLine("Please provide input to check if the number is even or odd ");
            Number = Convert.ToInt32(Console.ReadLine());

            if (Number % 2 == 0)
            {
                Console.WriteLine("The Number is Even");
            }
            else
            {
                Console.WriteLine("The Number is Odd");
            }
        }
    }
}