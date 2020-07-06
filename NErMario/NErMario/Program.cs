using System;

namespace NErMario
{
    public class Program
    {
        public static Hero Hero { get; set; }
        public static Field Field { get; set; }
        public static bool IsGameContinue { get; set; }

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Field = new Field();
            Hero = new Hero();
            IsGameContinue = true;

            while (IsGameContinue)
            {
                DisplayField();
                MoveHero();
                Console.Clear();
            }

            Console.WriteLine("You win!!!");
            string a = Console.ReadLine();
        }

        public static void DisplayField()
        {
            int cellPosition = 0; 

            for (int i = 0; i < Setting.FieldArea; i++)
            {
                for (int k = 0; k < Setting.FieldArea; k++)
                {

                    if (Field.Cells[cellPosition].HasWall)
                    {
                        Console.Write("# ");
                    }
                    else
                    {
                        if (cellPosition == Hero.CurrentPosition)
                        {
                            Console.Write(Hero.View + " ");
                        }
                        else
                        {
                            Console.Write(Field.Cells[cellPosition].View + " ");
                        }

                    }
                    
                    cellPosition++;
                }

                Console.WriteLine();
            }
        }

        public static void MoveHero()
        {
            int step = GetStep();
            int heroNextPosition = Hero.CurrentPosition + step;
            int cellsCount = Setting.FieldArea;

            if (!Field.Cells[heroNextPosition].HasWall)
            {
                Hero.CurrentPosition = heroNextPosition;
            }

            if (Hero.CurrentPosition == cellsCount - 1)
            {
                IsGameContinue = false;
            }
        }

        public static int GetStep()
        {
            int step = 0;

            string key = Console.ReadKey().Key.ToString();

            switch (key.ToLower())
            {
                case "w":
                    step = -Setting.VerticalStep;
                    break;
                case "s":
                    step = Setting.VerticalStep;
                    break;
                case "a":
                    step = -1;
                    break;
                case "d":
                    step = 1;
                    break;
                default:
                    step = 0;
                    break;
            }

            return step;
        }
    }
}
