namespace NErMario
{
    public class Cell
    {
        public bool HasWall { get; set; }
        public string View { get; set; }

        public Cell()
        {
            HasWall = false;
            View = "*";
        }

    }
}
