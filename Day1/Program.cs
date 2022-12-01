namespace AoC01122022
{
    internal class Program
    {
        static void Main()
        {
            string[] lines;
            List<int> elvesTotal = new List<int>();

            string text = File.ReadAllText(@"[txt data input]");
            lines = text.Split("\r\n");
            int sum = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != "")
                {
                    sum += Convert.ToInt32(lines[i]);
                }
                else
                {
                    elvesTotal.Add(sum);
                    sum = 0;
                }
            }
            int combined = elvesTotal.Count();
            int sumThree;
            elvesTotal.Sort();
            sumThree = elvesTotal[combined - 1] + elvesTotal[combined - 2] + elvesTotal[combined - 3];
            //Answer 1
            Console.WriteLine(elvesTotal.Max());
            //Answer 2
            Console.WriteLine(sumThree);
        }
    }
}