using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotSimulator
{
    public interface IRobotActions
    {
        bool Place(PlacementRequest placementRequest);
        void Move();
        void Left();
        void Right();
        void Report();
        void Exit();
        void Quit();
    }
}
