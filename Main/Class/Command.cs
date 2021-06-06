using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobotLibrary;

namespace ToyRobotSimulator
{
    public class Command : ICommand
    {
        private IRobotActions _robot;

        private bool _place = false;

        public Command(IRobotActions robot)
        {
            _robot = robot;
        }

        public bool HandleCommand(string[] command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("Command is empty");
            }

            switch (command[0].ToUpper())
            {
                case InputCommand.PLACE:
                    var placed = command.Length == 4 && _robot.Place(new PlacementRequest
                    {
                        X = Utils.GetCoordinates(command[1]),
                        Y = Utils.GetCoordinates(command[2]),
                        Facing = Utils.GetFacingDirection(command[3])

                    });

                    Utils.ExecuteCommand(action: () => _place = placed, _place == false);
                    break;

                case InputCommand.MOVE:
                    Utils.ExecuteCommand(action: () => _robot.Move(), _place);
                    break;

                case InputCommand.LEFT:
                    Utils.ExecuteCommand(action: () => _robot.Left(), _place);
                    break;

                case InputCommand.RIGHT:
                    Utils.ExecuteCommand(action: () => _robot.Right(),  _place);
                    break;

                case InputCommand.REPORT:
                    Utils.ExecuteCommand(action: () => _robot.Report(),  _place);
                    break;

                case InputCommand.QUIT:
                    Utils.ExecuteCommand(action: () => _robot.Quit(), true);
                    break;

                case InputCommand.EXIT:
                    Utils.ExecuteCommand(action: () => _robot.Exit(), true);
                    break;

                default:
                    break;
            }

            return _place;
        }
    }
}
