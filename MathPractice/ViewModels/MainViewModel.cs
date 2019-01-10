using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice.ViewModels
{
    public class MainViewModel
    {
        public EquationViewModel Equation { get; private set; }
        public ResultViewModel Result { get; private set; }
        public MainViewModel()
        {
            Equation = new EquationViewModel();
            Result = new ResultViewModel();
        }

        

    }
}
