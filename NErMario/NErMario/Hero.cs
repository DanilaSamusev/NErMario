namespace NErMario
{
    public class Hero
    {
        public string View { get; set; }
        public int CurrentPosition { get; set; }

        public Hero()
        {
            CurrentPosition = 0;
            View = "O";
        }
    }
}
