using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace практк
{
    public class CalculationsMonitor
    {
        private List<Результат_расчета> results = new List<Результат_расчета>();


        public CalculationsMonitor() 
        {

        }

        public void AddResult(Результат_расчета R)
        {
            results.Add(R);
        }

        public string Save()
        {
            string overall = " ";

            foreach (Результат_расчета result in results)
            {
                overall = result.GetFormula() + "; "
                           + result.GetValues() + "; "
                           + result.GetResult();
            }
            return overall;
        }
    }
}
