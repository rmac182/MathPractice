using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice.ViewModels
{
    public class EquationViewModel : ObservableObject
    {
        public Random rnd = new Random();
        public int addendum1;
        public int addendum2;
        public int minuend;
        public int subtrahend;
        public int factor1;
        public int factor2;
        public int dividend;
        public int divisor;
        public int sum;
        public int difference;
        public int product;
        public int quotient;
        public string remainder;

        private string _expression;

        public string Expression
        {
            get
            {
                if (string.IsNullOrEmpty(_expression))
                {
                    return $"__+__=";
                }
                return _expression;
            }
            set
            {
                _expression = value;
                OnPropertyChanged("Expression");
            }
        }

        private string _sum;

        public string Sum
        {
            get { return _sum; }
            set
            {
                _sum = GetSum();
                OnPropertyChanged("Sum");
            }
        }

        private string _userInput;

        public string UserInput
        {
            get { return _userInput; }
            set
            {
                _userInput = value;
                OnPropertyChanged("UserInput");
            }
        }


        public EquationViewModel()
        {
            addendum1 = rnd.Next(1,11);
            addendum2 = rnd.Next(1,11);

            Expression = $"{addendum1}+{addendum2}=";
        }
        public void NewAdditionExpression()
        {
            addendum1 = rnd.Next(1, 11);
            addendum2 = rnd.Next(1, 11);

            Expression = $"{addendum1}+{addendum2}=";
            
        }
        public void NewSubtractionExpression()
        {
            minuend = rnd.Next(1, 11);
            subtrahend = rnd.Next(1,minuend);

            Expression = $"{minuend}-{subtrahend}=";
        }
        public void NewMultiplicationExpression()
        {
            factor1 = rnd.Next(1, 11);
            factor2 = rnd.Next(1, 11);

            Expression = $"{factor1}X{factor2}=";
        }
        public void NewDivisionExpression()
        {
            dividend = rnd.Next(1,11);
            divisor = rnd.Next(1, dividend);

            Expression = $"{dividend}/{divisor}=";
        }
           
            

        public string GetSum()
        {
            return (addendum1 + addendum2).ToString();
        }

        public string GetDifference()
        {
            return (minuend - subtrahend).ToString();
        }

        public string GetProduct()
        {
            return (factor1 * factor2).ToString();
        }

        public string GetQuotient()
        {
            return (dividend / divisor).ToString();
        }
            
        public string GetRemainder()
        {
            remainder = (dividend % divisor).ToString();
            return remainder;
        }
        
    }
}
