using ExpCalc;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRCalculator
{
    interface IDecreeVacation
    {
        string CalculateDateAfterDecree(string startDate, string decreeStart, string decreeEnd);
    }

    class DecreeVacation : IDecreeVacation
    {
        ExperienceCalculator expCalc = new ExperienceCalculator();

        public string CalculateDateAfterDecree(string startDate, string decreeStart, string decreeEnd)
        {
            var decreeStartDate = expCalc.ConvertStringToLocalDate(decreeStart);
            var startLocalDate = expCalc.ConvertStringToLocalDate(startDate);
            var periodAfterDecree = Period.Between(startLocalDate, decreeStartDate, PeriodUnits.Days);
            return expCalc.ConvertStringToLocalDate(decreeEnd).Plus(new PeriodBuilder { Days = Convert.ToInt32(365 - periodAfterDecree.Days - 1) }.Build()).ToString("dd.MM.yyyy", null);
        }
    }
}
