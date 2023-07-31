namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int favNum = r.Next(1, 3);
            int response = 0;

            while (response != favNum)
            {
                Console.Write("Give me a number: ");
                response = int.Parse(Console.ReadLine());

                if (response < favNum)
                {
                    Console.WriteLine($"Too low!\nYour guess: {response}");
                }
                else if (response > favNum)
                {
                    Console.WriteLine($"Too high!\nYour guess: {response}");
                }
                else
                {
                    Console.WriteLine($"Correct! {response} was my favorite number.");
                }
            }


        }
    }
}
