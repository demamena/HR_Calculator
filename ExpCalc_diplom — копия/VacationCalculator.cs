using System;
using System.Windows;

namespace ExpCalc
{
    interface IVacationCalculator
	{
		int CalculateVacation(int holidays, string startDate, string endDate);
	}
    class VacationCalculator : IVacationCalculator
    {
        public int CalculateVacation(int holidays, string startDateString, string endDateString)
        {
            return (int)Math.Round(Convert.ToDouble(((new ExperienceCalculator().ConvertStringToLocalDate(endDateString).ToDateTimeUnspecified() - new ExperienceCalculator().ConvertStringToLocalDate(startDateString).ToDateTimeUnspecified()).TotalDays + 1) * holidays) / 365);
        }
    }
}
