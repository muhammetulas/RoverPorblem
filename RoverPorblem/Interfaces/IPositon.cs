using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverPorblem.Interfaces
{
    public interface IPositon
    {
        void CalculateMoving(List<int> maxPoints, string moves);
    }
}
