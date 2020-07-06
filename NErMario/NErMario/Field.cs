using System;

namespace NErMario
{
    public class Field
    {
        public Cell[] Cells { get; set; }

        public Field()
        {
            int cellsCount = Setting.FieldArea;
            Cells = new Cell[cellsCount * cellsCount];

            InitializeCells();
            SetWalls();
        }

        public void InitializeCells()
        {
            for (int i = 0; i < Cells.Length; i++)
            {
                Cells[i] = new Cell();
            }
        }

        public void SetWalls()
        {
            Random random = new Random();
            int cellsCount = Setting.FieldArea * Setting.FieldArea;

            for (int i = 0; i < 100; i++)
            {
                int wallPosition = random.Next(1, cellsCount - 2);
                Cells[wallPosition].HasWall = true;
            }
        }
    }
}
