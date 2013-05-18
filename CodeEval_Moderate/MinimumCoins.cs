namespace CodeEval_Moderate
{
    class MinimumCoins
    {
        public MinimumCoins(string line)
        {
            double number = double.Parse(line);
            double numFive = System.Math.Truncate(number / 5.00);
            number -= 5 * numFive;
            double numThree = System.Math.Truncate(number / 3.00);
            number -= 3 * numThree;
            double numOne = System.Math.Truncate(number / 1.00);
            number -= 1 * numOne;

            System.Console.WriteLine(numOne + numThree + numFive);
        }
    }
}
