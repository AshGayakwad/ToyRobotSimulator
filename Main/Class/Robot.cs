using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobotLibrary;

namespace ToyRobotSimulator
{
    public class Robot : IRobotActions

    {
        private int? x;
        private int? y;
        private Directions? f;
        //Implement the Interface method Place()
        public bool Place(PlacementRequest placementRequest)
        {
            var placed = false;

            if (placementRequest != null && Utils.isValidPlace(placementRequest.X) && Utils.isValidPlace(placementRequest.Y) && placementRequest.Facing.ToString() != null)
            {
                x = placementRequest.X;
                y = placementRequest.Y;
                f = placementRequest.Facing;
                placed = true;
            }

            return placed;
        }

        //Implement the Interface method Move()
        public void Move()
        {
            switch (f)
            {
                case Directions.NORTH:
                    Utils.ExecuteCommand(() => y++, Utils.isValidPlace(y + 1));
                    break;

                case Directions.SOUTH:
                    Utils.ExecuteCommand(() => y--, Utils.isValidPlace(y - 1));
                    break;

                case Directions.EAST:
                    Utils.ExecuteCommand(() => x++, Utils.isValidPlace(x + 1));
                    break;

                case Directions.WEST:
                    Utils.ExecuteCommand(() => x--, Utils.isValidPlace(x - 1));
                    break;
                default:
                    break;
            }
        }

        //Implement the Interface method Left()
        public void Left()
        {
            Turn(() => (int)f - 1);            
        }

        //Implement the Interface method Right()
        public void Right()
        {
            Turn(() => (int)f + 1);            
        }

        private void Turn(Func<int> newDirection)
        {
            f = (newDirection() < 0) ? Directions.EAST : (Directions)(newDirection() % 4);
        }

        //Implement the Interface method Report()
        public void Report()
        {
            Console.WriteLine($"Output: {x},{y},{f}");
        }

        public void Exit()
        {
              Environment.Exit(0);
        }

        public void Quit()
        {
            Environment.Exit(0);
        }
    }
}
