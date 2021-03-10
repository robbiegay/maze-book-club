namespace RobbiesMazes.Data.Models
{
    public class Cell
    {
        public bool North { get; set; }
        public bool East { get; set; }

        public Cell()
        {
            North = true;
            East = true;
        }

        public Cell(bool north, bool east)
        {
            North = north;
            East = east;
        }
    }
}
