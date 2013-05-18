namespace CodeEval_Moderate
{
    class CashRegister
    {
        public CashRegister(string line)
        {
            string[] str = line.Split(new char[] { ';' });
            double PP = double.Parse(str[0]);
            double CH = double.Parse(str[1]);
            string output = "";

            if(CH < PP)
                output = "ERROR";
            else if(CH == PP)
                output = "ZERO";
            else
            {
                double dif = System.Math.Round(CH - PP, 2);
                output = Change(dif);
            }

            System.Console.WriteLine(output);
        }

        public string Change(double d)
        {
            string str = "";

            if(d >= 100)
            {
                str += "ONE HUNDRED,";
                d -= 100;
                d = System.Math.Round(d, 2);
            }
            if(d >= 50)
            {
                str += "FIFTY,";
                d -= 50;
                d = System.Math.Round(d, 2);
            }
            if(d >= 20)
            {
                str += "TWENTY,";
                d -= 20;
                d = System.Math.Round(d, 2);
            }
            if(d >= 10)
            {
                str += "TEN,";
                d -= 10;
                d = System.Math.Round(d, 2);
            }
            if(d >= 5)
            {
                str += "FIVE,";
                d -= 5;
                d = System.Math.Round(d, 2);
            }
            if(d >= 2)
            {
                str += "TWO,";
                d -= 2;
                d = System.Math.Round(d, 2);
            }
            if(d >= 1)
            {
                str += "ONE,";
                d -= 1;
                d = System.Math.Round(d, 2);
            }
            if(d >= 0.5)
            {
                str += "HALF DOLLAR,";
                d -= 0.5;
                d = System.Math.Round(d, 2);
            }
            if(d >= 0.25)
            {
                str += "QUARTER,";
                d -= 0.25;
                d = System.Math.Round(d, 2);
            }
            if(d >= 0.10)
            {
                str += "DIME,";
                d -= 0.1;
                d = System.Math.Round(d, 2);
            }
            if(d >= 0.05)
            {
                str += "NICKEL,";
                d -= 0.05;
                d = System.Math.Round(d, 2);
            }
            if(d >= 0.01)
            {
                str += "PENNY,";
                d -= 0.01;
                d = System.Math.Round(d, 2);
            }
            return str.Substring(0, str.Length - 1);
        }
    }
}
