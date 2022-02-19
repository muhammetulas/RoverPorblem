using RoverPorblem.Services;
using static RoverPorblem.Helpers.Enums;

Console.Write("Please enter max size: ");
var maxPoints = Console.ReadLine()?
    .Trim()
    .Split(' ')
    .Select(int.Parse)
    .ToList();

Console.Write("Please enter first rover starting point: ");
var firstRoverStartPositions = Console.ReadLine()?
    .Trim()
    .Split(' ');

Position firstRoverPosition = new Position();

if(firstRoverStartPositions == null || firstRoverStartPositions.Length <= 0)
{
    throw new Exception("The rover starting position can not be null");
}

if (firstRoverStartPositions.Length == 3)
{
    firstRoverPosition.RoverX = Convert.ToInt32(firstRoverStartPositions[0]);
    firstRoverPosition.RoverY = Convert.ToInt32(firstRoverStartPositions[1]);
    firstRoverPosition.RoverDirection = (Directions)Enum.Parse(typeof(Directions), firstRoverStartPositions[2]);
}

Console.Write("Please enter first rover moves: ");
var firstRoverMoves = Console.ReadLine()?.ToUpper();

Console.Write("Please enter second rover starting point: ");
var secondRoverStartPositions = Console.ReadLine()?
    .Trim()
    .Split(' ');

Position secondRoverPosition = new Position();

if (secondRoverStartPositions == null || secondRoverStartPositions.Length <= 0)
{
    throw new Exception("The rover starting position can not be null");
}

if (secondRoverStartPositions.Count() == 3)
{
    secondRoverPosition.RoverX = Convert.ToInt32(secondRoverStartPositions[0]);
    secondRoverPosition.RoverY = Convert.ToInt32(secondRoverStartPositions[1]);
    secondRoverPosition.RoverDirection = (Directions)Enum.Parse(typeof(Directions), secondRoverStartPositions[2]);
}

Console.Write("Please enter second rover moves: ");
var secondRoverMoves = Console.ReadLine()?.ToUpper();

try
{
    firstRoverPosition.CalculateMoving(maxPoints, firstRoverMoves);
    secondRoverPosition.CalculateMoving(maxPoints, secondRoverMoves);
    Console.WriteLine($"{firstRoverPosition.RoverX} {firstRoverPosition.RoverY} {firstRoverPosition.RoverDirection}");
    Console.WriteLine($"{secondRoverPosition.RoverX} {secondRoverPosition.RoverY} {secondRoverPosition.RoverDirection}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();