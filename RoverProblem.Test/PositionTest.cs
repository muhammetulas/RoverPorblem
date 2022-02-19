using RoverPorblem.Services;
using System.Collections.Generic;
using Xunit;
using static RoverPorblem.Helpers.Enums;

namespace RoverProblem.Test
{
    public class PositionTest
    {
        [Fact]
        public void TestScanrio_12N_LMLMLMLMM()
        {
            Position position = new Position()
            {
                RoverX = 1,
                RoverY = 2,
                RoverDirection = Directions.N
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "LMLMLMLMM";

            position.CalculateMoving(maxPoints, moves);

            var actualOutput = $"{position.RoverX} {position.RoverY} {position.RoverDirection}";
            var expectedOutput = "1 3 N";

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void TestScanrio_33E_MRRMMRMRRM()
        {
            Position position = new Position()
            {
                RoverX = 3,
                RoverY = 3,
                RoverDirection = Directions.E
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "MMRMMRMRRM";

            position.CalculateMoving(maxPoints, moves);

            var actualOutput = $"{position.RoverX} {position.RoverY} {position.RoverDirection}";
            var expectedOutput = "5 1 E";

            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}