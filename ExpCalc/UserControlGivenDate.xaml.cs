using ExpCalc;
using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Label = System.Windows.Controls.Label;

namespace HRCalculator
{
	/// <summary>
	/// Логика взаимодействия для UserControlGivenDate.xaml
	/// </summary>
	public partial class UserControlGivenDate : System.Windows.Controls.UserControl
	{
		Period statePeriod;

		public UserControlGivenDate(string period)
		{
			InitializeComponent();
			statePeriod = new ExperienceCalculator().ConvertStringToPeriod(period);
			string experienceString = "";
			if (statePeriod.Years.ToString().Length == 1)
				experienceString += " ";
			experienceString += statePeriod.Years.ToString();
			if(statePeriod.Months.ToString().Length == 1)
				experienceString += " ";
			experienceString += statePeriod.Months.ToString();
			if (statePeriod.Days.ToString().Length == 1)
				experienceString += " ";
			experienceString += statePeriod.Days.ToString();
			textBox_experience.Text = experienceString;
		}

		private void button_calculate_Click(object sender, RoutedEventArgs e)
		{
			statePeriod = new ExperienceCalculator().ConvertStringToPeriod(textBox_experience.Text);
			var localDate = SubtractPeriod(statePeriod);
			textBlock_givenDate.Text = localDate.Day + "." + localDate.Month + "." + localDate.Year;
		}

		private LocalDate SubtractPeriod(Period period)
		{
			return new ExperienceCalculator().ConvertStringToLocalDate(textBox_date.Text).Minus(period);
		}
	}
}
