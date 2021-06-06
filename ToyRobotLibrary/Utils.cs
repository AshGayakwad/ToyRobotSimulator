using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotLibrary
{
    public static class Utils
    {
        // Parse the co-ordinates from the input string
        public static int? GetCoordinates(string input)
        {
            int? result = null;
            int res;
            var success = int.TryParse(input, out res);
            return success ? res : result;

        }

        // Parse the direction from the input string
        public static Directions GetFacingDirection(string input)
        {
            object direction;
            Enum.TryParse(typeof(Directions), input.ToUpper(), out direction);
            return (Directions)direction;
        }        

        // Check if the robot is on the table top 
        public static bool isValidPlace(int? a)
        {
            //Table size 5 X 5 
            var startIndex = 0;
            var endIndex = 4;
            return a >= startIndex && a <= endIndex;
        }

        public static string[] GetArrayFromInput(string input)
        {
            return input?.Split(new string[] { " ", "," }, StringSplitOptions.None);
        }

        public static void ExecuteCommand(Action action, bool condition)
        {
            if (condition && action != null)
            {
                action.Invoke();
            }
        }

    }
}
