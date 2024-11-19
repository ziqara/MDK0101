using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практк
{
    public class Результат_расчета
    {
        private string formula_;
        private List<double> values_ = new List<double>();
        private double result_;

        public Результат_расчета(string formula, List<double> values, double result)
        {
            formula_ = formula;
            values_ = values;
            result_ = result;
        }

        public string GetFormula()
        { return formula_; }

        public List<double> GetValues() 
        { return values_; }

        public double GetResult() 
        { return result_; }
    }
}
