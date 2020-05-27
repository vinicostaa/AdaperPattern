using System;
namespace AdapterPattern
{
    public sealed class CalcRectangle
    {
        public int CalculateArea(Rectangle rectangle)
        {
            int area = (rectangle.Width * rectangle.Height);
            return area;
        }
    }
}
