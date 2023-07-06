namespace LineComparisionProblems
{
    public class Length
    {
        public void LineLength()
        {
            Console.Write("Enter value of x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value of y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value of x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value of y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            int dx = x2 - x1;
            int dy = y2 - y1;
            double lineLength = Math.Sqrt(dx * dx + dy * dy);

            Console.WriteLine("Length is: " + lineLength);
        }
    }
}