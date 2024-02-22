namespace gettinguserInput
{

    internal class CalculatorBase
    {
        private int FirstNumber;
        private int SecondNumber;

        public CalculatorBase(int firstNumber, int secondNumber)
        {
            this.FirstNumber = firstNumber;
            this.SecondNumber = secondNumber;
        }

        public void SetFirstNumber(int firstNumber)
        {
            this.FirstNumber = firstNumber;
        }

        public int GetFirstNumber()
        {
            return this.FirstNumber;
        }

        public int GetSecondNumber()
        {
            return this.SecondNumber;
        }

        public int GetSum()
        {
            return this.FirstNumber + this.SecondNumber;
        }

        public int GetProduct()
        {
            return this.FirstNumber * this.SecondNumber;
        }

        public int GetDifference()
        {
            return this.FirstNumber - this.SecondNumber;
        }

        public double GetQuotient()
        {
            return (double)this.FirstNumber / Math.Max(1, this.SecondNumber); // Use Math.Max to avoid division by zero
        }
    }
}