using System;
using System.Collections.Generic;
using System.Text;

namespace Test1
{
    public static class MyExtensions
    {
        public static int MyIncrement(this int x, int maxValue)
        {
            if(x < maxValue)
            {
                x++;
            }
            else
            {
                x = maxValue;
            }
            return x; 
        }

        public static int MyDecrement(this int x, int minValue)
        {
            if (x > minValue)
            {
                x--;
            }
            else
            {
                x = minValue;
            }
            return x;
        }
        public static ICarActions AddAccelerationOfMovement(this ICarActions iCarActions, int acceleration)
        {
            iCarActions.accelerationOfMovement += acceleration;
            return iCarActions;
        }
    }
}
