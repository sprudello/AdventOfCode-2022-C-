using System.Globalization;
using System.Runtime.CompilerServices;

namespace AoC02122022
{
    internal class Program
    {
        static void Main()
        {
            string inputPath = @"";
            string text = File.ReadAllText(inputPath);
            string[] round = text.Split("\r\n");
            List<string> player1 = new List<string>();
            List<string> player2 = new List<string>();
            string[] rock = { "A", "X" };
            string[] paper = { "B", "Y" };
            string[] scissors = { "C", "Z" };
            string win = "Z";
            string even = "Y";
            string lose = "X";

            int score = 0;

            for (int i = 0; i < round.Length; i++)
            {
                string[] items = round[i].Split(' ');
                player1.Add(items[0]);
                player2.Add(items[1]);
            }

            //This is for the first problem

            for (int i = 0; i < player1.Count; i++)
            {
                if (player2[i] == rock[1])
                {
                    score += 1;
                    if (player1[i] == rock[0])
                    {
                        score += 3;
                    }
                    else if (player1[i] == scissors[0])
                    {
                        score += 6;
                    }
                }
                if (player2[i] == paper[1])
                {
                    score += 2;
                    if (player1[i] == rock[0])
                    {
                        score += 6;
                    }
                    else if (player1[i] == paper[0])
                    {
                        score += 3;
                    }
                }
                if (player2[i] == scissors[1])
                {
                    score += 3;
                    if (player1[i] == scissors[0])
                    {
                        score += 3;
                    }
                    else if (player1[i] == paper[0])
                    {
                        score += 6;
                    }
                }
            }
            Console.WriteLine($"First problem: {score}");
            score = 0;
            //This is for the second problem

            for (int i = 0; i < round.Length; i++)
            {
                if (player1[i] == rock[0])
                {
                    if (player2[i] == win)
                    {
                        score += 2 + 6;
                    }
                    else if (player2[i] == even)
                    {
                        score += 1 + 3;
                    }
                    else if (player2[i] == lose)
                    {
                        score += 3 + 0;
                    }
                }
                else if (player1[i] == paper[0])
                {
                    if (player2[i] == win)
                    {
                        score += 3 + 6;
                    }
                    else if (player2[i] == even)
                    {
                        score += 2 + 3;
                    }
                    else if (player2[i] == lose)
                    {
                        score += 1 + 0;
                    }
                }
                else if (player1[i] == scissors[0])
                {
                    if (player2[i] == win)
                    {
                        score += 1 + 6;
                    }
                    else if (player2[i] == even)
                    {
                        score += 3 + 3;
                    }
                    else if (player2[i] == lose)
                    {
                        score += 2 + 0;
                    }
                }
            }
            Console.WriteLine($"Second problem: {score}");
        }
    }
}