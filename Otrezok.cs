namespace TPOAS_1
{
    public class Otrezok
    {
        public double Len(double x1, double y1, double x2, double y2)
        {
            return Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)), 2);
        }
    }
}
