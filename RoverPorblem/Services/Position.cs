using RoverPorblem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RoverPorblem.Helpers.Enums;

namespace RoverPorblem.Services
{
    public class Position : IPositon
    {
        public int RoverX { get; set; }
        public int RoverY { get; set; }
        public Directions RoverDirection { get; set; }

        public Position()
        {
            this.RoverX = this.RoverY = 0;
            this.RoverDirection = Directions.N;
        }

        private void Rotate90Left()
        {
            switch (this.RoverDirection)
            {
                case Directions.N:
                    this.RoverDirection = Directions.W;
                    break;
                case Directions.S:
                    this.RoverDirection = Directions.E;
                    break;
                case Directions.E:
                    this.RoverDirection = Directions.N;
                    break;
                case Directions.W:
                    this.RoverDirection = Directions.S;
                    break;
                default:
                    break;
            }
        }

        private void Rotate90Right()
        {
            switch (this.RoverDirection)
            {
                case Directions.N:
                    this.RoverDirection = Directions.E;
                    break;
                case Directions.S:
                    this.RoverDirection = Directions.W;
                    break;
                case Directions.E:
                    this.RoverDirection = Directions.S;
                    break;
                case Directions.W:
                    this.RoverDirection = Directions.N;
                    break;
                default:
                    break;
            }
        }

        private void MoveForward()
        {
            switch (this.RoverDirection)
            {
                case Directions.N:
                    this.RoverY += 1;
                    break;
                case Directions.S:
                    this.RoverY -= 1;
                    break;
                case Directions.E:
                    this.RoverX += 1;
                    break;
                case Directions.W:
                    this.RoverX -= 1;
                    break;
                default:
                    break;
            }
        }

        public void CalculateMoving(List<int>? maxPoints, string? moves)
        {
            if(maxPoints == null || moves == null)
            {
                throw new Exception("The maximum size or rover moves can not be null");
            }
            else
            {
                foreach (var move in moves)
                {
                    switch (move)
                    {
                        case 'M':
                            this.MoveForward();
                            break;
                        case 'L':
                            this.Rotate90Left();
                            break;
                        case 'R':
                            this.Rotate90Right();
                            break;
                        default:
                            Console.WriteLine($"Invalid Character {move}");
                            break;
                    }

                    if (this.RoverX < 0 || this.RoverX > maxPoints[0] || this.RoverY < 0 || this.RoverY > maxPoints[1])
                    {
                        throw new Exception($"Oops! Position can not be beyond bounderies (0 , 0) and ({maxPoints[0]} , {maxPoints[1]})");
                    }
                }
            }
        }
    }
}
