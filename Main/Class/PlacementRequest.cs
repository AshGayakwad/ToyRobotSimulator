using ToyRobotLibrary;

namespace ToyRobotSimulator
{
    public class PlacementRequest
    {
        public int? X { get; set; }
        public int? Y { get; set; }
        public Directions Facing { get; set; }
    }
}