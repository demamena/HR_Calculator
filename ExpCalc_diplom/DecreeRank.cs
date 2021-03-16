using ExpCalc;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HRCalculator
{
	interface IDecreeRank
	{
		string[] CalculateRanksAndDates(string startDate, string endDate, string currentDate);
	}

	class DecreeRank : IDecreeRank
	{
		ExperienceCalculator expCalc = new ExperienceCalculator();

        private Period[] CalculatePeriodForRank(string startDate, string endDate)
		{
			Period periodForRank = expCalc.SubtractPeriods(expCalc.CalculateCurrentPeriod(expCalc.ConvertStringToLocalDate(startDate),
				expCalc.ConvertStringToLocalDate(endDate)),
				new PeriodBuilder { Days = 1 }.Build());
			MessageBox.Show(periodForRank.ToString());
			Period[] periods = { periodForRank, expCalc.SubtractPeriods(new PeriodBuilder { Years = 3 }.Build(), periodForRank) };
			return periods;
		}

		private LocalDate CalculateDateOfNextRank(Period period, string currentDate)
		{
			return expCalc.ConvertStringToLocalDate(currentDate).Plus(period).PlusDays(1);
		}

        public string[] CalculateRanksAndDates(string startDate, string endDate, string currentDate)
        {
			Period[] periods = CalculatePeriodForRank(startDate, endDate);
			string[] calculations = { expCalc.ConvertPeriodToString(periods[0]), expCalc.ConvertPeriodToString(periods[1]), CalculateDateOfNextRank(periods[1], currentDate).ToString("dd.MM.yyyy", null) };
			return calculations;
        }
    }
}
