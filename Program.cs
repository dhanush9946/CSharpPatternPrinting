public class Pattern
{
    public static void Main()
    {
        int row, col, num;

        Console.WriteLine("Enter the lengthh of the row");
        num = Convert.ToInt32(Console.ReadLine());

        for (row = 0; row < num; row++)
        {
            for (col = 0; col <= row; col++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}