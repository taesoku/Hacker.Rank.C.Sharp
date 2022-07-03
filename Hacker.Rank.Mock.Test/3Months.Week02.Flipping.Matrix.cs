using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacker.Rank.Mock.Test
{
    class _3MonthsWeek02FlippingMatrix
    {
        public static void Answer()
        {

        }

        public static int FlippingMatrix(List<List<int>> inputs)
        {
            var count = inputs.Count;
            var sum = 0;
            var xCoordinate = 0;
            while (xCoordinate < count / 2)
            {
                var yCoordinate = 0;
                while (yCoordinate < count / 2)
                {
                    var currX = Math.Max(inputs[xCoordinate][yCoordinate], inputs[xCoordinate][count - 1 - yCoordinate]);
                    var currY = Math.Max(inputs[count - 1 - xCoordinate][yCoordinate], inputs[count - 1 - xCoordinate][count - 1 - yCoordinate]);
                    sum += Math.Max(currX, currY);
                    yCoordinate++;
                }
                xCoordinate++;
            }
            return sum;
        }
    }
}
