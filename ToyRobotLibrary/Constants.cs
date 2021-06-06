using System;

namespace ToyRobotLibrary
{
    //String constants to define the input commands 
    public static class InputCommand
    {
        public const string PLACE = "PLACE"; // Initial position 
        public const string MOVE = "MOVE"; //Move robot by one position in the direction
        public const string REPORT = "REPORT"; //Final position
        public const string RIGHT = "RIGHT"; //Clock-wise 
        public const string LEFT = "LEFT"; //Anti-clockwise
        public const string EXIT = "EXIT"; //EXIT the Robot movement program
        public const string QUIT = "QUIT"; //EXIT the Robot movement program
    }  

    //Enum defining the direction 0,1,2,3
    public enum Directions { NORTH, EAST, SOUTH,  WEST };
    
    //Enum defining the direction 0,1,2,3,4
    public enum Commands { PLACE, MOVE, LEFT, RIGHT, REPORT };
   
}