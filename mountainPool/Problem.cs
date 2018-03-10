using System;
using System.Linq;

namespace mountainPool
{
    public class Problem
    {
        public int Solve(int[] heights)
        {
            if (heights.Length == 0) throw new ArgumentException("Empty array");
            if (heights.Length > 32000) throw new ArgumentException("Lenght should be less than 32000");
            if (heights.Max() > 32000 || heights.Min() < 0) throw new ArgumentException("Height should be between 0 and 32000");

            int max = heights.Max();
            int lenght = heights.Length;

            int totalWater = 0;
            for (int vertical = 0; vertical <= max ; vertical++)
                for (int horizontal = 0, walkInCanyon = 0; horizontal < lenght ;horizontal++)
                {
                    walkInCanyon += heights[horizontal] < vertical ? 1 : 0;
                    if (walkInCanyon > 0 && heights[horizontal] >= vertical) {
                        if (horizontal - walkInCanyon - 1 >= 0)
                            totalWater += walkInCanyon;
                        walkInCanyon = 0;
                    }
                }
            return totalWater;
        }
    }
}
