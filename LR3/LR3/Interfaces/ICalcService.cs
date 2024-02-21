namespace ASP.NET.interfaces
{
	public interface ICalcService
	{
		public Double Add(Double num1, Double num2);
        public Double Subtract(Double num1, Double num2);
        public Double Multiply(Double num1, Double num2);
        public Double Divide(Double num1, Double num2);
    }
}