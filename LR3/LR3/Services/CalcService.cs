namespace ASP.NET.services
{
    public class CalcService: interfaces.ICalcService
    {
      
        public Double Add(Double num1, Double num2)
        {
            return num1 + num2;
        }
        public Double Subtract(Double num1, Double num2)
        {
            return num1 - num2;
        }
        public Double Multiply(Double num1, Double num2)
        {
            return num1 * num2;
        }
        public Double Divide(Double num1, Double num2)
        {
            return num1 / num2;
        }

    }
}

