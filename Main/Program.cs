using System;
using ToyRobotLibrary;

namespace ToyRobotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool robotOnMove = true;

            var input = new Command(new Robot());
            Console.WriteLine("Welcome to the Toy Robot Simulation!");

            //Console.WriteLine("Do you want to read input via an input file (Y/N) ?");           

            Console.WriteLine("\nExample Input and Output \nInput Format: \nPLACE 0,0,NORTH \nLEFT \nMOVE \nRIGHT \nMOVE \nREPORT \nOutput Format: 0,1,NORTH \n");

            Console.WriteLine("\nEXIT\\QUIT to quit the program");

            Console.WriteLine("\nPlease provide the input ");

            while (robotOnMove)
            {
                try
                {
                    input.HandleCommand(Utils.GetArrayFromInput(Console.ReadLine()));
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Invalid Input : " +ex.Message);
                }
                
            }
            Environment.Exit(0);
        }
    }
}
