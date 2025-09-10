using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a > 0 && b > 0) answer = true;
            else if (a < 0 && b < 0) answer = true;
            else if (a == 0  && b == 0) answer = true;
                // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;
            double a = Math.Ceiling(d);
            // code here
            if (Math.Pow(a,2) != Math.Pow(d,2)) answer = true;

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0)
            {
                if (a % b == 0) answer = true;
            }
            
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) > Math.Abs(f) && Math.Abs(d) > Math.Abs(g)) answer = d;
            if (Math.Abs(f) > Math.Abs(d) && Math.Abs(f) > Math.Abs(g)) answer = f;
            if (Math.Abs(g) > Math.Abs(f) && Math.Abs(g) > Math.Abs(d)) answer = g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1) answer = 0;
            if (x <= 0 && x > -1) answer = x + 1;
            if (x > 0) answer = 1;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double r, a;
            r = Math.Sqrt (circleS / Math.PI);
            a = Math.Sqrt(squareS);
            if (2 * r <= a) answer = true;
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0)
                {
                    answer = -1;
                }
                else return answer;
            }
            else
            {
                if (f > 0) answer = 1;
                else return answer;
            }
                // end

                return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            a = a / 2;
            b = b / 2;
            c = c / 2;



            if (a + b + c > 0)
            {
                if (((a + b + c) % 3 == 0) || ((a + b + c + 1) % 3 == 0)) answer = true;
            }



            // end

            return answer;
        }
    }
}