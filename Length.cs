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
            double lineLength1 = Math.Sqrt(dx * dx + dy * dy);

            Console.WriteLine("Length is: " + lineLength1);
            Console.WriteLine();


            Console.Write("Enter value of x3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value of y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value of x4: ");
            int x4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value of y4: ");
            int y4 = Convert.ToInt32(Console.ReadLine());

            int dx2 = x4 - x3;
            int dy2 = y4 - y3;
            double lineLength2 = Math.Sqrt(dx2 * dx2 + dy2 * dy2);

            Console.WriteLine("Length is: " + lineLength2);
            Console.WriteLine("--------------------------------------------------");

            /* Converting the values of line1 and line2
		 * into string so that we can use equals and compare
		 * method
		 */
            string Line_1 = lineLength1.ToString();
            string Line_2 = lineLength2.ToString();

            /*
             * Checking if the length of both the lines are equal or not.
             */
            if (Line_1.Equals(Line_2))
            {
                Console.WriteLine("Length of Line1 and Line2 are equal");
            }
            else
            {
                Console.WriteLine("Length of Line1 and Line2 are not equal");
            }
            
            Console.WriteLine("--------------------------------------------------");


            /*
             * Checking if the length of line 1 
             * is less than or greater than line 2
             */
            int compare = Line_1.CompareTo(Line_2);

            if (compare > 0)
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
            else
            {
                Console.WriteLine("Line 1 is less than Line 2");
            }
        }
    }
}